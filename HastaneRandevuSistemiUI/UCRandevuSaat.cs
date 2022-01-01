using HastaneRandevuSistemiBusiness;
using HastaneRandevuSistemiEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemiUI
{
    public partial class UCRandevuSaat : UserControl
    {
        public UCRandevuSaat()
        {
            InitializeComponent();
        }

        public Doktor Doktorum { get; set; }
        public DateTime DisaridanGelenTarih { get; set; } = DateTime.Now;
        RandevuManager rndManager = new RandevuManager();
        public DateTime SecilenRandevuTarihi { get; set; }
        public bool RandevuAlmaAktifMi { get; set; }

        private void UCRandevuSaat_Load(object sender, EventArgs e)
        {
            RandevuAlmaAktifMi = false;
            comboBoxSaatler.DisplayMember = "SaatDilimi";
            comboBoxSaatler.ValueMember = "Id";
            comboBoxSaatler.DataSource = SaatViewModel.SaatlerListesiniGetir();
            comboBoxSaatler.SelectedIndex = -1;
            RandevuButonlarinIsimleriniTemizle();

            //butonlara ortak click event verildi
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Click += new EventHandler(btnClick);
            }
            //yeni ekledim
            Doktorum = null;
            DRveTrhyeGoreButonlarinAktifPasifIslemleriniYap();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void comboBoxSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GecmisSaatlerinButonlariniPasiflestir();
                if (Doktorum == null)
                {
                    RandevuButonlariniPasiflestir();
                    return;
                }
                if (comboBoxSaatler.SelectedIndex >= 0)
                {
                    //Butonların textleri ayarlanacak
                    ButonlarinTextleriniAyarla();
                    //Butonların aktif pasif durumları ayarlanacak
                    DRveTrhyeGoreButonlarinAktifPasifIslemleriniYap();
                }
                else
                {
                    RandevuButonlarinIsimleriniTemizle();
                    RandevuButonlariniPasiflestir();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA:" + ex.Message);
            }
        }

        private void GecmisSaatlerinButonlariniPasiflestir()
        {
            foreach (Button btnitem in tableLayoutPanelRandevuButonlar.Controls)
            {
                int dakika = 0;
                int saat = 0;
                if (btnitem.Text.Length > 3)
                {
                    int.TryParse(btnitem.Text.Substring(3, 2), out dakika);
                    int.TryParse(btnitem.Text.Substring(0, 2), out saat);
                }

                // 10:15
                if (DisaridanGelenTarih.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    if (saat < DateTime.Now.Hour)
                    {
                        btnitem.BackColor = Color.DarkGray;
                        btnitem.Enabled = false;
                    }
                    else if (saat == DateTime.Now.Hour)
                    {
                        if (dakika <= DateTime.Now.Minute)
                        {
                            btnitem.BackColor = Color.DarkGray;
                            btnitem.Enabled = false;
                        }

                    }
                }
            }
        }

        private void DRveTrhyeGoreButonlarinAktifPasifIslemleriniYap()
        {
            try
            {
                // yeni ekledim 2
                RandevuButonlariniAktiflestir();

                if (Doktorum != null)
                {
                    //randevuları alalım
                    List<Randevu> drRandevulari = rndManager.DoktorunRandevulariniTariheGoreGetir(Doktorum, DisaridanGelenTarih);
                    if (drRandevulari.Count > 0)
                    {
                        // o randevuları tek tek dolaşalım pasifleştirme işlemimizi yapalım
                        foreach (Randevu item in drRandevulari)
                        {
                            if (item.RandevuTarihi.ToShortTimeString().Substring(0, 2) == comboBoxSaatler.Text.Substring(0, 2)) //10 ==10
                            {
                                string itemsaatim = item.RandevuTarihi.ToShortTimeString();
                                string itemdk = itemsaatim.Substring(3, 2); // sadece dkyı aldık

                                switch (itemdk)
                                {
                                    case "00":
                                        button00.Enabled = false;
                                        break;
                                    case "15":
                                        button15.Enabled = false;
                                        break;
                                    case "30":
                                        button30.Enabled = false;
                                        break;
                                    case "45":
                                        button45.Enabled = false;
                                        break;
                                    default:
                                        break;
                                }

                            }


                        }
                    }

                }
                else
                {
                    RandevuButonlarinIsimleriniTemizle();
                    RandevuButonlariniPasiflestir();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void ButonlarinTextleriniAyarla()
        {
            if (comboBoxSaatler.SelectedIndex >= 0)
            {
                string saatim = SaatViewModel.SaatlerListesiniGetir().FirstOrDefault(x => x.Id == (int)comboBoxSaatler.SelectedValue).SaatDilimi.Substring(0, 2); //09
                foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
                {
                    switch (item.Name)
                    {

                        case "btn00":
                            button00.Text = $"{saatim}:00"; //09:00
                            break;
                        case "btn15":
                            button15.Text = $"{saatim}:15";//09:15
                            break;
                        case "btn30":
                            button30.Text = $"{saatim}:30";//09:30
                            break;
                        case "btn45":
                            button45.Text = $"{saatim}:45";//09:45
                            break;
                        default:
                            item.Text = "---";
                            break;
                    }
                }
            }
            else
            {

            }
        }

        private void RandevuButonlariniAktiflestir()
        {
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Enabled = true;
            }
        }
        private void RandevuButonlariniPasiflestir()
        {
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Enabled = false;
            }
        }
        private void RandevuButonlarinIsimleriniTemizle()
        {
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Text = "---";
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            // tıklandığında randevu tarihi oluşacak
            //09:15
            Button btn = sender as Button;
            int saat = Convert.ToInt32(btn.Text.Substring(0, 2));
            int dakika = Convert.ToInt32(btn.Text.Substring(3, 2));

            SecilenRandevuTarihi = new DateTime(DisaridanGelenTarih.Year, DisaridanGelenTarih.Month, DisaridanGelenTarih.Day,
                saat, dakika, 00);
            RandevuAlmaAktifMi = true;
        }

        public void Temizle()
        {
            RandevuAlmaAktifMi = false;
            comboBoxSaatler.SelectedIndex = -1;
            RandevuButonlarinIsimleriniTemizle();
            RandevuButonlariniPasiflestir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            GecmisSaatlerinButonlariniPasiflestir();

        }
    }
}

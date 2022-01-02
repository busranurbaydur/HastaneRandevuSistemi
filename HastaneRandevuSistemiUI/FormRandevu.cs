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
    public partial class FormRandevu : Form
    {
        public FormRandevu()
        {
            InitializeComponent();
        }
        HastaManager hastaManagerim = new HastaManager();
        DoktorManager doktorManagerim = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();
        private void RandevuSistemi_Load(object sender, EventArgs e)
        {
           
            ServisGroupBoxPasiflestir();
            RandevuGroupBoxPasiflestir();
            HastaListBoxiniDoldur();
            DateTimePickeriAyarla();
            DoktorlariComboBoxCiktiAlDrSeceDoldur();
            comboBoxCiktiAlDrSec.SelectedIndex = -1;

        }
        private void DoktorlariComboBoxCiktiAlDrSeceDoldur()
        {
            //
            comboBoxCiktiAlDrSec.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxCiktiAlDrSec.ValueMember = "DoktorId";
            comboBoxCiktiAlDrSec.DataSource = doktorManagerim.TumAktifDoktorlariGetir();

        }

        private void DateTimePickeriAyarla()
        {
            dateTimePickerRandevuTarihiAyarla.Format = DateTimePickerFormat.Custom;
            dateTimePickerRandevuTarihiAyarla.CustomFormat
            = "dd.MM.yyyy";
            dateTimePickerRandevuTarihiAyarla.MinDate = DateTime.Now;
            dateTimePickerRandevuTarihiAyarla.MaxDate = dateTimePickerRandevuTarihiAyarla.MinDate.AddDays(15);
            dateTimePickerRandevuTarihiAyarla.Value = DateTime.Now;

            dateTimePickerCiktiAl.Format = DateTimePickerFormat.Custom;
            dateTimePickerCiktiAl.CustomFormat = "dd.MM.yyyy";
            dateTimePickerCiktiAl.MinDate = DateTime.Now;
            dateTimePickerCiktiAl.MaxDate = dateTimePickerCiktiAl.MinDate.AddDays(15);
            dateTimePickerCiktiAl.Value = DateTime.Now;
        }

        HastaManager hastaManager = new HastaManager();
        DoktorManager doktorManager = new DoktorManager();
        private void HastaListBoxiniDoldur()
        {
            listBoxHastalar.DataSource = hastaManager.TumHastalariGetir();
            listBoxHastalar.SelectedIndex = -1;

           
        }
        
        private void RandevuGroupBoxPasiflestir()
        {
            groupBoxRandevu.Enabled = false;
        }
        private void RandevuGroupBoxAktiflestir()
        {
            groupBoxRandevu.Enabled = true;
        }
        private void ServisGroupBoxPasiflestir()
        {
            groupBoxServis.Enabled = false;
        }

        private void textBoxHastaTCArama_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHastaTCArama.Text.Trim().Length>=2)
            {
                listBoxHastalar.DataSource = hastaManager.TCNumarasinaGoreHastayiBul(textBoxHastaTCArama.Text);
            }
            else
            {
                HastaListBoxiniDoldur();
            }
        }

        private void listBoxHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHastalar.SelectedIndex>=0)
            {
                ServisGroupBoxAktiflestir();
            }
            else
            {
                ServisGroupBoxPasiflestir();
                RandevuGroupBoxPasiflestir();
            }
            DateTimePickeriAyarla();
            ucRandevuSaat1.Temizle();

        }

        private void ServisGroupBoxAktiflestir()
        {
            groupBoxServis.Enabled = true;
            //combobox servis dolmalı
            ComboboxServisiDoldur();
        }

        private void ComboboxServisiDoldur()
        {
            comboBoxServisSec.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServisSec.DataSource = Enum.GetValues(typeof(Branslar));
            comboBoxServisSec.SelectedIndex = -1;
        }

        private void comboBoxServisSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServisSec.SelectedIndex>=0)
            {
                Branslar drBransi;
                Enum.TryParse(comboBoxServisSec.SelectedValue.ToString(), out drBransi);
                listBoxDoktorlar.DataSource = doktorManager.BransaGoreDoktorlariGetir(drBransi);
            }
            else
            {
                listBoxDoktorlar.DataSource = null;
            }
            listBoxDoktorlar.SelectedIndex = -1;
            DateTimePickeriAyarla();
            ucRandevuSaat1.Temizle();
        }

        private void listBoxDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla();

            if (listBoxDoktorlar.SelectedIndex>=0)
            {
                RandevuGroupBoxAktiflestir();
                Doktor seciliDr = listBoxDoktorlar.SelectedItem as Doktor;
                ucRandevuSaat1.Doktorum = seciliDr;
            }
            else
            {
                RandevuGroupBoxPasiflestir();
                ucRandevuSaat1.Doktorum = null;
            }

        }

        private void dateTimePickerRandevuTarihiAyarla_ValueChanged(object sender, EventArgs e)
        {
            
            ucRandevuSaat1.DisaridanGelenTarih = dateTimePickerRandevuTarihiAyarla.Value;
            ucRandevuSaat1.Temizle();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxHastalar.SelectedIndex < 0)
                {
                    MessageBox.Show("Hasta seçmeden randevu alma işlemleri yapılamaz!");
                    return;
                }
                if (listBoxDoktorlar.SelectedIndex < 0)
                {
                    throw new Exception("Doktor seçmeden randevu alma işlemleri yapılamaz!");
                }
                if (!ucRandevuSaat1.RandevuAlmaAktifMi)
                {
                    MessageBox.Show("Randevu alabilmeniz için yukarıdaki randevu saati butonlarına tıklayarak saat seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //Hastanın o tarihe o saate başka randevusu varsa alamaz
                Hasta secilenHasta = listBoxHastalar.SelectedItem as Hasta;
                //dikkat etmek gerekli?
                if (rndManager.HastaninSecilenTarihveSaatteRandevusuVarMi(secilenHasta, ucRandevuSaat1.SecilenRandevuTarihi))
                {
                    MessageBox.Show($"Dikkat:{ucRandevuSaat1.SecilenRandevuTarihi.ToString("dd.MM.yyyy HH:mm:ss")} başka bir randevunuz vardır. Bu nedenle aynı saate randevu alamazsınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // hasta randevusunu alabilir
                Doktor secilenDoktor = listBoxDoktorlar.SelectedItem as Doktor;
                Randevu yeniRandevu = new Randevu()
                {
                    HastaId = secilenHasta.HastaId,
                    DoktorId = secilenDoktor.DoktorId,
                    RandevuTarihi = ucRandevuSaat1.SecilenRandevuTarihi
                };
                bool rndAlindiMi = false;
                rndAlindiMi = rndManager.RandevuyuAl(yeniRandevu);
                if (rndAlindiMi)
                {
                    MessageBox.Show($"Randevunuz alınmıştır", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Alınan randevuyu ListView'e ekleyelim:
                    ListVieweRandevuyuEkle(yeniRandevu);
                    // temizlik
                    ucRandevuSaat1.Temizle();
                    //dateTimePickerRandevuTarihiAyarla.Value = DateTime.Now;
                    RandevuGroupBoxPasiflestir();
                    ServisGroupBoxPasiflestir();
                    listBoxHastalar.SelectedIndex = -1;
                }
                else
                {
                    throw new Exception("Randevu alma işleminde beklenmedik bir hata oluştu!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void ListVieweRandevuyuEkle(Randevu yeniRandevu)
        {
            RandevuViewModel randevu = rndManager.RandevuyuViewModeleAktar(yeniRandevu);
            ListViewItem li = new ListViewItem();
            li.Text = randevu.Servis;
            li.SubItems.Add(randevu.DoktorAdSoyad);
            li.SubItems.Add(randevu.HastaAdSoyad);
            li.SubItems.Add(randevu.RandevuTarihi.ToString("dd.MM.yyyy HH:mm"));
            li.Tag = randevu;
            listViewAlinanRandevular.Items.Add(li);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            ucRandevuSaat1.Temizle();
            // Temizlik Randevu Al
            RandevuGroupBoxPasiflestir();
            
            comboBoxServisSec.SelectedIndex = -1;
            listBoxDoktorlar.SelectedIndex = -1;
            ServisGroupBoxPasiflestir();
            listBoxHastalar.SelectedIndex = -1;

            btnCiktiAl.Enabled = false;
            dateTimePickerCiktiAl.Value = DateTime.Now;
            comboBoxCiktiAlDrSec.SelectedIndex = -1;
        }

        private void comboBoxCiktiAlDrSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCiktiAlDrSec.SelectedIndex >= 0)
                {
                    Doktor secilenDr = doktorManagerim.DoktoruIdyeGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                    CiktiAlButonununAktifPasifliginiAyarla(secilenDr, dateTimePickerCiktiAl.Value);

                }
                else
                {
                    dateTimePickerCiktiAl.Value = DateTime.Now;
                    btnCiktiAl.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void CiktiAlButonununAktifPasifliginiAyarla(Doktor dr, DateTime tarih)
        {
            btnCiktiAl.Enabled = false;
            btnCiktiAl.BackColor = SystemColors.Control;
            if (dr != null)
            {
                List<Randevu> rndList = rndManager.DoktorunRandevulariniTariheGoreGetir(dr, tarih);
                if (rndList.Count > 0)
                {
                    btnCiktiAl.Enabled = true;
                    btnCiktiAl.BackColor = Color.Pink;
                }
                else
                {
                    MessageBox.Show($"{dr.ToString()} adlı doktorun {tarih.ToString("dd.MM.yyyy")} tarihinde randevusu yoktur.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void dateTimePickerCiktiAl_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCiktiAlDrSec.SelectedIndex > 0)
            {
                Doktor secilenDr = doktorManagerim.DoktoruIdyeGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                CiktiAlButonununAktifPasifliginiAyarla(secilenDr, dateTimePickerCiktiAl.Value);
            }
        }

        private void btnCiktiAl_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
                btnCiktiAl.BackColor = Color.DeepSkyBlue;
                btnCiktiAl.Enabled = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Doktor doktorum = doktorManagerim.DoktoruIdyeGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);

                

                //Bitmap bmp1 = Properties.Resources.doktorRandevularResim1;
                //Image resim1 = bmp1;

                //Bitmap bmp2 = Properties.Resources.doktorRandevularResim2;
                //Image resim2 = bmp2;

                //e.Graphics.DrawImage(resim1, 25, 25, resim1.Width / 10, resim1.Height / 10);
                //e.Graphics.DrawImage(resim2, 725, 25, resim2.Width / 10, resim2.Height / 10);

                e.Graphics.DrawString($"{EnumManager.BransiTurkceStringOlarakVer(doktorum.Brans)} - {doktorum.ToString()} - {dateTimePickerCiktiAl.Value.ToString("dd.MM.yyyy")} Tarihine Ait Randevular", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));

                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));

                e.Graphics.DrawString("Tarih ve Saat", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
                e.Graphics.DrawString("Hasta Adı Soyadı", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));

                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));

                Point konumTarih = new Point(50, 235);
                Point konumHasta = new Point(200, 235);

                string[] saatler = {"09:00", "09:15", "09:30", "09:45","10:00","10:15","10:30","10:45",
                                    "11:00","11:15","11:30","11:45","13:00","13:15","13:30","13:45","14:00",
                                    "14:15","14:30","14:45","15:00","15:15","15:30","15:45"};
                Randevu[] siraliRandevular = new Randevu[saatler.Length];

                List<Randevu> drRandevular = rndManager.DoktorunRandevulariniTariheGoreGetir(doktorum, dateTimePickerCiktiAl.Value);

                foreach (Randevu item in drRandevular)
                {
                    for (int i = 0; i < saatler.Length; i++)
                    {
                        if (saatler[i] == item.RandevuTarihi.ToString("HH:mm"))
                        {
                            siraliRandevular[i] = item;
                        }
                    }
                }

                foreach (Randevu item in siraliRandevular)
                {
                    if (item != null)
                    {
                        konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);
                        e.Graphics.DrawString($"{item.RandevuTarihi.ToString("dd.MM.yyyy")} - " + $"{item.RandevuTarihi.ToString("HH:mm")}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumTarih);

                        konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
                        e.Graphics.DrawString($"{item.Hasta.HastaAdi} {item.Hasta.HastaSoyadi}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA! - " + ex.Message);
            }
        }

        private void tabPageCiktiAl_Leave(object sender, EventArgs e)
        {
            comboBoxCiktiAlDrSec.SelectedIndex = -1;
        }
    }
}

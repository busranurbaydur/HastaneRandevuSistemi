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

            
            

        }

        private void DateTimePickeriAyarla()
        {
            dateTimePickerRandevuTarihiAyarla.Format = DateTimePickerFormat.Custom;
            dateTimePickerRandevuTarihiAyarla.CustomFormat
            = "dd.MM.yyyy";
            dateTimePickerRandevuTarihiAyarla.MinDate = DateTime.Now;
            dateTimePickerRandevuTarihiAyarla.MaxDate = dateTimePickerRandevuTarihiAyarla.MinDate.AddDays(15);
            dateTimePickerRandevuTarihiAyarla.Value = DateTime.Now;
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
                listBoxDoktorlar.DataSource = doktorManager.TumAktifDoktorlariGetir();
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
            DateTimePickeriAyarla();
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
                    dateTimePickerRandevuTarihiAyarla.Value = DateTime.Now;
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
           
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            // Temizlik Randevu Al
            RandevuGroupBoxPasiflestir();
            ucRandevuSaat1.Temizle();
            comboBoxServisSec.SelectedIndex = -1;
            listBoxDoktorlar.SelectedIndex = -1;
            ServisGroupBoxPasiflestir();
            listBoxHastalar.SelectedIndex = -1;
        }
    }
}

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
    public partial class FormHastalar : Form
    {
        public FormHastalar()
        {
            InitializeComponent();
        }

        HastaManager hastaManager = new HastaManager();
        private void tabControlHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormHastalar_Load(object sender, EventArgs e)
        {
            DataGrideTumHastalariGetir();
            maskedTextBoxHastaTelEkle.Mask = @"\0\5##-###-##-##";
        }

        private void DataGrideTumHastalariGetir()
        {
            dataGridViewHastalariListele.DataSource = hastaManager.TumHastalariGetir();
        }

        private void buttonHastaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxHastaAdiEkle.Text.Trim().Length < 2)
                {
                    throw new Exception("Lütfen hasta adını düzgün giriniz");
                }
                if (textBoxHastaSoyadiEkle.Text.Trim().Length < 2)
                {
                    throw new Exception("Lütfen hasta soyadını düzgün giriniz");
                }
                if (textBoxHastaTCNoEkle.Text.Trim().Length != 11)
                {
                    throw new Exception("TC kimlik numarası 11 haneli olmalıdır.");
                }
                if (textBoxHastaTCNoEkle.Text.Any(x => !char.IsDigit(x)))
                {
                    throw new Exception("TC kimlik numarası rakamlardan oluşacak şekilde 11 haneli olmalıdır");
                }

                Hasta yeniHasta = new Hasta()
                {
                    TCNumarasi = textBoxHastaTCNoEkle.Text,
                    HastaAdi = textBoxHastaAdiEkle.Text.Trim(),
                    HastaSoyadi = textBoxHastaSoyadiEkle.Text.Trim(),
                    Telefon = maskedTextBoxHastaTelEkle.Text.Replace("-", ""),
                    Email = textBoxHastaEmailEkle.Text
                   
                };

                if (hastaManager.YeniHastaEkle(yeniHasta))
                {
                    MessageBox.Show($"{textBoxHastaAdiEkle.Text.Trim()}  {textBoxHastaSoyadiEkle.Text.Trim()} sisteme hasta olarak eklenmiştir.. ");

                    HastaEkleSayfasiTemizle();
                    DataGrideTumHastalariGetir();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void HastaEkleSayfasiTemizle()
        {
            textBoxHastaAdiEkle.Clear();
            textBoxHastaSoyadiEkle.Clear();
            maskedTextBoxHastaTelEkle.Clear();
            textBoxHastaTCNoEkle.Clear();
            textBoxHastaEmailEkle.Clear();
        }

        private void anaSayfayaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiris frmGiris = new FormGiris();
            this.Hide();
            frmGiris.Show();
        }
    }
}

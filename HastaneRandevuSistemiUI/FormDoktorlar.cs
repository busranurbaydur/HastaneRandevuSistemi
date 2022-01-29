﻿using HastaneRandevuSistemiBusiness;
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
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }
        DoktorManager drManager = new DoktorManager();
        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            DoktorGrideVerileriGetir();
            comboBoxDoktorBransEkle.DropDownStyle = ComboBoxStyle.DropDownList;

            //comboBoxDrBranslar.DisplayMember = "TheValue";
            //comboBoxDrBranslar.ValueMember = "TheKey";
            //comboBoxDrBranslar.DataSource = EnumManager.TumBranslariGetir();
            //comboBoxDrBranslar.SelectedValue = (int)Branslar.BransYok;
            comboBoxDoktorBransEkle.DataSource = Enum.GetValues(typeof(Branslar));
            maskedTextBoxDoktorTelEkle.Mask = @"\0\5##-###-##-##";
           
            // maskedTextBoxDoktorTelEkle.Mask = "(500)-000-00-00";

        }

        private void comboBoxDoktorBransEkle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDoktorAdiEkle.Text.Trim().Length < 2)
                {
                    throw new Exception("Lütfen doktor adını düzgün giriniz");
                }
                if (textBoxDoktorSoyadiEkle.Text.Trim().Length < 2)
                {
                    throw new Exception("Lütfen doktor soyadını düzgün giriniz");
                }
                if (textBoxDoktorTcEkle.Text.Trim().Length != 11)
                {
                    throw new Exception("TC kimlik numarası 11 haneli olmalıdır.");
                }
                if (textBoxDoktorTcEkle.Text.Any(x => !char.IsDigit(x)))
                {
                    throw new Exception("TC kimlik numarası rakamlardan oluşacakşekilde 11 haneli olmalıdır");
                }

                Branslar drBransi;
                Enum.TryParse(comboBoxDoktorBransEkle.SelectedValue.ToString(), out drBransi);

                Doktor yeniDoktor = new Doktor()
                {
                    DoktorAdi = textBoxDoktorAdiEkle.Text.Trim(),
                    DoktorSoyadi = textBoxDoktorSoyadiEkle.Text.Trim(),
                    Email = textBoxDoktorEmailEkle.Text,
                    Telefon = maskedTextBoxDoktorTelEkle.Text.Replace("-", ""),
                    TCNumarasi = textBoxDoktorTcEkle.Text,
                    Brans = drBransi,
                    AktifMi = true
                };
                //sisteme ekleme yapması gerekiyor..

                if (drManager.YeniDoktorEkle(yeniDoktor))
                {
                    MessageBox.Show($"{textBoxDoktorAdiEkle.Text.Trim()}  {textBoxDoktorSoyadiEkle.Text.Trim()} sisteme yeni doktor olarak eklenmiştir.. ");


                    DoktorEkleSayfasiTemizle();
                    DoktorGrideVerileriGetir();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }

        }

        private void DoktorGrideVerileriGetir()
        {
           dataGridViewDoktorListele.DataSource =drManager.TumAktifDoktorlariGetir();
            dataGridViewDoktorListele.Columns["AktifMi"].Width = 50;
            dataGridViewDoktorListele.Columns["DoktorId"].Width = 30;
            dataGridViewDoktorListele.Columns["DoktorAdi"].Width = 80;
            dataGridViewDoktorListele.Columns["DoktorSoyadi"].Width = 80;
        }

        private void DoktorEkleSayfasiTemizle()
        {
            textBoxDoktorAdiEkle.Clear();
            textBoxDoktorSoyadiEkle.Clear();
            textBoxDoktorEmailEkle.Clear();
            textBoxDoktorTcEkle.Clear();
            comboBoxDoktorBransEkle.SelectedIndex = 0;
            maskedTextBoxDoktorTelEkle.Clear();
        }

        private void anaSayfayaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiris frmGiris = new FormGiris();
            this.Hide();
            frmGiris.Show();
        }
    }
}

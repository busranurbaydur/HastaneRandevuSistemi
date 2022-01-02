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
    public partial class FormHastaCagir : Form
    {
        public FormHastaCagir()
        {
            InitializeComponent();
        }
        // GLOBAL ALAN
        DoktorManager drManager = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();
        Doktor secilenDoktor { get; set; }

        private void FormHastaCagir_Load(object sender, EventArgs e)
        {
            // comboBox
            ComboyaDoktorlariGetir();

            // btnDurdur
            btnDurdur.Enabled = false;
            btnBasla.Enabled = true;

            // label
            labelHasta.Text = "---------";

            // Doktor
            secilenDoktor = null;
        }
        
        private void ComboyaDoktorlariGetir()
        {
            comboBoxDoktor.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxDoktor.ValueMember = "DoktorId";
            comboBoxDoktor.DataSource = drManager.TumAktifDoktorlariGetir();
            comboBoxDoktor.SelectedIndex = -1;
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDoktor.SelectedIndex >= 0)
            {
                secilenDoktor = drManager.DoktoruIdyeGoreBul((int)comboBoxDoktor.SelectedValue);

            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 sanie verdik.
            timer1.Start(); // ya da timer1.Enabled=true;

            btnDurdur.Enabled = true;
            btnBasla.Enabled = false;


        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // ya da timer1.Enabled=false;
            btnDurdur.Enabled = false;
            btnBasla.Enabled = true;
            labelHasta.Font = new Font("Arial", 35);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Font BuyukFont = new Font("Arial", 45);
            Font NormalFont = new Font("Arial", 40);

            if (DateTime.Now.Second % 2 == 0)
            {
                labelHasta.Font = BuyukFont;
                labelHasta.ForeColor = Color.Red;
            }
            else
            {
                labelHasta.Font = NormalFont;
                labelHasta.ForeColor = Color.Blue;
            }

            if (secilenDoktor != null)
            {
                // Doktorun seçilen bugüne ait randevularını bulalım:

                List<Randevu> drRandevulari = rndManager.DoktorunRandevulariniTariheGoreGetir(secilenDoktor, DateTime.Now);

                if (drRandevulari.Count > 0)
                {
                    Randevu bulunanRandevu = drRandevulari.FirstOrDefault(x => x.RandevuTarihi.ToString("HH") == DateTime.Now.Hour.ToString() && x.RandevuTarihi.Minute < DateTime.Now.Minute + 2 && x.RandevuTarihi.Minute > DateTime.Now.Minute - 2);

                    if (bulunanRandevu != null)
                    {
                        labelHasta.Text = $"{bulunanRandevu.Hasta.HastaAdi} {bulunanRandevu.Hasta.HastaSoyadi}";
                    }

                }
            }

        }
    }
}

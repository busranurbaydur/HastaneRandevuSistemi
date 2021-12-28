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

        private void RandevuSistemi_Load(object sender, EventArgs e)
        {
            //1. Servis Grupbox ı ve tarih saat grupboxları pasif olmalı
            ServisGroupBoxPasiflestir();
            RandevuGroupBoxPasiflestir();

            //2.Bll de hastamanager oluşturduk.
            HastaListBoxiniDoldur();
            DateTimePickeriAyarla(DateTime.Now);

            
            

        }

        private void DateTimePickeriAyarla(DateTime trh)
        {
            dateTimePickerRandevuTarihiAyarla.Format = DateTimePickerFormat.Custom;
            dateTimePickerRandevuTarihiAyarla.CustomFormat
            = "dd.MM.yyyy";
            dateTimePickerRandevuTarihiAyarla.MinDate = trh;
            dateTimePickerRandevuTarihiAyarla.MaxDate = dateTimePickerRandevuTarihiAyarla.MinDate.AddDays(15);
            dateTimePickerRandevuTarihiAyarla.Value = trh;
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
            DateTimePickeriAyarla(DateTime.Now);

        }

        private void ServisGroupBoxAktiflestir()
        {
            groupBoxServis.Enabled = true;
            //combobox servis dolmalı
            ComboboxServisiDoldur();
        }

        private void ComboboxServisiDoldur()
        {
            comboBoxServisSec.DataSource = Enum.GetValues(typeof(Branslar));
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
            DateTimePickeriAyarla(DateTime.Now);
        }

        private void listBoxDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(DateTime.Now);

            if (listBoxDoktorlar.SelectedIndex>=0)
            {
                RandevuGroupBoxAktiflestir();
            }
            else
            {
                RandevuGroupBoxPasiflestir();
            }

        }

        private void dateTimePickerRandevuTarihiAyarla_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(dateTimePickerRandevuTarihiAyarla.Value);
        }
    }
}

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
    public partial class RandevuSistemi : Form
    {
        public RandevuSistemi()
        {
            InitializeComponent();
        }

        private void RandevuSistemi_Load(object sender, EventArgs e)
        {
            //Servis Grupbox ı ve tarih saat grupboxları pasif olmalı


            ServisGroupBoxPasiflestir();
            RandevuGroupBoxPasiflestir();
        }

        private void RandevuGroupBoxPasiflestir()
        {
            groupBoxRandevu.Enabled = false;
        }

        private void ServisGroupBoxPasiflestir()
        {
            groupBoxServis.Enabled = false;
        }
    }
}

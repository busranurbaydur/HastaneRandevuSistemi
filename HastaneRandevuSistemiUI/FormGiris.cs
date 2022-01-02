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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void buttonDoktorIslemleri_Click(object sender, EventArgs e)
        {
            FormDoktor frmDoktor = new FormDoktor();
            this.Hide();
            frmDoktor.Show();
        }

        private void buttonHastaIslemleri_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRandevuIslemleri_Click(object sender, EventArgs e)
        {
            FormRandevu frmRandevu = new FormRandevu();
            this.Hide();
            frmRandevu.Show();
        }

        private void buttonHastaCagir_Click(object sender, EventArgs e)
        {
            FormHastaCagir frmHastaCagir = new FormHastaCagir();
            this.Hide();
            frmHastaCagir.Show();
        }
    }
}

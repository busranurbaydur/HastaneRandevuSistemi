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

        private void UCRandevuSaat_Load(object sender, EventArgs e)
        {
            comboBoxSaatler.DisplayMember = "SaatDilimi";
            comboBoxSaatler.ValueMember = "Id";
            comboBoxSaatler.DataSource = SaatViewModel.SaatlerListesiniGetir();

        }

        private void comboBoxSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSaatler.SelectedIndex>=0)
            {
               string saat= comboBoxSaatler.SelectedValue.ToString().Substring(0,3); //09:
                foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
                {
                    switch (item.Name)
                    {
                        case "buton00":
                            button00.Text = $"{saat}00";
                            break;
                        default:
                            break;
                    }
                }

            }
            else
            {

            }
        }
    }
}

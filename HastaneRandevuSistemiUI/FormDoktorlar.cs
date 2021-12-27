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
    public partial class FormDoktor : Form
    {
        public FormDoktor()
        {
            InitializeComponent();
        }

        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            comboBoxDoktorBransEkle.DropDownStyle = ComboBoxStyle.DropDownList;

          
            comboBoxDoktorBransEkle.DisplayMember = "TheValue";
            comboBoxDoktorBransEkle.ValueMember = "TheKey";

            comboBoxDoktorBransEkle.DataSource = EnumManager.TumBranslariGetir();

            comboBoxDoktorBransEkle.SelectedValue = (int)Branslar.BransYok;
        }

        private void comboBoxDoktorBransEkle_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }
    }
}


namespace HastaneRandevuSistemiUI
{
    partial class FormDoktor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDoktorListele = new System.Windows.Forms.TabPage();
            this.dataGridViewDoktorListele = new System.Windows.Forms.DataGridView();
            this.tabPageDoktorEkle = new System.Windows.Forms.TabPage();
            this.maskedTextBoxDoktorTelEkle = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDoktorBransEkle = new System.Windows.Forms.ComboBox();
            this.buttonDoktorEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDoktorEmailEkle = new System.Windows.Forms.TextBox();
            this.textBoxDoktorSoyadiEkle = new System.Windows.Forms.TextBox();
            this.textBoxDoktorAdiEkle = new System.Windows.Forms.TextBox();
            this.textBoxDoktorTcEkle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageDoktorListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorListele)).BeginInit();
            this.tabPageDoktorEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDoktorListele);
            this.tabControl1.Controls.Add(this.tabPageDoktorEkle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDoktorListele
            // 
            this.tabPageDoktorListele.Controls.Add(this.dataGridViewDoktorListele);
            this.tabPageDoktorListele.Location = new System.Drawing.Point(4, 25);
            this.tabPageDoktorListele.Name = "tabPageDoktorListele";
            this.tabPageDoktorListele.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoktorListele.Size = new System.Drawing.Size(792, 421);
            this.tabPageDoktorListele.TabIndex = 0;
            this.tabPageDoktorListele.Text = "Doktor Listesi";
            this.tabPageDoktorListele.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoktorListele
            // 
            this.dataGridViewDoktorListele.AllowUserToAddRows = false;
            this.dataGridViewDoktorListele.AllowUserToDeleteRows = false;
            this.dataGridViewDoktorListele.AllowUserToOrderColumns = true;
            this.dataGridViewDoktorListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktorListele.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDoktorListele.Name = "dataGridViewDoktorListele";
            this.dataGridViewDoktorListele.ReadOnly = true;
            this.dataGridViewDoktorListele.RowHeadersWidth = 51;
            this.dataGridViewDoktorListele.RowTemplate.Height = 24;
            this.dataGridViewDoktorListele.Size = new System.Drawing.Size(771, 398);
            this.dataGridViewDoktorListele.TabIndex = 0;
            // 
            // tabPageDoktorEkle
            // 
            this.tabPageDoktorEkle.Controls.Add(this.maskedTextBoxDoktorTelEkle);
            this.tabPageDoktorEkle.Controls.Add(this.comboBoxDoktorBransEkle);
            this.tabPageDoktorEkle.Controls.Add(this.buttonDoktorEkle);
            this.tabPageDoktorEkle.Controls.Add(this.label6);
            this.tabPageDoktorEkle.Controls.Add(this.textBoxDoktorEmailEkle);
            this.tabPageDoktorEkle.Controls.Add(this.textBoxDoktorSoyadiEkle);
            this.tabPageDoktorEkle.Controls.Add(this.textBoxDoktorAdiEkle);
            this.tabPageDoktorEkle.Controls.Add(this.textBoxDoktorTcEkle);
            this.tabPageDoktorEkle.Controls.Add(this.label5);
            this.tabPageDoktorEkle.Controls.Add(this.label4);
            this.tabPageDoktorEkle.Controls.Add(this.label3);
            this.tabPageDoktorEkle.Controls.Add(this.label2);
            this.tabPageDoktorEkle.Controls.Add(this.label1);
            this.tabPageDoktorEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPageDoktorEkle.Name = "tabPageDoktorEkle";
            this.tabPageDoktorEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoktorEkle.Size = new System.Drawing.Size(792, 421);
            this.tabPageDoktorEkle.TabIndex = 1;
            this.tabPageDoktorEkle.Text = "Doktor Ekle";
            this.tabPageDoktorEkle.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxDoktorTelEkle
            // 
            this.maskedTextBoxDoktorTelEkle.Location = new System.Drawing.Point(139, 234);
            this.maskedTextBoxDoktorTelEkle.Name = "maskedTextBoxDoktorTelEkle";
            this.maskedTextBoxDoktorTelEkle.Size = new System.Drawing.Size(186, 22);
            this.maskedTextBoxDoktorTelEkle.TabIndex = 14;
            // 
            // comboBoxDoktorBransEkle
            // 
            this.comboBoxDoktorBransEkle.FormattingEnabled = true;
            this.comboBoxDoktorBransEkle.Location = new System.Drawing.Point(139, 184);
            this.comboBoxDoktorBransEkle.Name = "comboBoxDoktorBransEkle";
            this.comboBoxDoktorBransEkle.Size = new System.Drawing.Size(186, 24);
            this.comboBoxDoktorBransEkle.TabIndex = 13;
            this.comboBoxDoktorBransEkle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktorBransEkle_SelectedIndexChanged);
            // 
            // buttonDoktorEkle
            // 
            this.buttonDoktorEkle.Location = new System.Drawing.Point(139, 348);
            this.buttonDoktorEkle.Name = "buttonDoktorEkle";
            this.buttonDoktorEkle.Size = new System.Drawing.Size(186, 49);
            this.buttonDoktorEkle.TabIndex = 12;
            this.buttonDoktorEkle.Text = "EKLE";
            this.buttonDoktorEkle.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Branş : ";
            // 
            // textBoxDoktorEmailEkle
            // 
            this.textBoxDoktorEmailEkle.Location = new System.Drawing.Point(139, 290);
            this.textBoxDoktorEmailEkle.Name = "textBoxDoktorEmailEkle";
            this.textBoxDoktorEmailEkle.Size = new System.Drawing.Size(186, 22);
            this.textBoxDoktorEmailEkle.TabIndex = 9;
            // 
            // textBoxDoktorSoyadiEkle
            // 
            this.textBoxDoktorSoyadiEkle.Location = new System.Drawing.Point(139, 125);
            this.textBoxDoktorSoyadiEkle.Name = "textBoxDoktorSoyadiEkle";
            this.textBoxDoktorSoyadiEkle.Size = new System.Drawing.Size(186, 22);
            this.textBoxDoktorSoyadiEkle.TabIndex = 7;
            // 
            // textBoxDoktorAdiEkle
            // 
            this.textBoxDoktorAdiEkle.Location = new System.Drawing.Point(139, 73);
            this.textBoxDoktorAdiEkle.Name = "textBoxDoktorAdiEkle";
            this.textBoxDoktorAdiEkle.Size = new System.Drawing.Size(186, 22);
            this.textBoxDoktorAdiEkle.TabIndex = 6;
            // 
            // textBoxDoktorTcEkle
            // 
            this.textBoxDoktorTcEkle.Location = new System.Drawing.Point(139, 19);
            this.textBoxDoktorTcEkle.Name = "textBoxDoktorTcEkle";
            this.textBoxDoktorTcEkle.Size = new System.Drawing.Size(186, 22);
            this.textBoxDoktorTcEkle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C.";
            // 
            // FormDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDoktor";
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.FormDoktorlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDoktorListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorListele)).EndInit();
            this.tabPageDoktorEkle.ResumeLayout(false);
            this.tabPageDoktorEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDoktorListele;
        private System.Windows.Forms.TabPage tabPageDoktorEkle;
        private System.Windows.Forms.DataGridView dataGridViewDoktorListele;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDoktorTelEkle;
        private System.Windows.Forms.ComboBox comboBoxDoktorBransEkle;
        private System.Windows.Forms.Button buttonDoktorEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDoktorEmailEkle;
        private System.Windows.Forms.TextBox textBoxDoktorSoyadiEkle;
        private System.Windows.Forms.TextBox textBoxDoktorAdiEkle;
        private System.Windows.Forms.TextBox textBoxDoktorTcEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


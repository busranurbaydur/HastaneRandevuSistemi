
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfayaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.tabPageDoktorEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDoktorListele);
            this.tabControl1.Controls.Add(this.tabPageDoktorEkle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDoktorListele
            // 
            this.tabPageDoktorListele.Controls.Add(this.dataGridViewDoktorListele);
            this.tabPageDoktorListele.Controls.Add(this.menuStrip1);
            this.tabPageDoktorListele.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoktorListele.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDoktorListele.Name = "tabPageDoktorListele";
            this.tabPageDoktorListele.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDoktorListele.Size = new System.Drawing.Size(826, 485);
            this.tabPageDoktorListele.TabIndex = 0;
            this.tabPageDoktorListele.Text = "Doktor Listesi";
            this.tabPageDoktorListele.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoktorListele
            // 
            this.dataGridViewDoktorListele.AllowUserToAddRows = false;
            this.dataGridViewDoktorListele.AllowUserToDeleteRows = false;
            this.dataGridViewDoktorListele.AllowUserToOrderColumns = true;
            this.dataGridViewDoktorListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewDoktorListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktorListele.GridColor = System.Drawing.Color.Red;
            this.dataGridViewDoktorListele.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewDoktorListele.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDoktorListele.Name = "dataGridViewDoktorListele";
            this.dataGridViewDoktorListele.ReadOnly = true;
            this.dataGridViewDoktorListele.RowHeadersWidth = 51;
            this.dataGridViewDoktorListele.RowTemplate.Height = 24;
            this.dataGridViewDoktorListele.Size = new System.Drawing.Size(800, 400);
            this.dataGridViewDoktorListele.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfayaDonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfayaDonToolStripMenuItem
            // 
            this.anaSayfayaDonToolStripMenuItem.Name = "anaSayfayaDonToolStripMenuItem";
            this.anaSayfayaDonToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.anaSayfayaDonToolStripMenuItem.Text = "Anasayfaya Dön";
            this.anaSayfayaDonToolStripMenuItem.Click += new System.EventHandler(this.anaSayfayaDonToolStripMenuItem_Click);
            // 
            // tabPageDoktorEkle
            // 
            this.tabPageDoktorEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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
            this.tabPageDoktorEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoktorEkle.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDoktorEkle.Name = "tabPageDoktorEkle";
            this.tabPageDoktorEkle.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDoktorEkle.Size = new System.Drawing.Size(826, 485);
            this.tabPageDoktorEkle.TabIndex = 1;
            this.tabPageDoktorEkle.Text = "Doktor Ekle";
            // 
            // maskedTextBoxDoktorTelEkle
            // 
            this.maskedTextBoxDoktorTelEkle.Location = new System.Drawing.Point(313, 213);
            this.maskedTextBoxDoktorTelEkle.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxDoktorTelEkle.Name = "maskedTextBoxDoktorTelEkle";
            this.maskedTextBoxDoktorTelEkle.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxDoktorTelEkle.TabIndex = 14;
            // 
            // comboBoxDoktorBransEkle
            // 
            this.comboBoxDoktorBransEkle.FormattingEnabled = true;
            this.comboBoxDoktorBransEkle.Location = new System.Drawing.Point(313, 172);
            this.comboBoxDoktorBransEkle.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDoktorBransEkle.Name = "comboBoxDoktorBransEkle";
            this.comboBoxDoktorBransEkle.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDoktorBransEkle.TabIndex = 13;
            this.comboBoxDoktorBransEkle.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktorBransEkle_SelectedIndexChanged);
            // 
            // buttonDoktorEkle
            // 
            this.buttonDoktorEkle.Location = new System.Drawing.Point(313, 305);
            this.buttonDoktorEkle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDoktorEkle.Name = "buttonDoktorEkle";
            this.buttonDoktorEkle.Size = new System.Drawing.Size(200, 40);
            this.buttonDoktorEkle.TabIndex = 12;
            this.buttonDoktorEkle.Text = "EKLE";
            this.buttonDoktorEkle.UseVisualStyleBackColor = true;
            this.buttonDoktorEkle.Click += new System.EventHandler(this.buttonDoktorEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Branş : ";
            // 
            // textBoxDoktorEmailEkle
            // 
            this.textBoxDoktorEmailEkle.Location = new System.Drawing.Point(313, 258);
            this.textBoxDoktorEmailEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDoktorEmailEkle.Name = "textBoxDoktorEmailEkle";
            this.textBoxDoktorEmailEkle.Size = new System.Drawing.Size(200, 20);
            this.textBoxDoktorEmailEkle.TabIndex = 9;
            // 
            // textBoxDoktorSoyadiEkle
            // 
            this.textBoxDoktorSoyadiEkle.Location = new System.Drawing.Point(313, 124);
            this.textBoxDoktorSoyadiEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDoktorSoyadiEkle.Name = "textBoxDoktorSoyadiEkle";
            this.textBoxDoktorSoyadiEkle.Size = new System.Drawing.Size(200, 20);
            this.textBoxDoktorSoyadiEkle.TabIndex = 7;
            // 
            // textBoxDoktorAdiEkle
            // 
            this.textBoxDoktorAdiEkle.Location = new System.Drawing.Point(313, 81);
            this.textBoxDoktorAdiEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDoktorAdiEkle.Name = "textBoxDoktorAdiEkle";
            this.textBoxDoktorAdiEkle.Size = new System.Drawing.Size(200, 20);
            this.textBoxDoktorAdiEkle.TabIndex = 6;
            // 
            // textBoxDoktorTcEkle
            // 
            this.textBoxDoktorTcEkle.Location = new System.Drawing.Point(313, 37);
            this.textBoxDoktorTcEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDoktorTcEkle.Name = "textBoxDoktorTcEkle";
            this.textBoxDoktorTcEkle.Size = new System.Drawing.Size(200, 20);
            this.textBoxDoktorTcEkle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C.";
            // 
            // FormDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDoktor";
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.FormDoktorlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDoktorListele.ResumeLayout(false);
            this.tabPageDoktorListele.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorListele)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfayaDonToolStripMenuItem;
    }
}



namespace HastaneRandevuSistemiUI
{
    partial class FormHastalar
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
            this.buttonHastaEkle = new System.Windows.Forms.Button();
            this.textBoxHastaEmailEkle = new System.Windows.Forms.TextBox();
            this.textBoxHastaSoyadiEkle = new System.Windows.Forms.TextBox();
            this.textBoxHastaAdiEkle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.anaSayfayaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewHastalariListele = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPageHastaListele = new System.Windows.Forms.TabPage();
            this.tabPageHastaEkle = new System.Windows.Forms.TabPage();
            this.tabControlHastalar = new System.Windows.Forms.TabControl();
            this.textBoxHastaTCNoEkle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxHastaTelEkle = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalariListele)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPageHastaListele.SuspendLayout();
            this.tabPageHastaEkle.SuspendLayout();
            this.tabControlHastalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHastaEkle
            // 
            this.buttonHastaEkle.Location = new System.Drawing.Point(104, 283);
            this.buttonHastaEkle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHastaEkle.Name = "buttonHastaEkle";
            this.buttonHastaEkle.Size = new System.Drawing.Size(140, 40);
            this.buttonHastaEkle.TabIndex = 12;
            this.buttonHastaEkle.Text = "EKLE";
            this.buttonHastaEkle.UseVisualStyleBackColor = true;
            this.buttonHastaEkle.Click += new System.EventHandler(this.buttonHastaEkle_Click);
            // 
            // textBoxHastaEmailEkle
            // 
            this.textBoxHastaEmailEkle.Location = new System.Drawing.Point(104, 236);
            this.textBoxHastaEmailEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHastaEmailEkle.Name = "textBoxHastaEmailEkle";
            this.textBoxHastaEmailEkle.Size = new System.Drawing.Size(140, 20);
            this.textBoxHastaEmailEkle.TabIndex = 9;
            // 
            // textBoxHastaSoyadiEkle
            // 
            this.textBoxHastaSoyadiEkle.Location = new System.Drawing.Point(104, 143);
            this.textBoxHastaSoyadiEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHastaSoyadiEkle.Name = "textBoxHastaSoyadiEkle";
            this.textBoxHastaSoyadiEkle.Size = new System.Drawing.Size(140, 20);
            this.textBoxHastaSoyadiEkle.TabIndex = 7;
            // 
            // textBoxHastaAdiEkle
            // 
            this.textBoxHastaAdiEkle.Location = new System.Drawing.Point(104, 100);
            this.textBoxHastaAdiEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHastaAdiEkle.Name = "textBoxHastaAdiEkle";
            this.textBoxHastaAdiEkle.Size = new System.Drawing.Size(140, 20);
            this.textBoxHastaAdiEkle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Soyadı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Adı : ";
            // 
            // anaSayfayaDonToolStripMenuItem
            // 
            this.anaSayfayaDonToolStripMenuItem.Name = "anaSayfayaDonToolStripMenuItem";
            this.anaSayfayaDonToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.anaSayfayaDonToolStripMenuItem.Text = "AnaSayfaya Don";
            this.anaSayfayaDonToolStripMenuItem.Click += new System.EventHandler(this.anaSayfayaDonToolStripMenuItem_Click);
            // 
            // dataGridViewHastalariListele
            // 
            this.dataGridViewHastalariListele.AllowUserToAddRows = false;
            this.dataGridViewHastalariListele.AllowUserToDeleteRows = false;
            this.dataGridViewHastalariListele.AllowUserToOrderColumns = true;
            this.dataGridViewHastalariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHastalariListele.Location = new System.Drawing.Point(7, 39);
            this.dataGridViewHastalariListele.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHastalariListele.Name = "dataGridViewHastalariListele";
            this.dataGridViewHastalariListele.ReadOnly = true;
            this.dataGridViewHastalariListele.RowHeadersWidth = 51;
            this.dataGridViewHastalariListele.RowTemplate.Height = 24;
            this.dataGridViewHastalariListele.Size = new System.Drawing.Size(615, 344);
            this.dataGridViewHastalariListele.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfayaDonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPageHastaListele
            // 
            this.tabPageHastaListele.Controls.Add(this.dataGridViewHastalariListele);
            this.tabPageHastaListele.Controls.Add(this.menuStrip1);
            this.tabPageHastaListele.Location = new System.Drawing.Point(4, 22);
            this.tabPageHastaListele.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHastaListele.Name = "tabPageHastaListele";
            this.tabPageHastaListele.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHastaListele.Size = new System.Drawing.Size(792, 424);
            this.tabPageHastaListele.TabIndex = 0;
            this.tabPageHastaListele.Text = "Hasta Listesi";
            this.tabPageHastaListele.UseVisualStyleBackColor = true;
            // 
            // tabPageHastaEkle
            // 
            this.tabPageHastaEkle.Controls.Add(this.maskedTextBoxHastaTelEkle);
            this.tabPageHastaEkle.Controls.Add(this.textBoxHastaTCNoEkle);
            this.tabPageHastaEkle.Controls.Add(this.label6);
            this.tabPageHastaEkle.Controls.Add(this.buttonHastaEkle);
            this.tabPageHastaEkle.Controls.Add(this.textBoxHastaEmailEkle);
            this.tabPageHastaEkle.Controls.Add(this.textBoxHastaSoyadiEkle);
            this.tabPageHastaEkle.Controls.Add(this.textBoxHastaAdiEkle);
            this.tabPageHastaEkle.Controls.Add(this.label5);
            this.tabPageHastaEkle.Controls.Add(this.label4);
            this.tabPageHastaEkle.Controls.Add(this.label3);
            this.tabPageHastaEkle.Controls.Add(this.label2);
            this.tabPageHastaEkle.Location = new System.Drawing.Point(4, 22);
            this.tabPageHastaEkle.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHastaEkle.Name = "tabPageHastaEkle";
            this.tabPageHastaEkle.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHastaEkle.Size = new System.Drawing.Size(792, 424);
            this.tabPageHastaEkle.TabIndex = 1;
            this.tabPageHastaEkle.Text = "Hasta Ekle";
            this.tabPageHastaEkle.UseVisualStyleBackColor = true;
            // 
            // tabControlHastalar
            // 
            this.tabControlHastalar.Controls.Add(this.tabPageHastaListele);
            this.tabControlHastalar.Controls.Add(this.tabPageHastaEkle);
            this.tabControlHastalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlHastalar.Location = new System.Drawing.Point(0, 0);
            this.tabControlHastalar.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlHastalar.Name = "tabControlHastalar";
            this.tabControlHastalar.SelectedIndex = 0;
            this.tabControlHastalar.Size = new System.Drawing.Size(800, 450);
            this.tabControlHastalar.TabIndex = 1;
            this.tabControlHastalar.SelectedIndexChanged += new System.EventHandler(this.tabControlHastalar_SelectedIndexChanged);
            // 
            // textBoxHastaTCNoEkle
            // 
            this.textBoxHastaTCNoEkle.Location = new System.Drawing.Point(104, 51);
            this.textBoxHastaTCNoEkle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHastaTCNoEkle.Name = "textBoxHastaTCNoEkle";
            this.textBoxHastaTCNoEkle.Size = new System.Drawing.Size(140, 20);
            this.textBoxHastaTCNoEkle.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "TC Kimlik No : ";
            // 
            // maskedTextBoxHastaTelEkle
            // 
            this.maskedTextBoxHastaTelEkle.Location = new System.Drawing.Point(104, 191);
            this.maskedTextBoxHastaTelEkle.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBoxHastaTelEkle.Name = "maskedTextBoxHastaTelEkle";
            this.maskedTextBoxHastaTelEkle.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBoxHastaTelEkle.TabIndex = 18;
            // 
            // FormHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlHastalar);
            this.Name = "FormHastalar";
            this.Text = "FormHastalar";
            this.Load += new System.EventHandler(this.FormHastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHastalariListele)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageHastaListele.ResumeLayout(false);
            this.tabPageHastaListele.PerformLayout();
            this.tabPageHastaEkle.ResumeLayout(false);
            this.tabPageHastaEkle.PerformLayout();
            this.tabControlHastalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonHastaEkle;
        private System.Windows.Forms.TextBox textBoxHastaEmailEkle;
        private System.Windows.Forms.TextBox textBoxHastaSoyadiEkle;
        private System.Windows.Forms.TextBox textBoxHastaAdiEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem anaSayfayaDonToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewHastalariListele;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPageHastaListele;
        private System.Windows.Forms.TabPage tabPageHastaEkle;
        private System.Windows.Forms.TabControl tabControlHastalar;
        private System.Windows.Forms.TextBox textBoxHastaTCNoEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHastaTelEkle;
    }
}
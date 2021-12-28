
namespace HastaneRandevuSistemiUI
{
    partial class FormRandevu
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
            this.tabPageRandevuIslem = new System.Windows.Forms.TabPage();
            this.groupBoxServis = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDoktorlar = new System.Windows.Forms.ListBox();
            this.comboBoxServisSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRandevu = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerRandevuTarihiAyarla = new System.Windows.Forms.DateTimePicker();
            this.groupBoxHastaIslemleri = new System.Windows.Forms.GroupBox();
            this.listBoxHastalar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHastaTCArama = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageRandevuIslem.SuspendLayout();
            this.groupBoxServis.SuspendLayout();
            this.groupBoxRandevu.SuspendLayout();
            this.groupBoxHastaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRandevuIslem);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 767);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRandevuIslem
            // 
            this.tabPageRandevuIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxServis);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxRandevu);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxHastaIslemleri);
            this.tabPageRandevuIslem.Location = new System.Drawing.Point(4, 25);
            this.tabPageRandevuIslem.Name = "tabPageRandevuIslem";
            this.tabPageRandevuIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandevuIslem.Size = new System.Drawing.Size(1136, 738);
            this.tabPageRandevuIslem.TabIndex = 0;
            this.tabPageRandevuIslem.Text = "Randevu İşlemleri ";
            // 
            // groupBoxServis
            // 
            this.groupBoxServis.Controls.Add(this.label3);
            this.groupBoxServis.Controls.Add(this.listBoxDoktorlar);
            this.groupBoxServis.Controls.Add(this.comboBoxServisSec);
            this.groupBoxServis.Controls.Add(this.label2);
            this.groupBoxServis.Location = new System.Drawing.Point(384, 16);
            this.groupBoxServis.Name = "groupBoxServis";
            this.groupBoxServis.Size = new System.Drawing.Size(350, 450);
            this.groupBoxServis.TabIndex = 0;
            this.groupBoxServis.TabStop = false;
            this.groupBoxServis.Text = "Servis Ve Doktor Seçimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOKTOR SEÇ :";
            // 
            // listBoxDoktorlar
            // 
            this.listBoxDoktorlar.FormattingEnabled = true;
            this.listBoxDoktorlar.ItemHeight = 16;
            this.listBoxDoktorlar.Location = new System.Drawing.Point(9, 123);
            this.listBoxDoktorlar.Name = "listBoxDoktorlar";
            this.listBoxDoktorlar.Size = new System.Drawing.Size(321, 308);
            this.listBoxDoktorlar.TabIndex = 3;
            this.listBoxDoktorlar.SelectedIndexChanged += new System.EventHandler(this.listBoxDoktorlar_SelectedIndexChanged);
            // 
            // comboBoxServisSec
            // 
            this.comboBoxServisSec.FormattingEnabled = true;
            this.comboBoxServisSec.Location = new System.Drawing.Point(142, 40);
            this.comboBoxServisSec.Name = "comboBoxServisSec";
            this.comboBoxServisSec.Size = new System.Drawing.Size(168, 24);
            this.comboBoxServisSec.TabIndex = 2;
            this.comboBoxServisSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxServisSec_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVİS SEÇ :";
            // 
            // groupBoxRandevu
            // 
            this.groupBoxRandevu.Controls.Add(this.label4);
            this.groupBoxRandevu.Controls.Add(this.dateTimePickerRandevuTarihiAyarla);
            this.groupBoxRandevu.Location = new System.Drawing.Point(757, 16);
            this.groupBoxRandevu.Name = "groupBoxRandevu";
            this.groupBoxRandevu.Size = new System.Drawing.Size(350, 450);
            this.groupBoxRandevu.TabIndex = 0;
            this.groupBoxRandevu.TabStop = false;
            this.groupBoxRandevu.Text = "Randevu Tarih ve Saat İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "TARİH SEÇİNİZ :";
            // 
            // dateTimePickerRandevuTarihiAyarla
            // 
            this.dateTimePickerRandevuTarihiAyarla.Location = new System.Drawing.Point(144, 40);
            this.dateTimePickerRandevuTarihiAyarla.Name = "dateTimePickerRandevuTarihiAyarla";
            this.dateTimePickerRandevuTarihiAyarla.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRandevuTarihiAyarla.TabIndex = 0;
            this.dateTimePickerRandevuTarihiAyarla.ValueChanged += new System.EventHandler(this.dateTimePickerRandevuTarihiAyarla_ValueChanged);
            // 
            // groupBoxHastaIslemleri
            // 
            this.groupBoxHastaIslemleri.Controls.Add(this.listBoxHastalar);
            this.groupBoxHastaIslemleri.Controls.Add(this.label1);
            this.groupBoxHastaIslemleri.Controls.Add(this.textBoxHastaTCArama);
            this.groupBoxHastaIslemleri.Location = new System.Drawing.Point(13, 16);
            this.groupBoxHastaIslemleri.Name = "groupBoxHastaIslemleri";
            this.groupBoxHastaIslemleri.Size = new System.Drawing.Size(350, 450);
            this.groupBoxHastaIslemleri.TabIndex = 0;
            this.groupBoxHastaIslemleri.TabStop = false;
            this.groupBoxHastaIslemleri.Text = "Hasta İşlemleri";
            // 
            // listBoxHastalar
            // 
            this.listBoxHastalar.FormattingEnabled = true;
            this.listBoxHastalar.ItemHeight = 16;
            this.listBoxHastalar.Location = new System.Drawing.Point(9, 123);
            this.listBoxHastalar.Name = "listBoxHastalar";
            this.listBoxHastalar.Size = new System.Drawing.Size(318, 308);
            this.listBoxHastalar.TabIndex = 2;
            this.listBoxHastalar.SelectedIndexChanged += new System.EventHandler(this.listBoxHastalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA T.C. NO :";
            // 
            // textBoxHastaTCArama
            // 
            this.textBoxHastaTCArama.Location = new System.Drawing.Point(145, 40);
            this.textBoxHastaTCArama.Name = "textBoxHastaTCArama";
            this.textBoxHastaTCArama.Size = new System.Drawing.Size(168, 22);
            this.textBoxHastaTCArama.TabIndex = 0;
            this.textBoxHastaTCArama.TextChanged += new System.EventHandler(this.textBoxHastaTCArama_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1136, 738);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 779);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormRandevu";
            this.Text = "Randevu Alma İşlemleri Formu";
            this.Load += new System.EventHandler(this.RandevuSistemi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRandevuIslem.ResumeLayout(false);
            this.groupBoxServis.ResumeLayout(false);
            this.groupBoxServis.PerformLayout();
            this.groupBoxRandevu.ResumeLayout(false);
            this.groupBoxRandevu.PerformLayout();
            this.groupBoxHastaIslemleri.ResumeLayout(false);
            this.groupBoxHastaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRandevuIslem;
        private System.Windows.Forms.GroupBox groupBoxServis;
        private System.Windows.Forms.GroupBox groupBoxRandevu;
        private System.Windows.Forms.GroupBox groupBoxHastaIslemleri;
        private System.Windows.Forms.ListBox listBoxHastalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHastaTCArama;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDoktorlar;
        private System.Windows.Forms.ComboBox comboBoxServisSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuTarihiAyarla;
    }
}
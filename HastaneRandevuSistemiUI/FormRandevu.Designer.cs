
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
            this.ucRandevuSaat1 = new HastaneRandevuSistemiUI.UCRandevuSaat();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerRandevuTarihiAyarla = new System.Windows.Forms.DateTimePicker();
            this.groupBoxHastaIslemleri = new System.Windows.Forms.GroupBox();
            this.listBoxHastalar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHastaTCArama = new System.Windows.Forms.TextBox();
            this.tabPageCiktiAl = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerCiktiAl = new System.Windows.Forms.DateTimePicker();
            this.btnCiktiAl = new System.Windows.Forms.Button();
            this.comboBoxCiktiAlDrSec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.listViewAlinanRandevular = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageRandevuIslem.SuspendLayout();
            this.groupBoxServis.SuspendLayout();
            this.groupBoxRandevu.SuspendLayout();
            this.groupBoxHastaIslemleri.SuspendLayout();
            this.tabPageCiktiAl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRandevuIslem);
            this.tabControl1.Controls.Add(this.tabPageCiktiAl);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 623);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPageRandevuIslem
            // 
            this.tabPageRandevuIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageRandevuIslem.Controls.Add(this.listViewAlinanRandevular);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxServis);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxRandevu);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxHastaIslemleri);
            this.tabPageRandevuIslem.Location = new System.Drawing.Point(4, 22);
            this.tabPageRandevuIslem.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRandevuIslem.Name = "tabPageRandevuIslem";
            this.tabPageRandevuIslem.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRandevuIslem.Size = new System.Drawing.Size(954, 597);
            this.tabPageRandevuIslem.TabIndex = 0;
            this.tabPageRandevuIslem.Text = "Randevu İşlemleri ";
            // 
            // groupBoxServis
            // 
            this.groupBoxServis.Controls.Add(this.label3);
            this.groupBoxServis.Controls.Add(this.listBoxDoktorlar);
            this.groupBoxServis.Controls.Add(this.comboBoxServisSec);
            this.groupBoxServis.Controls.Add(this.label2);
            this.groupBoxServis.Location = new System.Drawing.Point(288, 13);
            this.groupBoxServis.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxServis.Name = "groupBoxServis";
            this.groupBoxServis.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxServis.Size = new System.Drawing.Size(262, 366);
            this.groupBoxServis.TabIndex = 0;
            this.groupBoxServis.TabStop = false;
            this.groupBoxServis.Text = "Servis Ve Doktor Seçimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOKTOR SEÇ :";
            // 
            // listBoxDoktorlar
            // 
            this.listBoxDoktorlar.FormattingEnabled = true;
            this.listBoxDoktorlar.Location = new System.Drawing.Point(7, 100);
            this.listBoxDoktorlar.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDoktorlar.Name = "listBoxDoktorlar";
            this.listBoxDoktorlar.Size = new System.Drawing.Size(242, 251);
            this.listBoxDoktorlar.TabIndex = 3;
            this.listBoxDoktorlar.SelectedIndexChanged += new System.EventHandler(this.listBoxDoktorlar_SelectedIndexChanged);
            // 
            // comboBoxServisSec
            // 
            this.comboBoxServisSec.FormattingEnabled = true;
            this.comboBoxServisSec.Location = new System.Drawing.Point(106, 32);
            this.comboBoxServisSec.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxServisSec.Name = "comboBoxServisSec";
            this.comboBoxServisSec.Size = new System.Drawing.Size(127, 21);
            this.comboBoxServisSec.TabIndex = 2;
            this.comboBoxServisSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxServisSec_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVİS SEÇ :";
            // 
            // groupBoxRandevu
            // 
            this.groupBoxRandevu.Controls.Add(this.ucRandevuSaat1);
            this.groupBoxRandevu.Controls.Add(this.label4);
            this.groupBoxRandevu.Controls.Add(this.dateTimePickerRandevuTarihiAyarla);
            this.groupBoxRandevu.Location = new System.Drawing.Point(568, 13);
            this.groupBoxRandevu.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRandevu.Name = "groupBoxRandevu";
            this.groupBoxRandevu.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRandevu.Size = new System.Drawing.Size(344, 366);
            this.groupBoxRandevu.TabIndex = 0;
            this.groupBoxRandevu.TabStop = false;
            this.groupBoxRandevu.Text = "Randevu Tarih ve Saat İşlemleri";
            // 
            // ucRandevuSaat1
            // 
            this.ucRandevuSaat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ucRandevuSaat1.DisaridanGelenTarih = new System.DateTime(2022, 1, 2, 15, 19, 34, 447);
            this.ucRandevuSaat1.Doktorum = null;
            this.ucRandevuSaat1.Location = new System.Drawing.Point(27, 108);
            this.ucRandevuSaat1.Margin = new System.Windows.Forms.Padding(2);
            this.ucRandevuSaat1.Name = "ucRandevuSaat1";
            this.ucRandevuSaat1.RandevuAlmaAktifMi = false;
            this.ucRandevuSaat1.SecilenRandevuTarihi = new System.DateTime(((long)(0)));
            this.ucRandevuSaat1.Size = new System.Drawing.Size(303, 243);
            this.ucRandevuSaat1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "TARİH SEÇİNİZ :";
            // 
            // dateTimePickerRandevuTarihiAyarla
            // 
            this.dateTimePickerRandevuTarihiAyarla.Location = new System.Drawing.Point(108, 32);
            this.dateTimePickerRandevuTarihiAyarla.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerRandevuTarihiAyarla.Name = "dateTimePickerRandevuTarihiAyarla";
            this.dateTimePickerRandevuTarihiAyarla.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerRandevuTarihiAyarla.TabIndex = 0;
            this.dateTimePickerRandevuTarihiAyarla.ValueChanged += new System.EventHandler(this.dateTimePickerRandevuTarihiAyarla_ValueChanged);
            // 
            // groupBoxHastaIslemleri
            // 
            this.groupBoxHastaIslemleri.Controls.Add(this.listBoxHastalar);
            this.groupBoxHastaIslemleri.Controls.Add(this.label1);
            this.groupBoxHastaIslemleri.Controls.Add(this.textBoxHastaTCArama);
            this.groupBoxHastaIslemleri.Location = new System.Drawing.Point(10, 13);
            this.groupBoxHastaIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxHastaIslemleri.Name = "groupBoxHastaIslemleri";
            this.groupBoxHastaIslemleri.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxHastaIslemleri.Size = new System.Drawing.Size(262, 366);
            this.groupBoxHastaIslemleri.TabIndex = 0;
            this.groupBoxHastaIslemleri.TabStop = false;
            this.groupBoxHastaIslemleri.Text = "Hasta İşlemleri";
            // 
            // listBoxHastalar
            // 
            this.listBoxHastalar.FormattingEnabled = true;
            this.listBoxHastalar.Location = new System.Drawing.Point(7, 100);
            this.listBoxHastalar.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxHastalar.Name = "listBoxHastalar";
            this.listBoxHastalar.Size = new System.Drawing.Size(240, 251);
            this.listBoxHastalar.TabIndex = 2;
            this.listBoxHastalar.SelectedIndexChanged += new System.EventHandler(this.listBoxHastalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTA T.C. NO :";
            // 
            // textBoxHastaTCArama
            // 
            this.textBoxHastaTCArama.Location = new System.Drawing.Point(109, 32);
            this.textBoxHastaTCArama.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHastaTCArama.Name = "textBoxHastaTCArama";
            this.textBoxHastaTCArama.Size = new System.Drawing.Size(127, 20);
            this.textBoxHastaTCArama.TabIndex = 0;
            this.textBoxHastaTCArama.TextChanged += new System.EventHandler(this.textBoxHastaTCArama_TextChanged);
            // 
            // tabPageCiktiAl
            // 
            this.tabPageCiktiAl.Controls.Add(this.label6);
            this.tabPageCiktiAl.Controls.Add(this.dateTimePickerCiktiAl);
            this.tabPageCiktiAl.Controls.Add(this.btnCiktiAl);
            this.tabPageCiktiAl.Controls.Add(this.comboBoxCiktiAlDrSec);
            this.tabPageCiktiAl.Controls.Add(this.label5);
            this.tabPageCiktiAl.Location = new System.Drawing.Point(4, 22);
            this.tabPageCiktiAl.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCiktiAl.Name = "tabPageCiktiAl";
            this.tabPageCiktiAl.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCiktiAl.Size = new System.Drawing.Size(954, 597);
            this.tabPageCiktiAl.TabIndex = 1;
            this.tabPageCiktiAl.Text = "Çıktı Al";
            this.tabPageCiktiAl.UseVisualStyleBackColor = true;
            this.tabPageCiktiAl.Leave += new System.EventHandler(this.tabPageCiktiAl_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "TARİH SEÇİNİZ:";
            // 
            // dateTimePickerCiktiAl
            // 
            this.dateTimePickerCiktiAl.Location = new System.Drawing.Point(149, 83);
            this.dateTimePickerCiktiAl.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerCiktiAl.Name = "dateTimePickerCiktiAl";
            this.dateTimePickerCiktiAl.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerCiktiAl.TabIndex = 8;
            this.dateTimePickerCiktiAl.ValueChanged += new System.EventHandler(this.dateTimePickerCiktiAl_ValueChanged);
            // 
            // btnCiktiAl
            // 
            this.btnCiktiAl.Location = new System.Drawing.Point(52, 127);
            this.btnCiktiAl.Margin = new System.Windows.Forms.Padding(2);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.Size = new System.Drawing.Size(353, 39);
            this.btnCiktiAl.TabIndex = 7;
            this.btnCiktiAl.Text = "DOKTOR RANDEVU ÇIKTISI AL";
            this.btnCiktiAl.UseVisualStyleBackColor = true;
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // comboBoxCiktiAlDrSec
            // 
            this.comboBoxCiktiAlDrSec.FormattingEnabled = true;
            this.comboBoxCiktiAlDrSec.Location = new System.Drawing.Point(149, 35);
            this.comboBoxCiktiAlDrSec.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCiktiAlDrSec.Name = "comboBoxCiktiAlDrSec";
            this.comboBoxCiktiAlDrSec.Size = new System.Drawing.Size(256, 21);
            this.comboBoxCiktiAlDrSec.TabIndex = 6;
            this.comboBoxCiktiAlDrSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiktiAlDrSec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DOKTOR SEÇİNİZ:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // listViewAlinanRandevular
            // 
            this.listViewAlinanRandevular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAlinanRandevular.HideSelection = false;
            this.listViewAlinanRandevular.Location = new System.Drawing.Point(17, 384);
            this.listViewAlinanRandevular.Name = "listViewAlinanRandevular";
            this.listViewAlinanRandevular.Size = new System.Drawing.Size(520, 127);
            this.listViewAlinanRandevular.TabIndex = 1;
            this.listViewAlinanRandevular.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Doktor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Servis";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Randevu Tarihi";
            // 
            // FormRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 609);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabPageCiktiAl.ResumeLayout(false);
            this.tabPageCiktiAl.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageCiktiAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDoktorlar;
        private System.Windows.Forms.ComboBox comboBoxServisSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuTarihiAyarla;
        private UCRandevuSaat ucRandevuSaat1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerCiktiAl;
        private System.Windows.Forms.Button btnCiktiAl;
        private System.Windows.Forms.ComboBox comboBoxCiktiAlDrSec;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListView listViewAlinanRandevular;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
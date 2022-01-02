
namespace HastaneRandevuSistemiUI
{
    partial class UCRandevuSaat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxSaatler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelRandevuButonlar = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelRandevuButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSaatler
            // 
            this.comboBoxSaatler.FormattingEnabled = true;
            this.comboBoxSaatler.Location = new System.Drawing.Point(14, 32);
            this.comboBoxSaatler.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSaatler.Name = "comboBoxSaatler";
            this.comboBoxSaatler.Size = new System.Drawing.Size(263, 21);
            this.comboBoxSaatler.TabIndex = 1;
            this.comboBoxSaatler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaatler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saat Seçiniz :";
            // 
            // tableLayoutPanelRandevuButonlar
            // 
            this.tableLayoutPanelRandevuButonlar.ColumnCount = 2;
            this.tableLayoutPanelRandevuButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.button15, 1, 0);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.button30, 0, 1);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.button45, 1, 1);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.button00, 0, 0);
            this.tableLayoutPanelRandevuButonlar.Location = new System.Drawing.Point(14, 79);
            this.tableLayoutPanelRandevuButonlar.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelRandevuButonlar.Name = "tableLayoutPanelRandevuButonlar";
            this.tableLayoutPanelRandevuButonlar.RowCount = 2;
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.Size = new System.Drawing.Size(262, 156);
            this.tableLayoutPanelRandevuButonlar.TabIndex = 3;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(133, 2);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(127, 73);
            this.button15.TabIndex = 1;
            this.button15.Text = "button2";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(2, 80);
            this.button30.Margin = new System.Windows.Forms.Padding(2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(126, 73);
            this.button30.TabIndex = 2;
            this.button30.Text = "button3";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(133, 80);
            this.button45.Margin = new System.Windows.Forms.Padding(2);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(127, 73);
            this.button45.TabIndex = 3;
            this.button45.Text = "button4";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(2, 2);
            this.button00.Margin = new System.Windows.Forms.Padding(2);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(126, 73);
            this.button00.TabIndex = 0;
            this.button00.Text = "button1";
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.button00_Click);
            // 
            // UCRandevuSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.tableLayoutPanelRandevuButonlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSaatler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCRandevuSaat";
            this.Size = new System.Drawing.Size(290, 254);
            this.Load += new System.EventHandler(this.UCRandevuSaat_Load);
            this.Click += new System.EventHandler(this.UCRandevuSaat_Click);
            this.tableLayoutPanelRandevuButonlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSaatler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRandevuButonlar;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Timer timer1;
    }
}

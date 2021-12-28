
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
            this.comboBoxSaatler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelRandevuButonlar = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.tableLayoutPanelRandevuButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSaatler
            // 
            this.comboBoxSaatler.FormattingEnabled = true;
            this.comboBoxSaatler.Location = new System.Drawing.Point(18, 39);
            this.comboBoxSaatler.Name = "comboBoxSaatler";
            this.comboBoxSaatler.Size = new System.Drawing.Size(349, 24);
            this.comboBoxSaatler.TabIndex = 1;
            this.comboBoxSaatler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaatler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
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
            this.tableLayoutPanelRandevuButonlar.Location = new System.Drawing.Point(18, 97);
            this.tableLayoutPanelRandevuButonlar.Name = "tableLayoutPanelRandevuButonlar";
            this.tableLayoutPanelRandevuButonlar.RowCount = 2;
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.Size = new System.Drawing.Size(349, 192);
            this.tableLayoutPanelRandevuButonlar.TabIndex = 3;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(177, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(169, 90);
            this.button15.TabIndex = 1;
            this.button15.Text = "button2";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(3, 99);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(168, 90);
            this.button30.TabIndex = 2;
            this.button30.Text = "button3";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(177, 99);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(128, 65);
            this.button45.TabIndex = 3;
            this.button45.Text = "button4";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(3, 3);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(168, 90);
            this.button00.TabIndex = 0;
            this.button00.Text = "button1";
            this.button00.UseVisualStyleBackColor = true;
            // 
            // UCRandevuSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.tableLayoutPanelRandevuButonlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSaatler);
            this.Name = "UCRandevuSaat";
            this.Size = new System.Drawing.Size(387, 313);
            this.Load += new System.EventHandler(this.UCRandevuSaat_Load);
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
    }
}

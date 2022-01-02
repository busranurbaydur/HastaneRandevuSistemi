
namespace HastaneRandevuSistemiUI
{
    partial class FormHastaCagir
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
            this.components = new System.ComponentModel.Container();
            this.labelHasta = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHasta.Location = new System.Drawing.Point(105, 122);
            this.labelHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(117, 63);
            this.labelHasta.TabIndex = 9;
            this.labelHasta.Text = "-----";
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(501, 51);
            this.btnDurdur.Margin = new System.Windows.Forms.Padding(2);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(73, 36);
            this.btnDurdur.TabIndex = 8;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(373, 51);
            this.btnBasla.Margin = new System.Windows.Forms.Padding(2);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(73, 36);
            this.btnBasla.TabIndex = 7;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOKTOR SEÇİNİZ:";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(38, 66);
            this.comboBoxDoktor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(269, 21);
            this.comboBoxDoktor.TabIndex = 5;
            // 
            // FormHastaCagir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDoktor);
            this.Name = "FormHastaCagir";
            this.Text = "FormHastaCagir";
            this.Load += new System.EventHandler(this.FormHastaCagir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.Timer timer1;
    }
}
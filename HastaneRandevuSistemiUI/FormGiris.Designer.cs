
namespace HastaneRandevuSistemiUI
{
    partial class FormGiris
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
            this.buttonDoktorIslemleri = new System.Windows.Forms.Button();
            this.buttonHastaIslemleri = new System.Windows.Forms.Button();
            this.buttonRandevuIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoktorIslemleri
            // 
            this.buttonDoktorIslemleri.Location = new System.Drawing.Point(131, 33);
            this.buttonDoktorIslemleri.Name = "buttonDoktorIslemleri";
            this.buttonDoktorIslemleri.Size = new System.Drawing.Size(256, 98);
            this.buttonDoktorIslemleri.TabIndex = 0;
            this.buttonDoktorIslemleri.Text = "Doktor İşlemleri";
            this.buttonDoktorIslemleri.UseVisualStyleBackColor = true;
            this.buttonDoktorIslemleri.Click += new System.EventHandler(this.buttonDoktorIslemleri_Click);
            // 
            // buttonHastaIslemleri
            // 
            this.buttonHastaIslemleri.Location = new System.Drawing.Point(131, 157);
            this.buttonHastaIslemleri.Name = "buttonHastaIslemleri";
            this.buttonHastaIslemleri.Size = new System.Drawing.Size(256, 99);
            this.buttonHastaIslemleri.TabIndex = 1;
            this.buttonHastaIslemleri.Text = "Hasta İşlemleri";
            this.buttonHastaIslemleri.UseVisualStyleBackColor = true;
            this.buttonHastaIslemleri.Click += new System.EventHandler(this.buttonHastaIslemleri_Click);
            // 
            // buttonRandevuIslemleri
            // 
            this.buttonRandevuIslemleri.Location = new System.Drawing.Point(131, 280);
            this.buttonRandevuIslemleri.Name = "buttonRandevuIslemleri";
            this.buttonRandevuIslemleri.Size = new System.Drawing.Size(256, 106);
            this.buttonRandevuIslemleri.TabIndex = 2;
            this.buttonRandevuIslemleri.Text = "Randevu İşlemleri";
            this.buttonRandevuIslemleri.UseVisualStyleBackColor = true;
            this.buttonRandevuIslemleri.Click += new System.EventHandler(this.buttonRandevuIslemleri_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.buttonRandevuIslemleri);
            this.Controls.Add(this.buttonHastaIslemleri);
            this.Controls.Add(this.buttonDoktorIslemleri);
            this.Name = "FormGiris";
            this.Text = "Busra Hastanesine Hoşgeldiniz..";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoktorIslemleri;
        private System.Windows.Forms.Button buttonHastaIslemleri;
        private System.Windows.Forms.Button buttonRandevuIslemleri;
    }
}
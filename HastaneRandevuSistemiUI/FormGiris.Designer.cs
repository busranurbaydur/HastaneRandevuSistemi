
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
            this.buttonHastaCagir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoktorIslemleri
            // 
            this.buttonDoktorIslemleri.Location = new System.Drawing.Point(98, 27);
            this.buttonDoktorIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDoktorIslemleri.Name = "buttonDoktorIslemleri";
            this.buttonDoktorIslemleri.Size = new System.Drawing.Size(192, 80);
            this.buttonDoktorIslemleri.TabIndex = 0;
            this.buttonDoktorIslemleri.Text = "Doktor İşlemleri";
            this.buttonDoktorIslemleri.UseVisualStyleBackColor = true;
            this.buttonDoktorIslemleri.Click += new System.EventHandler(this.buttonDoktorIslemleri_Click);
            // 
            // buttonHastaIslemleri
            // 
            this.buttonHastaIslemleri.Location = new System.Drawing.Point(98, 128);
            this.buttonHastaIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHastaIslemleri.Name = "buttonHastaIslemleri";
            this.buttonHastaIslemleri.Size = new System.Drawing.Size(192, 80);
            this.buttonHastaIslemleri.TabIndex = 1;
            this.buttonHastaIslemleri.Text = "Hasta İşlemleri";
            this.buttonHastaIslemleri.UseVisualStyleBackColor = true;
            this.buttonHastaIslemleri.Click += new System.EventHandler(this.buttonHastaIslemleri_Click);
            // 
            // buttonRandevuIslemleri
            // 
            this.buttonRandevuIslemleri.Location = new System.Drawing.Point(98, 228);
            this.buttonRandevuIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandevuIslemleri.Name = "buttonRandevuIslemleri";
            this.buttonRandevuIslemleri.Size = new System.Drawing.Size(192, 86);
            this.buttonRandevuIslemleri.TabIndex = 2;
            this.buttonRandevuIslemleri.Text = "Randevu İşlemleri";
            this.buttonRandevuIslemleri.UseVisualStyleBackColor = true;
            this.buttonRandevuIslemleri.Click += new System.EventHandler(this.buttonRandevuIslemleri_Click);
            // 
            // buttonHastaCagir
            // 
            this.buttonHastaCagir.Location = new System.Drawing.Point(98, 340);
            this.buttonHastaCagir.Name = "buttonHastaCagir";
            this.buttonHastaCagir.Size = new System.Drawing.Size(192, 77);
            this.buttonHastaCagir.TabIndex = 3;
            this.buttonHastaCagir.Text = "Hasta Çağır";
            this.buttonHastaCagir.UseVisualStyleBackColor = true;
            this.buttonHastaCagir.Click += new System.EventHandler(this.buttonHastaCagir_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.buttonHastaCagir);
            this.Controls.Add(this.buttonRandevuIslemleri);
            this.Controls.Add(this.buttonHastaIslemleri);
            this.Controls.Add(this.buttonDoktorIslemleri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGiris";
            this.Text = "Busra Hastanesine Hoşgeldiniz..";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoktorIslemleri;
        private System.Windows.Forms.Button buttonHastaIslemleri;
        private System.Windows.Forms.Button buttonRandevuIslemleri;
        private System.Windows.Forms.Button buttonHastaCagir;
    }
}
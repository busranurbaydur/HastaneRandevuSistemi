
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDoktorIslemleri
            // 
            this.buttonDoktorIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonDoktorIslemleri.Location = new System.Drawing.Point(48, 152);
            this.buttonDoktorIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDoktorIslemleri.Name = "buttonDoktorIslemleri";
            this.buttonDoktorIslemleri.Size = new System.Drawing.Size(150, 110);
            this.buttonDoktorIslemleri.TabIndex = 0;
            this.buttonDoktorIslemleri.Text = "Doktor İşlemleri";
            this.buttonDoktorIslemleri.UseVisualStyleBackColor = false;
            this.buttonDoktorIslemleri.Click += new System.EventHandler(this.buttonDoktorIslemleri_Click);
            // 
            // buttonHastaIslemleri
            // 
            this.buttonHastaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonHastaIslemleri.Location = new System.Drawing.Point(278, 152);
            this.buttonHastaIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHastaIslemleri.Name = "buttonHastaIslemleri";
            this.buttonHastaIslemleri.Size = new System.Drawing.Size(150, 110);
            this.buttonHastaIslemleri.TabIndex = 1;
            this.buttonHastaIslemleri.Text = "Hasta İşlemleri";
            this.buttonHastaIslemleri.UseVisualStyleBackColor = false;
            this.buttonHastaIslemleri.Click += new System.EventHandler(this.buttonHastaIslemleri_Click);
            // 
            // buttonRandevuIslemleri
            // 
            this.buttonRandevuIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRandevuIslemleri.Location = new System.Drawing.Point(48, 308);
            this.buttonRandevuIslemleri.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandevuIslemleri.Name = "buttonRandevuIslemleri";
            this.buttonRandevuIslemleri.Size = new System.Drawing.Size(150, 110);
            this.buttonRandevuIslemleri.TabIndex = 2;
            this.buttonRandevuIslemleri.Text = "Randevu İşlemleri";
            this.buttonRandevuIslemleri.UseVisualStyleBackColor = false;
            this.buttonRandevuIslemleri.Click += new System.EventHandler(this.buttonRandevuIslemleri_Click);
            // 
            // buttonHastaCagir
            // 
            this.buttonHastaCagir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonHastaCagir.Location = new System.Drawing.Point(278, 308);
            this.buttonHastaCagir.Name = "buttonHastaCagir";
            this.buttonHastaCagir.Size = new System.Drawing.Size(150, 110);
            this.buttonHastaCagir.TabIndex = 3;
            this.buttonHastaCagir.Text = "Hasta Çağır";
            this.buttonHastaCagir.UseVisualStyleBackColor = false;
            this.buttonHastaCagir.Click += new System.EventHandler(this.buttonHastaCagir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "BÜŞRA HASTANESİ";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHastaCagir);
            this.Controls.Add(this.buttonRandevuIslemleri);
            this.Controls.Add(this.buttonHastaIslemleri);
            this.Controls.Add(this.buttonDoktorIslemleri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGiris";
            this.Text = "Büşra Hastanesine Hoşgeldiniz..";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoktorIslemleri;
        private System.Windows.Forms.Button buttonHastaIslemleri;
        private System.Windows.Forms.Button buttonRandevuIslemleri;
        private System.Windows.Forms.Button buttonHastaCagir;
        private System.Windows.Forms.Label label1;
    }
}
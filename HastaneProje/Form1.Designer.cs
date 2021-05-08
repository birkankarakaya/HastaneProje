namespace HastaneProje
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.DoktorGiris = new System.Windows.Forms.Button();
            this.DanismaGiris = new System.Windows.Forms.Button();
            this.HastaGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoktorGiris
            // 
            this.DoktorGiris.BackColor = System.Drawing.SystemColors.Control;
            this.DoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoktorGiris.BackgroundImage")));
            this.DoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DoktorGiris.Location = new System.Drawing.Point(470, 278);
            this.DoktorGiris.Margin = new System.Windows.Forms.Padding(4);
            this.DoktorGiris.Name = "DoktorGiris";
            this.DoktorGiris.Size = new System.Drawing.Size(90, 90);
            this.DoktorGiris.TabIndex = 0;
            this.DoktorGiris.UseVisualStyleBackColor = false;
            this.DoktorGiris.Click += new System.EventHandler(this.DoktorGiris_Click);
            // 
            // DanismaGiris
            // 
            this.DanismaGiris.BackColor = System.Drawing.SystemColors.Control;
            this.DanismaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DanismaGiris.BackgroundImage")));
            this.DanismaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DanismaGiris.Location = new System.Drawing.Point(650, 278);
            this.DanismaGiris.Margin = new System.Windows.Forms.Padding(4);
            this.DanismaGiris.Name = "DanismaGiris";
            this.DanismaGiris.Size = new System.Drawing.Size(90, 90);
            this.DanismaGiris.TabIndex = 1;
            this.DanismaGiris.UseVisualStyleBackColor = false;
            this.DanismaGiris.Click += new System.EventHandler(this.DanismaGiris_Click);
            // 
            // HastaGiris
            // 
            this.HastaGiris.BackColor = System.Drawing.SystemColors.Control;
            this.HastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HastaGiris.BackgroundImage")));
            this.HastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HastaGiris.Location = new System.Drawing.Point(827, 278);
            this.HastaGiris.Margin = new System.Windows.Forms.Padding(4);
            this.HastaGiris.Name = "HastaGiris";
            this.HastaGiris.Size = new System.Drawing.Size(90, 90);
            this.HastaGiris.TabIndex = 2;
            this.HastaGiris.UseVisualStyleBackColor = false;
            this.HastaGiris.Click += new System.EventHandler(this.HastaGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doktor Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danışma Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proje Deneme Hastanesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yönetim Paneli";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastaGiris);
            this.Controls.Add(this.DanismaGiris);
            this.Controls.Add(this.DoktorGiris);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Yönetim Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoktorGiris;
        private System.Windows.Forms.Button DanismaGiris;
        private System.Windows.Forms.Button HastaGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


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
            System.Windows.Forms.Button DoktorGiris;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            System.Windows.Forms.Button DanismaGiris;
            System.Windows.Forms.Button HastaGiris;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            DoktorGiris = new System.Windows.Forms.Button();
            DanismaGiris = new System.Windows.Forms.Button();
            HastaGiris = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoktorGiris
            // 
            DoktorGiris.BackColor = System.Drawing.SystemColors.Control;
            DoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoktorGiris.BackgroundImage")));
            DoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            DoktorGiris.Location = new System.Drawing.Point(498, 324);
            DoktorGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DoktorGiris.Name = "DoktorGiris";
            DoktorGiris.Size = new System.Drawing.Size(72, 81);
            DoktorGiris.TabIndex = 0;
            DoktorGiris.UseVisualStyleBackColor = false;
            DoktorGiris.Click += new System.EventHandler(this.DoktorGiris_Click);
            // 
            // DanismaGiris
            // 
            DanismaGiris.BackColor = System.Drawing.SystemColors.Control;
            DanismaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DanismaGiris.BackgroundImage")));
            DanismaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            DanismaGiris.Location = new System.Drawing.Point(642, 324);
            DanismaGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DanismaGiris.Name = "DanismaGiris";
            DanismaGiris.Size = new System.Drawing.Size(72, 81);
            DanismaGiris.TabIndex = 1;
            DanismaGiris.UseVisualStyleBackColor = false;
            DanismaGiris.Click += new System.EventHandler(this.DanismaGiris_Click);
            // 
            // HastaGiris
            // 
            HastaGiris.BackColor = System.Drawing.SystemColors.Control;
            HastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HastaGiris.BackgroundImage")));
            HastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            HastaGiris.Location = new System.Drawing.Point(784, 324);
            HastaGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            HastaGiris.Name = "HastaGiris";
            HastaGiris.Size = new System.Drawing.Size(72, 81);
            HastaGiris.TabIndex = 2;
            HastaGiris.UseVisualStyleBackColor = false;
            HastaGiris.Click += new System.EventHandler(this.HastaGiris_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(488, 409);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 18);
            label1.TabIndex = 3;
            label1.Text = "Doktor Girişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(628, 409);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 18);
            label2.TabIndex = 4;
            label2.Text = "Danışma Girişi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(780, 409);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 18);
            label3.TabIndex = 5;
            label3.Text = "Hasta Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 63);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proje Deneme Hastanesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yönetim Paneli";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(HastaGiris);
            this.Controls.Add(DanismaGiris);
            this.Controls.Add(DoktorGiris);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


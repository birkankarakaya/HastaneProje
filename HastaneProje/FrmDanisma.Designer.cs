namespace HastaneProje
{
    partial class FrmDanismaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanismaGiris));
            this.HSifreReset = new System.Windows.Forms.LinkLabel();
            this.btnDoktorGirisYap = new System.Windows.Forms.Button();
            this.mskDanismaTc = new System.Windows.Forms.MaskedTextBox();
            this.txtDanismaSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HSifreReset
            // 
            this.HSifreReset.AutoSize = true;
            this.HSifreReset.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HSifreReset.Location = new System.Drawing.Point(243, 266);
            this.HSifreReset.Name = "HSifreReset";
            this.HSifreReset.Size = new System.Drawing.Size(100, 15);
            this.HSifreReset.TabIndex = 35;
            this.HSifreReset.TabStop = true;
            this.HSifreReset.Text = "Şifremi Unuttum";
            // 
            // btnDoktorGirisYap
            // 
            this.btnDoktorGirisYap.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGirisYap.Location = new System.Drawing.Point(243, 234);
            this.btnDoktorGirisYap.Name = "btnDoktorGirisYap";
            this.btnDoktorGirisYap.Size = new System.Drawing.Size(100, 29);
            this.btnDoktorGirisYap.TabIndex = 34;
            this.btnDoktorGirisYap.Text = "Giriş Yap";
            this.btnDoktorGirisYap.UseVisualStyleBackColor = true;
            this.btnDoktorGirisYap.Click += new System.EventHandler(this.btnDoktorGirisYap_Click);
            // 
            // mskDanismaTc
            // 
            this.mskDanismaTc.Location = new System.Drawing.Point(243, 154);
            this.mskDanismaTc.Mask = "00000000000";
            this.mskDanismaTc.Name = "mskDanismaTc";
            this.mskDanismaTc.Size = new System.Drawing.Size(100, 26);
            this.mskDanismaTc.TabIndex = 1;
            this.mskDanismaTc.ValidatingType = typeof(int);
            // 
            // txtDanismaSifre
            // 
            this.txtDanismaSifre.Location = new System.Drawing.Point(243, 184);
            this.txtDanismaSifre.Name = "txtDanismaSifre";
            this.txtDanismaSifre.Size = new System.Drawing.Size(100, 26);
            this.txtDanismaSifre.TabIndex = 2;
            this.txtDanismaSifre.TextChanged += new System.EventHandler(this.txtDoktorSifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(226, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danışma Girişi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Yönetim Paneli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Proje Deneme Hastanesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDanismaGiris
            // 
            this.AcceptButton = this.btnDoktorGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(619, 372);
            this.Controls.Add(this.HSifreReset);
            this.Controls.Add(this.btnDoktorGirisYap);
            this.Controls.Add(this.mskDanismaTc);
            this.Controls.Add(this.txtDanismaSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDanismaGiris";
            this.Text = "FrmDanisma";
            this.Load += new System.EventHandler(this.FrmDanismaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel HSifreReset;
        private System.Windows.Forms.Button btnDoktorGirisYap;
        private System.Windows.Forms.MaskedTextBox mskDanismaTc;
        private System.Windows.Forms.TextBox txtDanismaSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
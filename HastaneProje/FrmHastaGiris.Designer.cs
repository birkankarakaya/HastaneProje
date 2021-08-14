namespace HastaneProje
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.btnHastaGirisYap = new System.Windows.Forms.Button();
            this.HSifreReset = new System.Windows.Forms.LinkLabel();
            this.HYeniUye = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yönetim Paneli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proje Deneme Hastanesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 63);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(677, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hasta Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Şifre:";
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(692, 360);
            this.txtHastaSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(106, 23);
            this.txtHastaSifre.TabIndex = 2;
            this.txtHastaSifre.TextChanged += new System.EventHandler(this.txtHastaSifre_TextChanged);
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(692, 333);
            this.mskTc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(106, 23);
            this.mskTc.TabIndex = 1;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // btnHastaGirisYap
            // 
            this.btnHastaGirisYap.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGirisYap.Location = new System.Drawing.Point(692, 405);
            this.btnHastaGirisYap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHastaGirisYap.Name = "btnHastaGirisYap";
            this.btnHastaGirisYap.Size = new System.Drawing.Size(80, 26);
            this.btnHastaGirisYap.TabIndex = 4;
            this.btnHastaGirisYap.Text = "Giriş Yap";
            this.btnHastaGirisYap.UseVisualStyleBackColor = true;
            this.btnHastaGirisYap.Click += new System.EventHandler(this.btnHastaGirisYap_Click);
            // 
            // HSifreReset
            // 
            this.HSifreReset.AutoSize = true;
            this.HSifreReset.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HSifreReset.Location = new System.Drawing.Point(802, 363);
            this.HSifreReset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HSifreReset.Name = "HSifreReset";
            this.HSifreReset.Size = new System.Drawing.Size(100, 15);
            this.HSifreReset.TabIndex = 3;
            this.HSifreReset.TabStop = true;
            this.HSifreReset.Text = "Şifremi Unuttum";
            this.HSifreReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HSifreReset_LinkClicked);
            // 
            // HYeniUye
            // 
            this.HYeniUye.AutoSize = true;
            this.HYeniUye.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HYeniUye.Location = new System.Drawing.Point(688, 433);
            this.HYeniUye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HYeniUye.Name = "HYeniUye";
            this.HYeniUye.Size = new System.Drawing.Size(110, 15);
            this.HYeniUye.TabIndex = 5;
            this.HYeniUye.TabStop = true;
            this.HYeniUye.Text = "Üye değil misiniz?";
            this.HYeniUye.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HYeniUye_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.HYeniUye);
            this.Controls.Add(this.HSifreReset);
            this.Controls.Add(this.btnHastaGirisYap);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHastaGiris";
            this.Text = "FrmHastaGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Button btnHastaGirisYap;
        private System.Windows.Forms.LinkLabel HSifreReset;
        private System.Windows.Forms.LinkLabel HYeniUye;
    }
}
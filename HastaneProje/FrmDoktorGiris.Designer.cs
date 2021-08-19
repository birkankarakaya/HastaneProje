namespace HastaneProje
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HSifreReset = new System.Windows.Forms.LinkLabel();
            this.btnDoktorGirisYap = new System.Windows.Forms.Button();
            this.mskDoktorTc = new System.Windows.Forms.MaskedTextBox();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yönetim Paneli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 16);
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
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 63);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // HSifreReset
            // 
            this.HSifreReset.AutoSize = true;
            this.HSifreReset.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HSifreReset.Location = new System.Drawing.Point(194, 239);
            this.HSifreReset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HSifreReset.Name = "HSifreReset";
            this.HSifreReset.Size = new System.Drawing.Size(100, 15);
            this.HSifreReset.TabIndex = 25;
            this.HSifreReset.TabStop = true;
            this.HSifreReset.Text = "Şifremi Unuttum";
            this.HSifreReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HSifreReset_LinkClicked);
            // 
            // btnDoktorGirisYap
            // 
            this.btnDoktorGirisYap.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGirisYap.Location = new System.Drawing.Point(194, 211);
            this.btnDoktorGirisYap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDoktorGirisYap.Name = "btnDoktorGirisYap";
            this.btnDoktorGirisYap.Size = new System.Drawing.Size(80, 26);
            this.btnDoktorGirisYap.TabIndex = 24;
            this.btnDoktorGirisYap.Text = "Giriş Yap";
            this.btnDoktorGirisYap.UseVisualStyleBackColor = true;
            this.btnDoktorGirisYap.Click += new System.EventHandler(this.btnDoktorGirisYap_Click);
            // 
            // mskDoktorTc
            // 
            this.mskDoktorTc.Location = new System.Drawing.Point(194, 139);
            this.mskDoktorTc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mskDoktorTc.Mask = "00000000000";
            this.mskDoktorTc.Name = "mskDoktorTc";
            this.mskDoktorTc.Size = new System.Drawing.Size(100, 23);
            this.mskDoktorTc.TabIndex = 1;
            this.mskDoktorTc.ValidatingType = typeof(int);
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(194, 166);
            this.txtDoktorSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Size = new System.Drawing.Size(100, 23);
            this.txtDoktorSifre.TabIndex = 2;
            this.txtDoktorSifre.TextChanged += new System.EventHandler(this.txtDoktorSifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(181, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Doktor Girişi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.btnDoktorGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 335);
            this.Controls.Add(this.HSifreReset);
            this.Controls.Add(this.btnDoktorGirisYap);
            this.Controls.Add(this.mskDoktorTc);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoktorGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel HSifreReset;
        private System.Windows.Forms.Button btnDoktorGirisYap;
        private System.Windows.Forms.MaskedTextBox mskDoktorTc;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
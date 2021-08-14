namespace HastaneProje
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchSikayet = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuBransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblRandevuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSet = new HastaneProje.HastaneProjeDataSet();
            this.tblDoktorlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblRandevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DoktorlarTableAdapter = new HastaneProje.HastaneProjeDataSetTableAdapters.Tbl_DoktorlarTableAdapter();
            this.tbl_RandevuTableAdapter = new HastaneProje.HastaneProjeDataSetTableAdapters.Tbl_RandevuTableAdapter();
            this.tableAdapterManager = new HastaneProje.HastaneProjeDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(283, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.Location = new System.Drawing.Point(135, 57);
            this.LblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(35, 18);
            this.LblAdSoyad.TabIndex = 8;
            this.LblAdSoyad.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ad Soyad:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTC.Location = new System.Drawing.Point(135, 32);
            this.LblTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(96, 18);
            this.LblTC.TabIndex = 6;
            this.LblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchSikayet);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(283, 352);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchSikayet
            // 
            this.rchSikayet.Location = new System.Drawing.Point(9, 56);
            this.rchSikayet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rchSikayet.Name = "rchSikayet";
            this.rchSikayet.Size = new System.Drawing.Size(273, 291);
            this.rchSikayet.TabIndex = 8;
            this.rchSikayet.Text = "";
            this.rchSikayet.TextChanged += new System.EventHandler(this.rchSikayet_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta Şikayeti:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(288, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(778, 623);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.randevuIDDataGridViewTextBoxColumn,
            this.hastaTCDataGridViewTextBoxColumn,
            this.hastaAdDataGridViewTextBoxColumn,
            this.hastaSoyadDataGridViewTextBoxColumn,
            this.hastaTelefonDataGridViewTextBoxColumn,
            this.randevuBransDataGridViewTextBoxColumn,
            this.doktorTCDataGridViewTextBoxColumn,
            this.randevuTarihDataGridViewTextBoxColumn,
            this.randevuSaatDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.randevuDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblRandevuBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 601);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // randevuIDDataGridViewTextBoxColumn
            // 
            this.randevuIDDataGridViewTextBoxColumn.DataPropertyName = "RandevuID";
            this.randevuIDDataGridViewTextBoxColumn.HeaderText = "RandevuID";
            this.randevuIDDataGridViewTextBoxColumn.Name = "randevuIDDataGridViewTextBoxColumn";
            this.randevuIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaTCDataGridViewTextBoxColumn
            // 
            this.hastaTCDataGridViewTextBoxColumn.DataPropertyName = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.HeaderText = "HastaTC";
            this.hastaTCDataGridViewTextBoxColumn.Name = "hastaTCDataGridViewTextBoxColumn";
            // 
            // hastaAdDataGridViewTextBoxColumn
            // 
            this.hastaAdDataGridViewTextBoxColumn.DataPropertyName = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.HeaderText = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.Name = "hastaAdDataGridViewTextBoxColumn";
            // 
            // hastaSoyadDataGridViewTextBoxColumn
            // 
            this.hastaSoyadDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.HeaderText = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.Name = "hastaSoyadDataGridViewTextBoxColumn";
            // 
            // hastaTelefonDataGridViewTextBoxColumn
            // 
            this.hastaTelefonDataGridViewTextBoxColumn.DataPropertyName = "HastaTelefon";
            this.hastaTelefonDataGridViewTextBoxColumn.HeaderText = "HastaTelefon";
            this.hastaTelefonDataGridViewTextBoxColumn.Name = "hastaTelefonDataGridViewTextBoxColumn";
            // 
            // randevuBransDataGridViewTextBoxColumn
            // 
            this.randevuBransDataGridViewTextBoxColumn.DataPropertyName = "RandevuBrans";
            this.randevuBransDataGridViewTextBoxColumn.HeaderText = "RandevuBrans";
            this.randevuBransDataGridViewTextBoxColumn.Name = "randevuBransDataGridViewTextBoxColumn";
            // 
            // doktorTCDataGridViewTextBoxColumn
            // 
            this.doktorTCDataGridViewTextBoxColumn.DataPropertyName = "DoktorTC";
            this.doktorTCDataGridViewTextBoxColumn.HeaderText = "DoktorTC";
            this.doktorTCDataGridViewTextBoxColumn.Name = "doktorTCDataGridViewTextBoxColumn";
            // 
            // randevuTarihDataGridViewTextBoxColumn
            // 
            this.randevuTarihDataGridViewTextBoxColumn.DataPropertyName = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.HeaderText = "RandevuTarih";
            this.randevuTarihDataGridViewTextBoxColumn.Name = "randevuTarihDataGridViewTextBoxColumn";
            // 
            // randevuSaatDataGridViewTextBoxColumn
            // 
            this.randevuSaatDataGridViewTextBoxColumn.DataPropertyName = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.HeaderText = "RandevuSaat";
            this.randevuSaatDataGridViewTextBoxColumn.Name = "randevuSaatDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "Aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // randevuDurumDataGridViewCheckBoxColumn
            // 
            this.randevuDurumDataGridViewCheckBoxColumn.DataPropertyName = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.HeaderText = "RandevuDurum";
            this.randevuDurumDataGridViewCheckBoxColumn.Name = "randevuDurumDataGridViewCheckBoxColumn";
            // 
            // tblRandevuBindingSource1
            // 
            this.tblRandevuBindingSource1.DataMember = "Tbl_Randevu";
            this.tblRandevuBindingSource1.DataSource = this.hastaneProjeDataSetBindingSource1;
            // 
            // hastaneProjeDataSetBindingSource1
            // 
            this.hastaneProjeDataSetBindingSource1.DataSource = this.hastaneProjeDataSet;
            this.hastaneProjeDataSetBindingSource1.Position = 0;
            // 
            // hastaneProjeDataSet
            // 
            this.hastaneProjeDataSet.DataSetName = "HastaneProjeDataSet";
            this.hastaneProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDoktorlarBindingSource
            // 
            this.tblDoktorlarBindingSource.DataMember = "Tbl_Doktorlar";
            this.tblDoktorlarBindingSource.DataSource = this.hastaneProjeDataSetBindingSource;
            // 
            // hastaneProjeDataSetBindingSource
            // 
            this.hastaneProjeDataSetBindingSource.DataSource = this.hastaneProjeDataSet;
            this.hastaneProjeDataSetBindingSource.Position = 0;
            // 
            // tblRandevuBindingSource
            // 
            this.tblRandevuBindingSource.DataMember = "Tbl_Randevu";
            this.tblRandevuBindingSource.DataSource = this.hastaneProjeDataSetBindingSource;
            // 
            // tbl_DoktorlarTableAdapter
            // 
            this.tbl_DoktorlarTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_RandevuTableAdapter
            // 
            this.tbl_RandevuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_BransTableAdapter = null;
            this.tableAdapterManager.Tbl_DanismaTableAdapter = null;
            this.tableAdapterManager.Tbl_DoktorlarTableAdapter = null;
            this.tableAdapterManager.Tbl_HastalarTableAdapter = null;
            this.tableAdapterManager.Tbl_RandevuTableAdapter = this.tbl_RandevuTableAdapter;
            this.tableAdapterManager.UpdateOrder = HastaneProje.HastaneProjeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1066, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoktorDetay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDoktorlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchSikayet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource hastaneProjeDataSetBindingSource;
        private HastaneProjeDataSet hastaneProjeDataSet;
        private System.Windows.Forms.BindingSource tblDoktorlarBindingSource;
        private HastaneProjeDataSetTableAdapters.Tbl_DoktorlarTableAdapter tbl_DoktorlarTableAdapter;
        private HastaneProjeDataSetTableAdapters.Tbl_RandevuTableAdapter tbl_RandevuTableAdapter;
        private HastaneProjeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuBransDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn randevuDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tblRandevuBindingSource1;
        private System.Windows.Forms.BindingSource hastaneProjeDataSetBindingSource1;
        private System.Windows.Forms.BindingSource tblRandevuBindingSource;
    }
}
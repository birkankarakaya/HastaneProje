using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class FrmDoktorDuzenle : Form
    {
        public FrmDoktorDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDoktorDuzenle_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            bgl.baglanti().Close();
        }

        private void DoktorGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Tbl_Doktorlar Set DoktorTC=@a1, DoktorAd=@a2, DoktorSoyad=@a3, DoktorBrans=@a4,DoktorSifre=@a5,DoktorTelefon=@a6,DoktorAdres=@a7  Where DoktorID=@a8", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@a1", txtTC.Text);
            guncelle.Parameters.AddWithValue("@a2", txtAd.Text);
            guncelle.Parameters.AddWithValue("@a3", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@a4", cmbBrans.Text);
            guncelle.Parameters.AddWithValue("@a5", txtSifre.Text);
            guncelle.Parameters.AddWithValue("@a6", mskTelefon.Text);
            guncelle.Parameters.AddWithValue("@a7", rtxtAdres.Text);
            guncelle.Parameters.AddWithValue("@a8", Convert.ToInt32(label9.Text));
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            label9.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTC.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskTelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            rtxtAdres.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcNo = txtTCAra.Text;
            
            string sorgu = "Select * from Tbl_Doktorlar where DoktorTC = " + tcNo;
            SqlDataAdapter adap = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataSet ds = new DataSet();
            adap.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDanismaDetay fr = new FrmDanismaDetay();
            fr.Show();
            this.Close();
        }
    }
}

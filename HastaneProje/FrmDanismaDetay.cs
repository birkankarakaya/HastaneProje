using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace HastaneProje
{
    public partial class FrmDanismaDetay : Form
    {
        public FrmDanismaDetay()
        {
            InitializeComponent();
        }

        private void btnDoktorDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorDuzenle frmDoktorDuzenle = new FrmDoktorDuzenle();
            frmDoktorDuzenle.Show();
            this.Hide();
        }

        private void BtnYeniRandevu_Click(object sender, EventArgs e)
        {
            YeniRandevu yr = new YeniRandevu();
            yr.Show();

        }
        public string TCNumara;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmDanismaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCNumara;
            SqlCommand komut1 = new SqlCommand("Select DanismaAd,DanismaSoyad from Tbl_Danisma where DanismaTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0] + " " + dr1[1];
                
            }
            bgl.baglanti().Close();

            if (textBox2.Text == "") 
            {
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Randevu", bgl.baglanti());
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string srg = textBox2.Text;
            string sorgu = "Select * from Tbl_Randevu where HastaTC Like '" + srg + "'";
            SqlDataAdapter adap = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataSet ds = new DataSet();
            adap.Fill(ds);
            this.dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();


            if (textBox2.Text == "")
            {
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Randevu", bgl.baglanti());
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From Tbl_Randevu", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

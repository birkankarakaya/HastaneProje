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

namespace HastaneProje
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad,DogumTarihi from Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
                LblDogTar.Text = dr[2].ToString();
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from Tbl_Randevu where HastaTC = '" + tc+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Branşlar
            SqlCommand komut2 = new SqlCommand("Select Brans From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Randevu where RandevuBrans='" + CmbBrans.Text + "' ", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {

        }

        private void LblDogTar_Click(object sender, EventArgs e)
        {

        }
    }
}

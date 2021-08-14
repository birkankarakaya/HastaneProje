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
            SqlDataAdapter da = new SqlDataAdapter("select* from Tbl_Randevu where HastaTC = '" + tc+ "' AND convert(date,RandevuTarih) < convert(date, getdate())", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Aktif Randevular
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select* from Tbl_Randevu where HastaTC = '" + tc + "' AND convert(date,RandevuTarih) >= convert(date, getdate())", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHastaDuzenle frm = new FrmHastaDuzenle();
            frm.tc1 = LblTC.Text;
            frm.Show();            
        }
    }
}

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
    public partial class YeniRandevu : Form
    {
        public YeniRandevu()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Randevu where RandevuBrans='" + cmbBolum.Text + "' ", bgl.baglanti());
            da.Fill(dt);
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.DataSource = null;
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBolum.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }

        private void YeniRandevu_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select Brans From Tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBolum.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Randevu where RandevuBrans='" + cmbBolum.Text + "' ", bgl.baglanti());
            da.Fill(dt);
            cmbDoktor.DataSource = dt;
        }

        private void RandevuOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevu (HastaTC,HastaAd,HastaSoyad,HastaTelefon,RandevuBrans,RandevuDoktor,RandevuTarih,RandevuSaat,Aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", cmbBolum.Text);
            komut.Parameters.AddWithValue("@p6", cmbDoktor.Text);
            komut.Parameters.AddWithValue("@p7", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p8", mskSaat.Text);
            komut.Parameters.AddWithValue("@p9", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            DialogResult secenek =  MessageBox.Show("Kaydınız gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (secenek == DialogResult.OK)
            {
                FrmDanismaDetay frm = new FrmDanismaDetay();
                frm.Show();
                this.Hide();
            }      

        }
    }
}

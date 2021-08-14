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
    public partial class FrmHastaDuzenle : Form
    {
        FrmHastaDetay frm = new FrmHastaDetay();
        public string tc1;
        sqlbaglantisi bgl = new sqlbaglantisi();

        public FrmHastaDuzenle()
        {
            InitializeComponent();
        }

        private void FrmHastaDuzenle_Load(object sender, EventArgs e)
        {
            btnHastaGuncelle.Enabled = false;


            mskTc.Text = tc1;
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Hastalar Where HastaTC=" + tc1, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[2].ToString();
                txtSoyad.Text = dr[3].ToString();
                mskTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
                mskTarih.Text = dr[7].ToString();
            }
            bgl.baglanti().Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                btnHastaGuncelle.Enabled = true;
            }
            else
            {
                btnHastaGuncelle.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                btnHastaGuncelle.Enabled = true;
            }
            else
            {
                btnHastaGuncelle.Enabled = false;
            }
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Tbl_Hastalar Set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5, DogumTarihi=@p6 WHERE HastaTC=@p7", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", mskTelefon.Text);
            guncelle.Parameters.AddWithValue("@p4", txtSifre.Text);
            guncelle.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            guncelle.Parameters.AddWithValue("@p6", Convert.ToDateTime(mskTarih.Text));
            guncelle.Parameters.AddWithValue("@p7", mskTc.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi");
        }
    }
}

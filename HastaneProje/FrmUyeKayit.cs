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
    public partial class FrmUyeKayit : Form
    {
        public FrmUyeKayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (HastaTC,HastaAd,HastaSoyad,HastaTelefon,HastaSifre,HastaCinsiyet,DogumTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p7", dateTimePicker1.Value);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmHastaGiris frmHastaGiris = new FrmHastaGiris();
            frmHastaGiris.Show();
            this.Hide();
        }

        private void FrmUyeKayit_Load(object sender, EventArgs e)
        {
            btnHastaKayit.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                btnHastaKayit.Enabled = true;
            }
            else
            {
                btnHastaKayit.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                btnHastaKayit.Enabled = true;
            }
            else
            {
                btnHastaKayit.Enabled = false;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void HYeniUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeKayit frm = new FrmUyeKayit();
            frm.Show();
            this.Hide();
        }

        private void btnHastaGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtHastaSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frm = new FrmHastaDetay();
                frm.tc = mskTc.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girdiniz");
                mskTc.Text = "";
                txtHastaSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void txtHastaSifre_TextChanged(object sender, EventArgs e)
        {
            txtHastaSifre.PasswordChar = '*';
        }

        private void HSifreReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifre frm = new FrmSifre();
            frm.Show();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

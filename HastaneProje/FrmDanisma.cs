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
    public partial class FrmDanismaGiris : Form
    {
        public FrmDanismaGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnDoktorGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Danisma where DanismaTC=@p1 and DanismaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskDanismaTc.Text);
            komut.Parameters.AddWithValue("@p2", txtDanismaSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDanismaDetay frm = new FrmDanismaDetay();
                frm.TCNumara = mskDanismaTc.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi girdiniz");
                mskDanismaTc.Text = "";
                txtDanismaSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void txtDoktorSifre_TextChanged(object sender, EventArgs e)
        {
            txtDanismaSifre.PasswordChar = '*';
        }

        private void FrmDanismaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}

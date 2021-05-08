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
    public partial class FrmYeniSifre : Form
    {
        public FrmYeniSifre()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string TC;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                SqlCommand komut = new SqlCommand("update Tbl_Hastalar set HastaSifre='" + textBox1.Text + "' where HastaTC='" + TC + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifreniz başarıyla güncellenmiştir!", "Bilgi", MessageBoxButtons.OK);
                FrmHastaGiris frm = new FrmHastaGiris();
                frm.Show();
                this.Close();
            }
        }
    }
}

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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string TC, AdSoyad;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rchSikayet.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            label5.Text = (dataGridView1.CurrentRow.Cells[2].Value + " " + dataGridView1.CurrentRow.Cells[3].Value).ToString();
            SqlCommand komut = new SqlCommand("Select DogumTarihi, HastaCinsiyet FROM Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = dr[0].ToString();
                label8.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_RandevuTableAdapter.FillBy(this.hastaneProjeDataSet.Tbl_Randevu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void rchSikayet_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneProjeDataSet.Tbl_Doktorlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_DoktorlarTableAdapter.Fill(this.hastaneProjeDataSet.Tbl_Doktorlar);
            LblTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select* from Tbl_Randevu where DoktorTC = '" + TC + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

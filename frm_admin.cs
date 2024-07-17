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
namespace veriTabani2023Proje
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtAd.Text = " ";
            txtKod.Text = " ";
            txtStok.Text = " ";
            txtTarih.Text = " ";
            txtAlınmaZamani.Text = " ";
            txtfiyat.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into eczane_tbl (İlaçAdı,ReçeteKodu,Stok,SonKullanmaTarihi,AlınmaZamanı,Fiyat)values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            string date = txtTarih.Text.ToString();
            DateTime condate = DateTime.Parse(date);
            
            komutKaydet.Parameters.AddWithValue("@p1", txtAd.Text);
            komutKaydet.Parameters.AddWithValue("@p2", txtKod.Text);
            komutKaydet.Parameters.AddWithValue("@p3", txtStok.Text);
            komutKaydet.Parameters.AddWithValue("@p4", condate);
            komutKaydet.Parameters.AddWithValue("@p5", txtAlınmaZamani.Text);
            komutKaydet.Parameters.AddWithValue("@p6", txtfiyat.Text);
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç eklendi");
            temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKod.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtStok.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtAlınmaZamani.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtfiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete from eczane_tbl where İlaçAdı=@s1", baglanti);
            komutSil.Parameters.AddWithValue("@s1", txtAd.Text);
            komutSil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç silindi");
            temizle();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            DataTable dt = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from eczane_tbl", baglanti);
            adtr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update eczane_tbl set ReçeteKodu=@g1,Stok=@g2,SonKullanmaTarihi=@g3,AlınmaZamanı=@g4,Fiyat=@g5 where İlaçAdı=@g6", baglanti);

            string date = txtTarih.Text.ToString();
            DateTime condate = DateTime.Parse(date);

            komutGuncelle.Parameters.AddWithValue("@g1", txtKod.Text);
            komutGuncelle.Parameters.AddWithValue("@g2", txtStok.Text);
            komutGuncelle.Parameters.AddWithValue("@g3", condate);
            komutGuncelle.Parameters.AddWithValue("@g4", txtAlınmaZamani.Text);
            komutGuncelle.Parameters.AddWithValue("@g5", txtfiyat.Text);
            komutGuncelle.Parameters.AddWithValue("@g6", txtAd.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç güncellendi");
            temizle();
        }
    }
}

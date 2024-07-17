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
    public partial class frm_müsteri : Form
    {
        public frm_müsteri()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");

        void Temizle()
        {
            recete_txtbox.Text = " ";
            receteliAdet_txtbox.Text = " ";
            ilacAd_txtbox.Text = " ";
            recetesizAdet_txtbox.Text = " ";
        }
        DateTime sonKullanma;
        void SonKullanmaGetir()
        {
           
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where İlaçAdı=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", ilacAd_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                sonKullanma = DateTime.Parse(dr["SonKullanmaTarihi"].ToString());

            
        }
        string alinmaZamani;

        void AlınmaZamanınıGetir()
        {
            
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where İlaçAdı=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", ilacAd_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                alinmaZamani = (dr["AlınmaZamanı"]).ToString();

         
        }

        int fiyat;
        void FiyatıGetir()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where İlaçAdı=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", ilacAd_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                fiyat = int.Parse(dr["Fiyat"].ToString());

          
        }
        DateTime sonKullanma1;
        void SonKullanmaGetir1()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where ReçeteKodu=@p2", baglanti);
            komut1.Parameters.AddWithValue("@p2", recete_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                sonKullanma1 = DateTime.Parse(dr["SonKullanmaTarihi"].ToString());


        }
        string alinmaZamani1;

        void AlınmaZamanınıGetir1()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where ReçeteKodu=@p2", baglanti);
            komut1.Parameters.AddWithValue("@p2", recete_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                alinmaZamani1 = (dr["AlınmaZamanı"]).ToString();


        }
        int fiyat1;
        void FiyatıGetir1()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where ReçeteKodu=@p2", baglanti);
            komut1.Parameters.AddWithValue("@p2", recete_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                fiyat1 = int.Parse(dr["Fiyat"].ToString());


        }
        int  stok;
        void Stok()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where İlaçAdı=@p3", baglanti);
            komut1.Parameters.AddWithValue("@p3", ilacAd_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                stok = int.Parse(dr["stok"].ToString());


        }
        int stok1;
        void Stok1()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from eczane_tbl where ReçeteKodu=@p3", baglanti);
            komut1.Parameters.AddWithValue("@p3", recete_txtbox.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
                stok1 = int.Parse(dr["stok"].ToString());


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void receteliAlım_btn_Click(object sender, EventArgs e)
        {
            SonKullanmaGetir1();
            AlınmaZamanınıGetir1();
            FiyatıGetir1();

            if (radioButton1.Checked == true)
                fiyat1 = 0;

            Stok1();
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            string adet = receteliAdet_txtbox.Text;
            baglanti.Open();





            if ((stok1 == 0) || ((Convert.ToInt32(adet) > stok1)))
                MessageBox.Show("Elimizde istedİğiniz adette ilaç mevcut değil. Depodan isteyeceğim.");
            if (stok1 > 0)
            {
                stok1 = (stok1 - (Convert.ToInt32(adet)));

                SqlCommand komutGüncelle = new SqlCommand("Update eczane_tbl set Stok=@p3 where ReçeteKodu=@p4", baglanti);
                komutGüncelle.Parameters.AddWithValue("@p3", stok1);
                komutGüncelle.Parameters.AddWithValue("p4", recete_txtbox.Text);
                komutGüncelle.ExecuteNonQuery();


                MessageBox.Show("İlacınızın son kullanma tarihi : " + sonKullanma1.ToString() + "\n" +
                "İlacınızın alınma zamanı: " + alinmaZamani1 + "\n" +
                "İlacınızın ücreti: " + fiyat1.ToString());

            }
            baglanti.Close();
            Temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void recetesizAlım_btn_Click(object sender, EventArgs e)
        {
            SonKullanmaGetir();
            AlınmaZamanınıGetir();
            FiyatıGetir();
            Stok();
            SqlConnection baglanti = new SqlConnection("Data Source=MELIKEPC\\MSSQLSERVER01;Initial Catalog=eczane;Integrated Security=True");
            string adet = recetesizAdet_txtbox.Text;
            baglanti.Open();
         
         

                
            
            if ((stok==0)||((Convert.ToInt32(adet) > stok)))
                MessageBox.Show("Elimizde istedİğiniz adette ilaç mevcut değil. Depodan isteyeceğim.");
            if (stok>0)
            {
                stok = (stok - (Convert.ToInt32(adet)));

                SqlCommand komutGüncelle = new SqlCommand("Update eczane_tbl set Stok=@p5 where İlaçAdı=@p6", baglanti);
                komutGüncelle.Parameters.AddWithValue("@p5", stok);
                komutGüncelle.Parameters.AddWithValue("p6", ilacAd_txtbox.Text);
                komutGüncelle.ExecuteNonQuery();




                

                MessageBox.Show("İlacınızın son kullanma tarihi : " + sonKullanma.ToString() + "\n" +
                    "İlacınızın alınma zamanı : " + alinmaZamani + "\n" +
                    "İlacınızın ücreti : " + fiyat.ToString() + " TL");
            }

            baglanti.Close();
            Temizle();

        }


    }
    }


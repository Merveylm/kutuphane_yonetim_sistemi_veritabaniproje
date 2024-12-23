using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphane__yonetimi
{
    public partial class Frmkitap : Form
    {
        public Frmkitap()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=LocalHost ; port=5432; Database=kutuphaneyonetimi ; user ID=postgres; password=MERVE123");
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM \"Kitaplar\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "INSERT INTO \"Kitaplar\" (\"kitapAdi\", \"yazarID\", \"kategoriID\", \"yayinciID\", \"yayinTarihi\", \"stokMiktari\") VALUES (@p2, @p3, @p4, @p5, @p6, @p7)";
                NpgsqlCommand komut1 = new NpgsqlCommand(sorgu, baglanti);

                komut1.Parameters.AddWithValue("@p2", textBox2.Text); // Kitap Adı
                komut1.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox3.Text)); // Yazar ID
                komut1.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox4.Text)); // Kategori ID
                komut1.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox5.Text)); // Yayıncı ID
                komut1.Parameters.AddWithValue("@p6", Convert.ToDateTime(textBox6.Text)); // Yayın Tarihi
                komut1.Parameters.AddWithValue("@p7", Convert.ToInt32(numericUpDown1.Value)); // Stok Miktarı

                komut1.ExecuteNonQuery();
                MessageBox.Show("KİTAP EKLEME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "DELETE FROM \"Kitaplar\" WHERE \"kitapID\" = @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Kitap ID

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("KİTAP SİLME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip kitap bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "UPDATE \"Kitaplar\" SET \"kitapAdi\" = @p2, \"yazarID\" = @p3, \"kategoriID\" = @p4, \"yayinciID\" = @p5, \"yayinTarihi\" = @p6, \"stokMiktari\" = @p7 WHERE \"kitapID\" = @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Kitap ID
                komut.Parameters.AddWithValue("@p2", textBox2.Text); // Kitap Adı
                komut.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox3.Text)); // Yazar ID
                komut.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox4.Text)); // Kategori ID
                komut.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox5.Text)); // Yayıncı ID
                komut.Parameters.AddWithValue("@p6", Convert.ToDateTime(textBox6.Text)); // Yayın Tarihi
                komut.Parameters.AddWithValue("@p7", Convert.ToInt32(numericUpDown1.Value)); // Stok Miktarı

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("KİTAP GÜNCELLEME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip kitap bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "SELECT * FROM \"Kitaplar\" WHERE \"kitapAdi\" LIKE @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", "%" + textBox2.Text + "%"); // Arama kriteri

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();  Form.Show(); this.Hide();
        }
    }
}

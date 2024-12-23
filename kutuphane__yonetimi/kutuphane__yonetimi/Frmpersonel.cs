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

namespace kutuphane__yonetimi
{
    public partial class Frmpersonel : Form
    {
        public Frmpersonel()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=LocalHost ; port=5432; Database=kutuphaneyonetimi ; user ID=postgres; password=MERVE123");
        private void btnAra_Click(object sender, EventArgs e)
        {



            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "SELECT * FROM \"Personeller\" WHERE \"pozisyon\" LIKE @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", "%" + textBox2.Text + "%"); // Arama kriteri olarak pozisyon

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

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "INSERT INTO \"Personeller\" (\"uyeID\", \"pozisyon\", \"iseGirisTarihi\") VALUES (@p1, @p2, @p3)";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Üye ID
                komut.Parameters.AddWithValue("@p2", textBox2.Text); // Pozisyon
                komut.Parameters.AddWithValue("@p3", Convert.ToDateTime(textBox3.Text)); // İşe Giriş Tarihi

                komut.ExecuteNonQuery();
                MessageBox.Show("Personel ekleme işlemi başarılı bir şekilde gerçekleşti.");
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

                string sorgu = "UPDATE \"Personeller\" SET \"pozisyon\" = @p1, \"iseGirisTarihi\" = @p2 WHERE \"uyeID\" = @p3";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", textBox2.Text); // Pozisyon
                komut.Parameters.AddWithValue("@p2", Convert.ToDateTime(textBox3.Text)); // İşe Giriş Tarihi
                komut.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox1.Text)); // Üye ID

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Personel güncelleme işlemi başarılı bir şekilde gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip personel bulunamadı.");
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

        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "DELETE FROM \"Personeller\" WHERE \"uyeID\" = @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Üye ID

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Personel silme işlemi başarılı bir şekilde gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip personel bulunamadı.");
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

        private void btnListele_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "SELECT * FROM \"Personeller\"";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

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

        private void btnDön_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1(); Form.Show(); this.Hide();
        }
    }
}






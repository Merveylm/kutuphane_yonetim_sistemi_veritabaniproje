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
    public partial class Frmyayinci : Form
    {
        public Frmyayinci()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=LocalHost ; port=5432; Database=kutuphaneyonetimi ; user ID=postgres; password=MERVE123");
        private void btnListele_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "SELECT * FROM \"Yayincilar\"";
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

        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "INSERT INTO \"Yayincilar\" (\"yayinciAdi\", \"adres\", \"telefon\") VALUES (@p1, @p2, @p3)";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", textBox2.Text); // Yayıncı Adı
                komut.Parameters.AddWithValue("@p2", textBox3.Text); // Adres
                komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text); // Telefon

                komut.ExecuteNonQuery();
                MessageBox.Show("Yayıncı ekleme işlemi başarılı bir şekilde gerçekleşti.");
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

                string sorgu = "SELECT * FROM \"Yayincilar\" WHERE \"yayinciAdi\" LIKE @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", "%" + textBox2.Text + "%"); // Arama kriteri olarak yayıncı adı

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "UPDATE \"Yayincilar\" SET \"yayinciAdi\" = @p1, \"adres\" = @p2, \"telefon\" = @p3 WHERE \"yayinciID\" = @p4";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", textBox2.Text); // Yayıncı Adı
                komut.Parameters.AddWithValue("@p2", textBox3.Text); // Adres
                komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text); // Telefon
                komut.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox1.Text)); // Yayıncı ID

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Yayıncı güncelleme işlemi başarılı bir şekilde gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip yayıncı bulunamadı.");
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

                string sorgu = "DELETE FROM \"Yayincilar\" WHERE \"yayinciID\" = @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Yayıncı ID

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Yayıncı silme işlemi başarılı bir şekilde gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip yayıncı bulunamadı.");
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

        private void btnDön_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1(); Form.Show(); this.Hide();
        }
    }
}





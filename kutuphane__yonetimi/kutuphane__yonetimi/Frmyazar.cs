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
    public partial class Frmyazar : Form
    {
        public Frmyazar()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=LocalHost ; port=5432; Database=kutuphaneyonetimi ; user ID=postgres; password=MERVE123");
        private void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "INSERT INTO \"Yazarlar\" (\"yazarAdi\", \"yazarSoyadi\", \"dogumTarihi\") VALUES (@p1, @p2, @p3)";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", textBox2.Text); // Yazar Adı
                komut.Parameters.AddWithValue("@p2", textBox3.Text); // Yazar Soyadı
                komut.Parameters.AddWithValue("@p3", Convert.ToDateTime(textBox4.Text)); // Doğum Tarihi

                komut.ExecuteNonQuery();
                MessageBox.Show("Yazar ekleme işlemi başarılı bir şekilde gerçekleşti.");
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

                string sorgu = "SELECT * FROM \"Yazarlar\"";
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

        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "DELETE FROM \"Yazarlar\" WHERE \"yazarID\" = @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text)); // Yazar ID

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Yazar silme işlemi başarılı bir şekilde gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip yazar bulunamadı.");
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

                string sorgu = "SELECT * FROM \"Yazarlar\" WHERE \"yazarAdi\" LIKE @p1";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", "%" + textBox2.Text + "%"); // Arama kriteri olarak yazar adı

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

                string sorgu = "UPDATE \"Yazarlar\" SET \"yazarAdi\" = @p1, \"yazarSoyadi\" = @p2, \"dogumTarihi\" = @p3 WHERE \"yazarID\" = @p4";
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", textBox2.Text); // Yazar Adı
                komut.Parameters.AddWithValue("@p2", textBox3.Text); // Yazar Soyadı
                komut.Parameters.AddWithValue("@p3", Convert.ToDateTime(textBox4.Text)); // Doğum Tarihi
                komut.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox1.Text)); // Yazar ID

                int rowsAffected = komut.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Yazar güncelleme işlemi başarılı bir şekilde gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip yazar bulunamadı.");
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




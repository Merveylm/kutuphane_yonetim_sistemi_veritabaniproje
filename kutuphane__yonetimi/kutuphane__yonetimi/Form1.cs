namespace kutuphane__yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmkitap kitapForm = new Frmkitap(); kitapForm.Show(); this.Hide(); // Mevcut formu gizler
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmyazar yazarForm = new Frmyazar(); yazarForm.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frmyayinci yayinciForm = new Frmyayinci(); yayinciForm.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmpersonel personelForm = new Frmpersonel(); personelForm.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmogrenci ogrenciForm = new Frmogrenci(); ogrenciForm.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmogretmen ogretmenForm = new Frmogretmen(); ogretmenForm.Show(); this.Hide();
        }
    }
}

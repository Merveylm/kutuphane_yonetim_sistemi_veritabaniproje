namespace kutuphane__yonetimi
{
    partial class Frmogrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmogrenci));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnAra = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            btnSil = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(416, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(458, 429);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(79, 53);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "ÜYE ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(28, 107);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 2;
            label2.Text = "MEZUNİYET YILI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(56, 161);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 3;
            label3.Text = "SINIF BİLGİSİ:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 27);
            textBox3.TabIndex = 6;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.Peru;
            btnAra.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.Location = new Point(158, 225);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 43);
            btnAra.TabIndex = 7;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Peru;
            btnEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(79, 283);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 42);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Peru;
            btnGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(223, 283);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(118, 42);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.Peru;
            btnListele.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnListele.Location = new Point(79, 342);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(106, 42);
            btnListele.TabIndex = 10;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Peru;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(223, 342);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(118, 42);
            btnSil.TabIndex = 11;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.FromArgb(0, 0, 192);
            button6.Location = new Point(106, 398);
            button6.Name = "button6";
            button6.Size = new Size(200, 40);
            button6.TabIndex = 12;
            button6.Text = "ANASAYFAYA DÖN";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Frmogrenci
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(886, 493);
            Controls.Add(button6);
            Controls.Add(btnSil);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnAra);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Frmogrenci";
            Text = "ÖĞRENCİ GİRİŞİ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnAra;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnListele;
        private Button btnSil;
        private Button button6;
    }
}
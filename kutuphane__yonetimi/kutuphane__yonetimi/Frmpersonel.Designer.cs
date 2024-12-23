namespace kutuphane__yonetimi
{
    partial class Frmpersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpersonel));
            dataGridView1 = new DataGridView();
            btnAra = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            btnDön = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(489, 31);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(612, 499);
            dataGridView1.TabIndex = 0;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.FromArgb(255, 192, 128);
            btnAra.ForeColor = Color.FromArgb(192, 0, 0);
            btnAra.Location = new Point(145, 298);
            btnAra.Margin = new Padding(4, 3, 4, 3);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(131, 43);
            btnAra.TabIndex = 1;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(255, 192, 128);
            btnEkle.ForeColor = Color.FromArgb(192, 0, 0);
            btnEkle.Location = new Point(56, 361);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(132, 46);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 192, 128);
            btnGuncelle.ForeColor = Color.FromArgb(192, 0, 0);
            btnGuncelle.Location = new Point(244, 361);
            btnGuncelle.Margin = new Padding(4, 3, 4, 3);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 46);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 192, 128);
            btnSil.ForeColor = Color.FromArgb(192, 0, 0);
            btnSil.Location = new Point(56, 426);
            btnSil.Margin = new Padding(4, 3, 4, 3);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 43);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(255, 192, 128);
            btnListele.ForeColor = Color.FromArgb(192, 0, 0);
            btnListele.Location = new Point(244, 426);
            btnListele.Margin = new Padding(4, 3, 4, 3);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(132, 43);
            btnListele.TabIndex = 5;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnDön
            // 
            btnDön.ForeColor = Color.Navy;
            btnDön.Location = new Point(95, 506);
            btnDön.Margin = new Padding(4, 3, 4, 3);
            btnDön.Name = "btnDön";
            btnDön.Size = new Size(245, 42);
            btnDön.TabIndex = 6;
            btnDön.Text = "ANASAYFAYA DÖN";
            btnDön.UseVisualStyleBackColor = true;
            btnDön.Click += btnDön_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(74, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 7;
            label1.Text = "ÜYE ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.Location = new Point(61, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 8;
            label2.Text = "POZİSYON:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Location = new Point(13, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 9;
            label3.Text = "İŞE GİRİŞ TARİHİ:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 30);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 30);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 30);
            textBox3.TabIndex = 12;
            // 
            // Frmpersonel
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1131, 560);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDön);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnAra);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frmpersonel";
            Text = "PERSONEL GİRİŞİ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAra;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private Button btnDön;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
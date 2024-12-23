namespace kutuphane__yonetimi
{
    partial class Frmyayinci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmyayinci));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            btnListele = new Button();
            btnAra = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            btnDön = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 31);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(613, 520);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(709, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 23);
            label1.TabIndex = 1;
            label1.Text = "YAYINCI ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(709, 79);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 2;
            label2.Text = "YAYINCI ADI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(694, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 23);
            label3.TabIndex = 3;
            label3.Text = "YAYINCI ADRESİ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(709, 167);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 4;
            label4.Text = "TELEFON NO:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(831, 24);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 30);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(831, 72);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 30);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(846, 117);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 30);
            textBox3.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(846, 167);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(156, 30);
            maskedTextBox1.TabIndex = 8;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.RosyBrown;
            btnListele.ForeColor = Color.Black;
            btnListele.Location = new Point(755, 245);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 43);
            btnListele.TabIndex = 9;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.RosyBrown;
            btnAra.ForeColor = Color.Black;
            btnAra.Location = new Point(892, 245);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 43);
            btnAra.TabIndex = 10;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.RosyBrown;
            btnGuncelle.Location = new Point(744, 313);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(116, 40);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.RosyBrown;
            btnSil.ForeColor = SystemColors.ActiveCaptionText;
            btnSil.Location = new Point(892, 313);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 40);
            btnSil.TabIndex = 12;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.RosyBrown;
            btnEkle.Location = new Point(820, 370);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(102, 42);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnDön
            // 
            btnDön.BackColor = Color.AliceBlue;
            btnDön.ForeColor = Color.DarkBlue;
            btnDön.Location = new Point(731, 456);
            btnDön.Name = "btnDön";
            btnDön.Size = new Size(255, 29);
            btnDön.TabIndex = 14;
            btnDön.Text = "ANASAYFAYA DÖN";
            btnDön.UseVisualStyleBackColor = false;
            btnDön.Click += btnDön_Click;
            // 
            // Frmyayinci
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1014, 578);
            Controls.Add(btnDön);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnAra);
            Controls.Add(btnListele);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frmyayinci";
            Text = "YAYINCILAR";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox1;
        private Button btnListele;
        private Button btnAra;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnDön;
    }
}
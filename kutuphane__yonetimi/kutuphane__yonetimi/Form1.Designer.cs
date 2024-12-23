namespace kutuphane__yonetimi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(144, 170);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(258, 73);
            button1.TabIndex = 0;
            button1.Text = "KİTAPLAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(144, 288);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(258, 69);
            button2.TabIndex = 1;
            button2.Text = "YAZARLAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(602, 210);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(247, 58);
            button4.TabIndex = 3;
            button4.Text = "PERSONEL GİRİŞİ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(602, 413);
            button3.Name = "button3";
            button3.Size = new Size(247, 55);
            button3.TabIndex = 4;
            button3.Text = "ÖĞRETMEN GİRİŞİ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Thistle;
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(602, 314);
            button5.Name = "button5";
            button5.Size = new Size(247, 59);
            button5.TabIndex = 5;
            button5.Text = "ÖĞRENCİ GİRİŞİ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.YellowGreen;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(655, 141);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 6;
            label1.Text = "ÜYE İŞLEMLERİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(108, 45);
            label2.Name = "label2";
            label2.Size = new Size(770, 40);
            label2.TabIndex = 7;
            label2.Text = "KÜTÜPHANE YÖNETİM SİSTEMİNE HOŞGELDİNİZ";
            // 
            // button6
            // 
            button6.BackColor = Color.Thistle;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(144, 404);
            button6.Name = "button6";
            button6.Size = new Size(258, 64);
            button6.TabIndex = 8;
            button6.Text = "YAYINCILAR";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1100, 562);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.FromArgb(255, 192, 192);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "KÜTÜPHANE YÖNETİM SİSTEMİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Label label1;
        private Label label2;
        private Button button6;
    }
}

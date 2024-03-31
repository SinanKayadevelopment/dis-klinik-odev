
namespace ödevproje
{
    partial class Hasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            HAdSoyadTb = new TextBox();
            label3 = new Label();
            HTelefonTb = new TextBox();
            label5 = new Label();
            label6 = new Label();
            HDogumTarih = new DateTimePicker();
            HCinsiyetCb = new ComboBox();
            label7 = new Label();
            AlerjiTb = new TextBox();
            label8 = new Label();
            AdresTb = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            textBox5 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 100);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(1066, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 32);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(393, 29);
            label1.Name = "label1";
            label1.Size = new Size(324, 32);
            label1.TabIndex = 0;
            label1.Text = "DİŞ KLİNİĞİ OTOMASYONU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(393, 116);
            label4.Name = "label4";
            label4.Size = new Size(218, 21);
            label4.TabIndex = 7;
            label4.Text = "FIRAT ÜNİVERSİTE DİŞ KLİNİĞİ";
            // 
            // HAdSoyadTb
            // 
            HAdSoyadTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            HAdSoyadTb.Location = new Point(177, 176);
            HAdSoyadTb.Name = "HAdSoyadTb";
            HAdSoyadTb.Size = new Size(173, 29);
            HAdSoyadTb.TabIndex = 9;
            HAdSoyadTb.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(40, 178);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 8;
            label3.Text = "Ad Soyad:";
            label3.Click += label3_Click;
            // 
            // HTelefonTb
            // 
            HTelefonTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            HTelefonTb.Location = new Point(177, 240);
            HTelefonTb.Name = "HTelefonTb";
            HTelefonTb.Size = new Size(173, 29);
            HTelefonTb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(40, 242);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 10;
            label5.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(40, 304);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 12;
            label6.Text = "Doğum Tarihi:";
            // 
            // HDogumTarih
            // 
            HDogumTarih.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            HDogumTarih.Format = DateTimePickerFormat.Short;
            HDogumTarih.Location = new Point(177, 302);
            HDogumTarih.Name = "HDogumTarih";
            HDogumTarih.Size = new Size(173, 29);
            HDogumTarih.TabIndex = 13;
            HDogumTarih.ValueChanged += HDogumTarih_ValueChanged;
            // 
            // HCinsiyetCb
            // 
            HCinsiyetCb.FormattingEnabled = true;
            HCinsiyetCb.Items.AddRange(new object[] { "Erkek", "Kadın" });
            HCinsiyetCb.Location = new Point(177, 364);
            HCinsiyetCb.Name = "HCinsiyetCb";
            HCinsiyetCb.Size = new Size(173, 23);
            HCinsiyetCb.TabIndex = 15;
            HCinsiyetCb.SelectedIndexChanged += HCinsiyetCb_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(40, 364);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 16;
            label7.Text = "Cinsiyet:";
            // 
            // AlerjiTb
            // 
            AlerjiTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AlerjiTb.Location = new Point(177, 421);
            AlerjiTb.Name = "AlerjiTb";
            AlerjiTb.Size = new Size(173, 29);
            AlerjiTb.TabIndex = 18;
            AlerjiTb.TextChanged += AlerjiTb_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(40, 423);
            label8.Name = "label8";
            label8.Size = new Size(55, 21);
            label8.TabIndex = 17;
            label8.Text = "Alerji:";
            // 
            // AdresTb
            // 
            AdresTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AdresTb.Location = new Point(177, 480);
            AdresTb.Name = "AdresTb";
            AdresTb.Size = new Size(173, 29);
            AdresTb.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(40, 482);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 19;
            label9.Text = "Adres:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(381, 353);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 21;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(447, 423);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 22;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(521, 353);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 23;
            button3.Text = "Düzenle";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(664, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(408, 328);
            dataGridView1.TabIndex = 24;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox5.Location = new Point(664, 128);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 29);
            textBox5.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(872, 124);
            button4.Name = "button4";
            button4.Size = new Size(66, 41);
            button4.TabIndex = 26;
            button4.Text = "Ara";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.RosyBrown;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(961, 124);
            button5.Name = "button5";
            button5.Size = new Size(78, 41);
            button5.TabIndex = 27;
            button5.Text = "Yenile";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            // 
            // Hasta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 542);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AdresTb);
            Controls.Add(label9);
            Controls.Add(AlerjiTb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(HCinsiyetCb);
            Controls.Add(HDogumTarih);
            Controls.Add(label6);
            Controls.Add(HTelefonTb);
            Controls.Add(label5);
            Controls.Add(HAdSoyadTb);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hasta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void HCinsiyetCb_SelectedIndexChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox HAdSoyadTb;
        private Label label3;
        private TextBox HTelefonTb;
        private Label label5;
        private Label label6;
        private DateTimePicker HDogumTarih;
        private ComboBox HCinsiyetCb;
        private Label label7;
        private TextBox AlerjiTb;
        private Label label8;
        private TextBox AdresTb;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private Button button4;
        private Button button5;
    }
}
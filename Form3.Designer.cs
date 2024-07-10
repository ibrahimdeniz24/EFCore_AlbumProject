namespace WFA_PlakDükkanı
{
    partial class Form3
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
            btnGirisDon = new Button();
            btnUyeOL = new Button();
            dtpDogumTarihi = new DateTimePicker();
            cbxGender = new ComboBox();
            label9 = new Label();
            label2 = new Label();
            txtSoyadi = new TextBox();
            txtKullaniciAdi = new TextBox();
            txtAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrari = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // btnGirisDon
            // 
            btnGirisDon.Location = new Point(63, 464);
            btnGirisDon.Name = "btnGirisDon";
            btnGirisDon.Size = new Size(389, 47);
            btnGirisDon.TabIndex = 11;
            btnGirisDon.Text = "Giriş Ekranına Dön";
            btnGirisDon.UseVisualStyleBackColor = true;
            btnGirisDon.Click += btnGirisDon_Click;
            // 
            // btnUyeOL
            // 
            btnUyeOL.Location = new Point(63, 383);
            btnUyeOL.Name = "btnUyeOL";
            btnUyeOL.Size = new Size(389, 47);
            btnUyeOL.TabIndex = 30;
            btnUyeOL.Text = "Üyeliği Tamamla";
            btnUyeOL.UseVisualStyleBackColor = true;
            btnUyeOL.Click += btnUyeOL_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(192, 325);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(260, 27);
            dtpDogumTarihi.TabIndex = 29;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(192, 275);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(260, 28);
            cbxGender.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 45);
            label9.Name = "label9";
            label9.Size = new Size(95, 20);
            label9.TabIndex = 21;
            label9.Text = "Kullanci Adi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 83);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 14;
            label2.Text = "Şifre:";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(192, 223);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(260, 27);
            txtSoyadi.TabIndex = 24;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(192, 38);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(260, 27);
            txtKullaniciAdi.TabIndex = 12;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(192, 178);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(260, 27);
            txtAdi.TabIndex = 23;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(192, 80);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(260, 27);
            txtSifre.TabIndex = 19;
            // 
            // txtSifreTekrari
            // 
            txtSifreTekrari.Location = new Point(192, 113);
            txtSifreTekrari.Name = "txtSifreTekrari";
            txtSifreTekrari.PasswordChar = '*';
            txtSifreTekrari.Size = new Size(260, 27);
            txtSifreTekrari.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 116);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 14;
            label1.Text = "Şifre Tekrari :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 181);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 14;
            label3.Text = "Adi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 330);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 14;
            label4.Text = "Doğum Tarihi :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 283);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 31;
            label5.Text = "Cinsiyet :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 226);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 32;
            label6.Text = "Soyadi :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(192, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 24);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Şifreyi Gör";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 571);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnUyeOL);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(cbxGender);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtSoyadi);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtAdi);
            Controls.Add(txtSifreTekrari);
            Controls.Add(txtSifre);
            Controls.Add(btnGirisDon);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisDon;
        private Button btnUyeOL;
        private DateTimePicker dtpDogumTarihi;
        private ComboBox cbxGender;
        private Label label9;
        private Label label2;
        private TextBox txtSoyadi;
        private TextBox txtKullaniciAdi;
        private TextBox txtAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrari;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
    }
}
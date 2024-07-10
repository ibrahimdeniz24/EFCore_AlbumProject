namespace WFA_PlakDükkanı
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
            txtKulllaciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnUyeOL = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSifreTekrari = new TextBox();
            label4 = new Label();
            chbSifreGor = new CheckBox();
            SuspendLayout();
            // 
            // txtKulllaciAdi
            // 
            txtKulllaciAdi.Location = new Point(168, 82);
            txtKulllaciAdi.Name = "txtKulllaciAdi";
            txtKulllaciAdi.Size = new Size(275, 27);
            txtKulllaciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(168, 144);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(275, 27);
            txtSifre.TabIndex = 0;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(27, 254);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(131, 56);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnUyeOL
            // 
            btnUyeOL.Location = new Point(179, 254);
            btnUyeOL.Name = "btnUyeOL";
            btnUyeOL.Size = new Size(264, 56);
            btnUyeOL.TabIndex = 2;
            btnUyeOL.Text = "ÜYE OL";
            btnUyeOL.UseVisualStyleBackColor = true;
            btnUyeOL.Click += btnUyeOL_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 18);
            label1.Name = "label1";
            label1.Size = new Size(283, 30);
            label1.TabIndex = 3;
            label1.Text = "Admin Giriş Ekranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanici Adi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 151);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Şifre :";
            // 
            // txtSifreTekrari
            // 
            txtSifreTekrari.Location = new Point(168, 177);
            txtSifreTekrari.Name = "txtSifreTekrari";
            txtSifreTekrari.PasswordChar = '*';
            txtSifreTekrari.Size = new Size(275, 27);
            txtSifreTekrari.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 184);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 4;
            label4.Text = "Şifre  Tekarı :";
            // 
            // chbSifreGor
            // 
            chbSifreGor.AutoSize = true;
            chbSifreGor.Location = new Point(168, 210);
            chbSifreGor.Name = "chbSifreGor";
            chbSifreGor.Size = new Size(100, 24);
            chbSifreGor.TabIndex = 5;
            chbSifreGor.Text = "Şifreyi Gör";
            chbSifreGor.UseVisualStyleBackColor = true;
            chbSifreGor.CheckedChanged += chbSifreGor_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 366);
            Controls.Add(chbSifreGor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUyeOL);
            Controls.Add(btnGiris);
            Controls.Add(txtSifreTekrari);
            Controls.Add(txtSifre);
            Controls.Add(txtKulllaciAdi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKulllaciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnUyeOL;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSifreTekrari;
        private Label label4;
        private CheckBox chbSifreGor;
    }
}

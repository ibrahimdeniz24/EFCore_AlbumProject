namespace WFA_PlakDükkanı
{
    partial class btnRaporlar
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
            txtAlbümAdi = new TextBox();
            label1 = new Label();
            txtSanatci = new TextBox();
            label2 = new Label();
            txtFiyat = new TextBox();
            label3 = new Label();
            txtIndirim = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpTarih = new DateTimePicker();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnEkle = new Button();
            txtID = new TextBox();
            label6 = new Label();
            btnDelete = new Button();
            btnGetir = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnGuncelle = new Button();
            label7 = new Label();
            lstvNo5 = new ListView();
            columnHeader18 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            label8 = new Label();
            lstvNo4 = new ListView();
            columnHeader19 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            label9 = new Label();
            lstvNo3 = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            label10 = new Label();
            lstvNo2 = new ListView();
            columnHeader16 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            cbxAktif = new ComboBox();
            label11 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // txtAlbümAdi
            // 
            txtAlbümAdi.Location = new Point(133, 16);
            txtAlbümAdi.Name = "txtAlbümAdi";
            txtAlbümAdi.Size = new Size(250, 27);
            txtAlbümAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "AlbümAdi :";
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(133, 68);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(250, 27);
            txtSanatci.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Sanatçı :";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(133, 122);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(250, 27);
            txtFiyat.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 125);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "Liste Fiyatı :";
            // 
            // txtIndirim
            // 
            txtIndirim.Location = new Point(133, 181);
            txtIndirim.Name = "txtIndirim";
            txtIndirim.Size = new Size(250, 27);
            txtIndirim.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 184);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 1;
            label4.Text = "İndirim Oranı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 230);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 1;
            label5.Text = "Çıkış Tarihi :";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(133, 230);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.GridLines = true;
            listView1.Location = new Point(22, 466);
            listView1.Name = "listView1";
            listView1.Size = new Size(762, 246);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Albüm Adi";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sanatçı";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Çıkış Tarihi";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Aktif Durumu";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Liste Fiyati";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "İndirim Orani";
            columnHeader7.Width = 100;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(22, 347);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(361, 51);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Albüm Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(517, 23);
            txtID.Name = "txtID";
            txtID.Size = new Size(202, 27);
            txtID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 26);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 7;
            label6.Text = "ID :";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(517, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(202, 64);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Albüm Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(517, 205);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(202, 67);
            btnGetir.TabIndex = 10;
            btnGetir.Text = "Albüm Bilgieri Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(517, 340);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(202, 58);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1241, 414);
            label7.Name = "label7";
            label7.Size = new Size(194, 20);
            label7.TabIndex = 20;
            label7.Text = "İnidirmdeki Albümler  NO: 5";
            // 
            // lstvNo5
            // 
            lstvNo5.Columns.AddRange(new ColumnHeader[] { columnHeader18, columnHeader8, columnHeader9 });
            lstvNo5.Location = new Point(1186, 437);
            lstvNo5.Name = "lstvNo5";
            lstvNo5.Size = new Size(303, 275);
            lstvNo5.TabIndex = 19;
            lstvNo5.UseCompatibleStateImageBehavior = false;
            lstvNo5.View = View.Details;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "ID";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Albüm Adi";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Sanatıçısı";
            columnHeader9.Width = 150;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1220, 13);
            label8.Name = "label8";
            label8.Size = new Size(243, 20);
            label8.TabIndex = 18;
            label8.Text = "En Son Eklenen 10  Albümler  NO: 4";
            // 
            // lstvNo4
            // 
            lstvNo4.Columns.AddRange(new ColumnHeader[] { columnHeader19, columnHeader10, columnHeader11 });
            lstvNo4.Location = new Point(1186, 36);
            lstvNo4.Name = "lstvNo4";
            lstvNo4.Size = new Size(303, 322);
            lstvNo4.TabIndex = 17;
            lstvNo4.UseCompatibleStateImageBehavior = false;
            lstvNo4.View = View.Details;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "ID";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Albüm Adi";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Sanatıçısı";
            columnHeader11.Width = 150;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(827, 414);
            label9.Name = "label9";
            label9.Size = new Size(242, 20);
            label9.TabIndex = 16;
            label9.Text = "Satışı Devam Eden Albümler  NO: 3";
            // 
            // lstvNo3
            // 
            lstvNo3.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader12, columnHeader13 });
            lstvNo3.Location = new Point(804, 437);
            lstvNo3.Name = "lstvNo3";
            lstvNo3.Size = new Size(303, 275);
            lstvNo3.TabIndex = 15;
            lstvNo3.UseCompatibleStateImageBehavior = false;
            lstvNo3.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "ID";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Albüm Adi";
            columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Sanatıçısı";
            columnHeader13.Width = 150;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(860, 13);
            label10.Name = "label10";
            label10.Size = new Size(209, 20);
            label10.TabIndex = 14;
            label10.Text = "Satışı Durmuş Albümler  NO: 2";
            // 
            // lstvNo2
            // 
            lstvNo2.Columns.AddRange(new ColumnHeader[] { columnHeader16, columnHeader14, columnHeader15 });
            lstvNo2.Location = new Point(804, 36);
            lstvNo2.Name = "lstvNo2";
            lstvNo2.Size = new Size(303, 322);
            lstvNo2.TabIndex = 13;
            lstvNo2.UseCompatibleStateImageBehavior = false;
            lstvNo2.View = View.Details;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "ID";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Albüm Adi";
            columnHeader14.Width = 150;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Sanatıçısı";
            columnHeader15.Width = 150;
            // 
            // cbxAktif
            // 
            cbxAktif.FormattingEnabled = true;
            cbxAktif.Location = new Point(133, 284);
            cbxAktif.Name = "cbxAktif";
            cbxAktif.Size = new Size(250, 28);
            cbxAktif.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 287);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 1;
            label11.Text = "Aktiflik  :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(366, 437);
            label13.Name = "label13";
            label13.Size = new Size(146, 20);
            label13.TabIndex = 23;
            label13.Text = "ALBÜM LİSTESİ NO:1";
            // 
            // btnRaporlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1520, 710);
            Controls.Add(label13);
            Controls.Add(cbxAktif);
            Controls.Add(label7);
            Controls.Add(lstvNo5);
            Controls.Add(label8);
            Controls.Add(lstvNo4);
            Controls.Add(label9);
            Controls.Add(lstvNo3);
            Controls.Add(label10);
            Controls.Add(lstvNo2);
            Controls.Add(btnGuncelle);
            Controls.Add(btnGetir);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(txtID);
            Controls.Add(btnEkle);
            Controls.Add(listView1);
            Controls.Add(dtpTarih);
            Controls.Add(label11);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIndirim);
            Controls.Add(txtFiyat);
            Controls.Add(txtSanatci);
            Controls.Add(txtAlbümAdi);
            Name = "btnRaporlar";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlbümAdi;
        private Label label1;
        private TextBox txtSanatci;
        private Label label2;
        private TextBox txtFiyat;
        private Label label3;
        private TextBox txtIndirim;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpTarih;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnEkle;
        private TextBox txtID;
        private Label label6;
        private Button btnDelete;
        private Button btnGetir;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnGuncelle;
        private Label label7;
        private ListView lstvNo5;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label label8;
        private ListView lstvNo4;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Label label9;
        private ListView lstvNo3;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Label label10;
        private ListView lstvNo2;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ComboBox cbxAktif;
        private Label label11;
        private Label label13;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader16;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_PlakDükkanı.Context;
using WFA_PlakDükkanı.Entities;
using WFA_PlakDükkanı.Enums;
using WFA_PlakDükkanı.Metotlar;
using WFA_PlakDükkanı.Repository;

namespace WFA_PlakDükkanı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        AppDbContext context;
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            cbxGender.DataSource = Enum.GetValues(typeof(Gender));


        }

        private void btnUyeOL_Click(object sender, EventArgs e)
        {
            UIMetotlar uim = new UIMetotlar();
            if (txtKullaniciAdi.Text != "" && txtAdi.Text != "" && txtSoyadi.Text != "" && txtSifre.Text != "" && cbxGender.SelectedIndex != -1 && dtpDogumTarihi.Value != DateTime.Now && uim.IsValidPassword(txtSifre.Text) && !(DateTime.Now.Year - dtpDogumTarihi.Value.Year < 18))
            {
                GenericRepository<Admin> grAdmin = new GenericRepository<Admin>();
                List<Admin> AdminList = grAdmin.GetAll();

                try
                {

                    using (context = new AppDbContext())
                    {

                        Admin admin = new Admin()
                        {
                            KullaniciAdi = txtKullaniciAdi.Text,
                            Sifre = txtSifre.Text,
                            ReSifre = txtSifreTekrari.Text,
                            Adi = txtAdi.Text,
                            Soyadi = txtSoyadi.Text,
                            Gender = cbxGender.SelectedItem.ToString(),
                            DogumTarihi = dtpDogumTarihi.Value,
                            AddedDate = DateTime.Now,
                            IsActive = "true",


                        };

                        grAdmin.RepUpdate(admin);
                        MessageBox.Show("Üyelik Başarılı");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtSifreTekrari.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
                txtSifreTekrari.PasswordChar = '*';
            }
        }

        private void btnGirisDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }
    }
}

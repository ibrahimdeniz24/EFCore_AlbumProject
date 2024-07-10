using WFA_PlakDükkanı.Context;
using WFA_PlakDükkanı.Metotlar;

namespace WFA_PlakDükkanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UIMetotlar uim;
        AppDbContext context;
        Form3 form3 = new Form3();
        btnRaporlar form2 = new btnRaporlar();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            uim = new UIMetotlar();

            if (txtSifre.Text == txtSifreTekrari.Text)
            {
                if (uim.GirisKontrolu(this, form2, txtKulllaciAdi, txtSifre))
                {
                    MessageBox.Show("Giriş başarılı");
                }
                else
                    MessageBox.Show("Email ve ya şifre hatalı");

            }
            else
            {
                MessageBox.Show("Şifre ve Şifre Tekrarı aynı değil. Lütfen Kontrol Ediniz");
            }



        }

        private void btnUyeOL_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }

        private void chbSifreGor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifreGor.Checked)
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
    }
}

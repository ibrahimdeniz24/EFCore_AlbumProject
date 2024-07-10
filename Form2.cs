using Microsoft.EntityFrameworkCore;
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
    public partial class btnRaporlar : Form
    {
        public btnRaporlar()
        {
            InitializeComponent();
        }


        AppDbContext context;
        GenericRepository<Album> grAlbum = new GenericRepository<
                    Album>();
        Album album;
        UIMetotlar uim = new UIMetotlar();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            lstvNo2.Items.Clear();
            lstvNo3.Items.Clear();
            lstvNo4.Items.Clear();
            lstvNo5.Items.Clear();

            if (txtAlbümAdi.Text != "" && txtSanatci.Text != "" && txtFiyat.Text != "")
            {

                try
                {
                    using (context = new AppDbContext())
                    {

                        Album album = new Album()
                        {
                            AlbumAdi = txtAlbümAdi.Text,
                            Sanatci = txtSanatci.Text,
                            Fiyati = Convert.ToDecimal(txtFiyat.Text),
                            IndirimOranı = Convert.ToSByte(txtIndirim.Text),
                            CikisTarihi = dtpTarih.Value,
                        };
                        grAlbum.RepAdd(album);
                        MessageBox.Show("Ekleme Başarılı");

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    uim.AlbumleriListele(listView1);
                    uim.EnSonEklenen10Albüm(lstvNo5);
                    uim.InidirimdekiAlbumler(lstvNo4);
                    uim.SatisiDurmusAlbümler(lstvNo2);
                    uim.SatisiDevamEdenAlbümler(lstvNo3);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            lstvNo2.Items.Clear();
            lstvNo3.Items.Clear();
            lstvNo4.Items.Clear();
            lstvNo5.Items.Clear();
            using (context = new AppDbContext())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtID.Text))
                    {
                        MessageBox.Show("Lütfen Bir ID Giriniz");
                    }
                    else
                    {
                        album = context.Albums.FirstOrDefault(x => x.ID == Convert.ToInt32(txtID.Text));
                        context.Albums.Remove(album);
                        context.SaveChanges();

                        MessageBox.Show("Album Başarı ile silnmiştir");
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Album Silinemedi Tekrar Deneyiniz");
                }
                finally
                {

                    uim.AlbumleriListele(listView1);
                    uim.EnSonEklenen10Albüm(lstvNo5);
                    uim.InidirimdekiAlbumler(lstvNo4);
                    uim.SatisiDurmusAlbümler(lstvNo2);
                    uim.SatisiDevamEdenAlbümler(lstvNo3);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uim.AlbumleriListele(listView1);
            cbxAktif.DataSource = Enum.GetValues(typeof(IsActive));

            uim.EnSonEklenen10Albüm(lstvNo5);
            uim.InidirimdekiAlbumler(lstvNo4);
            uim.SatisiDurmusAlbümler(lstvNo2);
            uim.SatisiDevamEdenAlbümler(lstvNo3);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            using (context = new AppDbContext())
            {

                album = context.Albums.FirstOrDefault(x => x.ID == Convert.ToInt32(txtID.Text));

                txtID.Text = Convert.ToString(album.ID);
                txtAlbümAdi.Text = album.AlbumAdi;
                txtSanatci.Text = album.Sanatci;
                dtpTarih.Value = album.CikisTarihi;
                txtFiyat.Text = Convert.ToString(album.Fiyati);
                txtIndirim.Text = Convert.ToString(album.IndirimOranı);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            lstvNo2.Items.Clear();
            lstvNo3.Items.Clear();
            lstvNo4.Items.Clear();
            lstvNo5.Items.Clear();
            using (var context = new AppDbContext())
            {
                try
                {

                    var album = context.Albums.FirstOrDefault(x => x.ID == Convert.ToInt32(txtID.Text));
                    if (album != null)
                    {
                        album.AlbumAdi = txtAlbümAdi.Text;
                        album.Sanatci = txtSanatci.Text;
                        album.CikisTarihi = dtpTarih.Value;
                        album.Fiyati = Convert.ToDecimal(txtFiyat.Text);
                        album.IndirimOranı = Convert.ToSByte(txtIndirim.Text);
                        album.IsActive = (IsActive)cbxAktif.SelectedItem;
                        context.Albums.Update(album);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Albüm bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    uim.AlbumleriListele(listView1);
                    uim.EnSonEklenen10Albüm(lstvNo5);
                    uim.InidirimdekiAlbumler(lstvNo4);
                    uim.SatisiDurmusAlbümler(lstvNo2);
                    uim.SatisiDevamEdenAlbümler(lstvNo3);


                }
            }
        }


    }
}

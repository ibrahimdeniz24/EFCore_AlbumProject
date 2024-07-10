using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WFA_PlakDükkanı.Context;
using WFA_PlakDükkanı.Entities;
using WFA_PlakDükkanı.Repository;

namespace WFA_PlakDükkanı.Metotlar
{

    public class UIMetotlar
    {

        public bool IsValidPassword(string password)
        {

            try
            {
                string pattern = @"^(?=.*[A-Z].*[A-Z])(?=.*[a-z].*[a-z].*[a-z])(?=.*[!@#$%^&*()_+{}|:<>?~-].*[!@#$%^&*()_+{}|:<>?~-])[A-Za-z\d!@#$%^&*()_+{}|:<>?~-]{8,}$";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(password))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Şifre en az 8 karakter olmalı 2 büyük 3 küçük harf içermeli en az 2 numara ve özel karakter içermeli.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void AlbumleriListele(ListView listview1)
        {
            listview1.Items.Clear();

            AppDbContext context = new AppDbContext();
            List<Album> albums = context.Albums.ToList();

            foreach (Album album in albums)
            {
                ListViewItem list = new ListViewItem(album.ID.ToString());
                list.SubItems.Add(album.AlbumAdi.ToString());
                list.SubItems.Add(album.Sanatci.ToString());
                list.SubItems.Add(album.CikisTarihi.ToString());
                list.SubItems.Add(album.IsActive.ToString());
                list.SubItems.Add(album.Fiyati.ToString());
                list.SubItems.Add(album.IndirimOranı.ToString());

                listview1.Items.Add(list);
            }

        }

        public bool GirisKontrolu(Form mevcutForm, Form acılacakForm, TextBox kullaniciAdi, TextBox sifre)
        {
            GenericRepository<Admin> grAdmin = new GenericRepository<Admin>();
            try
            {
                List<Admin> AdminList = grAdmin.GetAll();

                foreach (Admin ad in AdminList)
                {
                    if (ad.KullaniciAdi == kullaniciAdi.Text && ad.Sifre == sifre.Text)
                    {
                        acılacakForm.Owner = mevcutForm;
                        acılacakForm.Show();
                        mevcutForm.Hide();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void SatisiDurmusAlbümler(ListView listview)
        {
            using (var context = new AppDbContext())
            {

                var where2 = context.Albums.Where(p => p.IsActive == Enums.IsActive.False);
                listview.Items.Clear();

                foreach (var item in where2)
                {
                    ListViewItem list = new ListViewItem(item.ID.ToString());
                    list.SubItems.Add(item.AlbumAdi.ToString());
                    list.SubItems.Add(item.Sanatci.ToString());

                    listview.Items.Add(list);
                }
            }


        }

        public void SatisiDevamEdenAlbümler(ListView listview)
        {
            using (var context = new AppDbContext())
            {

                var where2 = context.Albums.Where(p => p.IsActive == Enums.IsActive.True);
                listview.Items.Clear();

                foreach (var item in where2)
                {
                    ListViewItem list = new ListViewItem(item.ID.ToString());
                    list.SubItems.Add(item.AlbumAdi.ToString());
                    list.SubItems.Add(item.Sanatci.ToString());
                    listview.Items.Add(list);
                }

            }
        }

        public void EnSonEklenen10Albüm(ListView listview)
        {
            using (var context = new AppDbContext())

            {
                var where2 = context.Albums.OrderByDescending(x => x.CikisTarihi).Take(10).ToList();

                listview.Items.Clear();

                foreach (var item in where2)
                {
                    ListViewItem list = new ListViewItem(item.ID.ToString());
                    list.SubItems.Add(item.AlbumAdi.ToString());
                    list.SubItems.Add(item.Sanatci.ToString());
                    listview.Items.Add(list);
                }

            }

        }

        public void InidirimdekiAlbumler(ListView listview)
        {
            using (var context = new AppDbContext())
            {
                var indAlbum = context.Albums.Where(x => x.IndirimOranı > 0).OrderByDescending(x => x.IndirimOranı).Select(x => new { x.ID, x.AlbumAdi, x.Sanatci }).ToList();

                listview.Items.Clear();


                foreach (var item in indAlbum)
                {
                    ListViewItem list = new ListViewItem(item.ID.ToString());
                    list.SubItems.Add(item.AlbumAdi.ToString());
                    list.SubItems.Add(item.Sanatci.ToString());
                    listview.Items.Add(list);
                }

            }


        }
        public string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }








    }
}

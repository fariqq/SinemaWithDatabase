using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjSinemaWithDatabase.Entity;

namespace prjSinemaWithDatabase
{
    public partial class FilmEditScreen : Form
    {
        LoginScreen loginScreen;
        Gorevli gorevli;
        public FilmEditScreen(Gorevli gorevli,LoginScreen loginScreen)
        {
            this.gorevli = gorevli;
            this.loginScreen = loginScreen;
            InitializeComponent();
        }
        Context context = new Context();
        private void FilmEditScreen_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Hoşgeldin\n" + gorevli.Ad;
            kategoriEklePanel.Visible = false;
            KategorileriYukle();
            FilmleriYukle();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            kategoriEklePanel.Visible = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            kategoriEklePanel.Visible = false;
        }

        private void btnKategoriKayıt_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text!="")
            {
                Kategori kategori = new Kategori();
                kategori.Ad = txtKategoriAd.Text;
                context.Kategoris.Add(kategori);
                context.SaveChanges();
                KategorileriYukle();
                MessageBox.Show("Kategori başarıyla eklendi!");
                txtKategoriAd.Text = "";
            }
            else
            {
                MessageBox.Show("Kategori adı boş bırakılmamalı!");
            }
        }
        private void KategorileriYukle()
        {
            Kategori[] kategoriler = context.Kategoris.ToArray();
            cbKategoriler.Items.Clear();
            foreach (Kategori kategori in kategoriler)
            {
                cbKategoriler.Items.Add(kategori.Ad);
            }
        }
        private void FilmleriYukle()
        {
            Film[] filmler = context.Films.ToArray();
            cbFilmler.Items.Clear();
            foreach (Film film in filmler)
            {
                cbFilmler.Items.Add(film.Ad);
            }
        }
        private void btnPosterSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen bir resim seçiniz";
            openFileDialog1.FileName = "Dosya Seç";
            openFileDialog1.Filter = "jpg dosyaları (*.jpg)|*.jpg|png dosyaları (*.png)|*.png|jpeg dosyaları (*.jpeg)|*.jpeg";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtResimYolu.Text = openFileDialog1.FileName;
            }
        }
        private void btnYeniFilmEkle_Click(object sender, EventArgs e)
        {
            if (txtFilmAd.Text != "" && cbKategoriler.Text != "" && txtFilmAciklama.Text != "" && txtFilmSuresi.Text != "" && txtResimYolu.Text != "")
            {
                Film film = new Film();
                film.Ad = txtFilmAd.Text;
                string kategoriAd = cbKategoriler.SelectedItem.ToString();
                film.Kategori = context.Kategoris.FirstOrDefault(p => p.Ad == kategoriAd);
                film.FilmAciklama = txtFilmAciklama.Text;
                film.FilmUzunlugu = Convert.ToInt32(txtFilmSuresi.Text);
                film.ResimYolu = txtResimYolu.Text;
                context.Films.Add(film);
                context.SaveChanges();
                pbPoster.ImageLocation = txtResimYolu.Text;
                FilmleriYukle();
                AlanlariTemizle();
                MessageBox.Show("Film başarılı bir şekilde kaydedildi!", "Başarılı");
            }
            else
            {
                MessageBox.Show("Boş alan bırakılmamalı!", "Uyarı!");
            }
        }
        private void cbFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filmAdi = cbFilmler.SelectedItem.ToString();
            var film = context.Films.FirstOrDefault(p => p.Ad == filmAdi);
            txtFilmID.Text = film.Id.ToString();
            txtFilmAd.Text = film.Ad;
            cbKategoriler.Text = film.Kategori.Ad;
            txtFilmAciklama.Text = film.FilmAciklama;
            txtFilmSuresi.Text = film.FilmUzunlugu.ToString();
            txtResimYolu.Text = film.ResimYolu;
            pbPoster.ImageLocation = film.ResimYolu;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFilmID.Text != "")
            {
                int id = Convert.ToInt32(txtFilmID.Text);
                var film = context.Films.Find(id);
                film.Ad = txtFilmAd.Text;
                string kategoriAd = cbKategoriler.SelectedItem.ToString();
                film.Kategori = context.Kategoris.FirstOrDefault(p => p.Ad == kategoriAd);
                film.FilmAciklama = txtFilmAciklama.Text;
                film.FilmUzunlugu = Convert.ToInt32(txtFilmSuresi.Text);
                film.ResimYolu = txtResimYolu.Text;
                context.SaveChanges();
                MessageBox.Show("Film güncellenmiştir!","Başarılı!");
                AlanlariTemizle();
            }
            else
            {
                MessageBox.Show("Seçili bir film yok!");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtFilmID.Text!="")
            {
                int id = Convert.ToInt32(txtFilmID.Text);
                var film = context.Films.Find(id);
                context.Films.Remove(film);
                context.SaveChanges();
                FilmleriYukle();
                AlanlariTemizle();
                MessageBox.Show("Silme işlemi başarıyla gerçekleşti!","Silindi!");
            }
            else
            {
                MessageBox.Show("Seçili bir film yok!");
            }
        }
        private void AlanlariTemizle()
        {
            txtFilmID.Text = "";
            txtFilmAd.Text = "";
            txtFilmAciklama.Text = "";
            txtFilmSuresi.Text = "";
            txtResimYolu.Text = "";
            pbPoster.ImageLocation = "FilmEkle.png";
            cbFilmler.Text = "";
            cbKategoriler.Text = "";
        }

        private void btnLoginScreen_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScreen.ShowLoginScreen();
        }
    }
}

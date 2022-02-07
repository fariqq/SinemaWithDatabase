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
    public partial class FilmScreen : Form
    {
        LoginScreen loginScreen;
        Musteri musteri;
        public FilmScreen(Musteri musteri,LoginScreen loginScreen)
        {
            this.loginScreen = loginScreen;
            this.musteri = musteri;
            InitializeComponent();
        }
        Context context = new Context();
        private void cbFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = cbFilmler.SelectedItem.ToString();
            var film = context.Films.FirstOrDefault(p => p.Ad == ad);
            lblFilmAdi.Text = film.Ad;
            lblFilmKategorisi.Text = film.Kategori.Ad;
            lblFilmAciklamasi.Text = film.FilmAciklama;
            lblFilmSuresi.Text = film.FilmUzunlugu + " Dakika";
            pbPoster.ImageLocation = film.ResimYolu;
        }
        private void FilmleriYukle()
        {
            Film[] filmler = context.Films.ToArray();
            foreach (Film film in filmler)
            {
                cbFilmler.Items.Add(film.Ad);
            }
        }
        private void FilmScreen_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Hoşgeldin\n"+musteri.Ad;
            FilmleriYukle();
        }

        private void btnLoginScreen_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScreen.ShowLoginScreen();
        }
    }
}
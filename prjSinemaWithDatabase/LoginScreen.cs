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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Context c = new Context();
            // c.Database.Create();
        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            GorevliGirisPanel.Visible = false;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            GorevliGirisPanel.Visible = true;
        }
        private void btnGeri2_Click(object sender, EventArgs e)
        {
            MusteriGirisPanel.Visible = true;
        }
        private void btnGorevliKayitOl_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtKayitKullaniciAdi.Text != "" && txtKayitSifre.Text != "")
            {
                Gorevli gorevli = new Gorevli();
                gorevli.Ad = txtAd.Text;
                gorevli.Soyad = txtSoyad.Text;
                gorevli.KullaniciAdi = txtKayitKullaniciAdi.Text;
                gorevli.Sifre = txtKayitSifre.Text;
                context.Gorevlis.Add(gorevli);
                context.SaveChanges();
                MessageBox.Show("Başarılı bir şekilde kayıt olundu.", "Başarılı!");
                GorevliGirisPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılmamalı!", "Uyarı!");
            }
        }
        private void btnMusteriUyeOl_Click(object sender, EventArgs e)
        {
            MusteriGirisPanel.Visible = false;
        }
        private void btnGorevliGirisYap_Click(object sender, EventArgs e)
        {
            if (txtGorevliGirisKullaniciAdi.Text != "" && txtGorevliGirisSifre.Text != "" && txtGorevliGirisKullaniciAdi.Text != "Kullanıcı Adı" && txtGorevliGirisSifre.Text != "Şifre")
            {
                string kullaniciAdi = txtGorevliGirisKullaniciAdi.Text;
                string sifre = txtGorevliGirisSifre.Text;
                var gorevli = context.Gorevlis.FirstOrDefault(p => p.KullaniciAdi == kullaniciAdi & p.Sifre == sifre);
                if (gorevli != null)
                {
                    FilmEditScreen filmEditScreen = new FilmEditScreen(gorevli,this);
                    this.Hide();
                    filmEditScreen.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılmamalı!", "Uyarı!");
            }
        }

        private void btnMusteriÜyetOl_Click(object sender, EventArgs e)
        {
            if (txtMusteriKayitAd.Text != "" && txtMusteriKayitSoyad.Text != "" && txtMusteriKayitKullaniciAdi.Text != "" && txtMusteriKayitSifre.Text != "")
            {
                Musteri musteri = new Musteri();
                musteri.Ad = txtMusteriKayitAd.Text;
                musteri.Soyad = txtMusteriKayitSoyad.Text;
                musteri.KullaniciAdi = txtMusteriKayitKullaniciAdi.Text;
                musteri.Sifre = txtMusteriKayitSifre.Text;
                context.Musteris.Add(musteri);
                context.SaveChanges();
                MessageBox.Show("Başarılı bir şekilde kayıt olundu.", "Başarılı!");
                MusteriGirisPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılmamalı!", "Uyarı!");
            }
        }

        private void btnMusteriGirisYap_Click(object sender, EventArgs e)
        {
            if (txtMusteriGirisKullaniciAdi.Text != "" && txtMusteriGirisSifre.Text != ""&& txtMusteriGirisKullaniciAdi.Text != "Kullanıcı Adı" && txtMusteriGirisSifre.Text != "Şifre")
            {
                string kullaniciAdi = txtMusteriGirisKullaniciAdi.Text;
                string sifre = txtMusteriGirisSifre.Text;
                var musteri = context.Musteris.FirstOrDefault(p => p.KullaniciAdi == kullaniciAdi & p.Sifre == sifre);
                if (musteri != null)
                {
                    FilmScreen filmScreen = new FilmScreen(musteri,this);
                    this.Hide();
                    filmScreen.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış!", "Uyarı!");
                }
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılmamalı!", "Uyarı");
            }
        }
        /*---------------------------------TextBox Hint---------------------------------*/
        private void txtAd_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "Ad")
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = "Ad";
                textbox.ForeColor = Color.DimGray;
            }
        }

        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "Soyad")
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }

        private void txtSoyad_Leave(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = "Soyad";
                textbox.ForeColor = Color.DimGray;
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "Kullanıcı Adı")
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = "Kullanıcı Adı";
                textbox.ForeColor = Color.DimGray;
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "Şifre")
            {
                textbox.Text = "";
                textbox.ForeColor = Color.Black;
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox.Text == "")
            {
                textbox.Text = "Şifre";
                textbox.ForeColor = Color.DimGray;
            }
        }
        /*---------------------------------TextBox Hint---------------------------------*/

        public void ShowLoginScreen()
        {
            this.Show();
            txtGorevliGirisKullaniciAdi.Text = "Kullanıcı Adı";
            txtGorevliGirisSifre.Text = "Şifre";
            txtMusteriGirisKullaniciAdi.Text = "Kullanıcı Adı";
            txtMusteriGirisSifre.Text = "Şifre";
            
        }
    }
}

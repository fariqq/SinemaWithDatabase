
namespace prjSinemaWithDatabase
{
    partial class FilmEditScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmEditScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginScreen = new System.Windows.Forms.Button();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.btnYeniFilmEkle = new System.Windows.Forms.Button();
            this.cbFilmler = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.txtFilmAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmSuresi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPosterSec = new System.Windows.Forms.Button();
            this.txtResimYolu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.kategoriEklePanel = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKategoriKayıt = new System.Windows.Forms.Button();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilmID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.kategoriEklePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoginScreen);
            this.panel1.Controls.Add(this.lblHosgeldin);
            this.panel1.Controls.Add(this.pbPoster);
            this.panel1.Controls.Add(this.btnYeniFilmEkle);
            this.panel1.Controls.Add(this.cbFilmler);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 519);
            this.panel1.TabIndex = 0;
            // 
            // btnLoginScreen
            // 
            this.btnLoginScreen.BackColor = System.Drawing.Color.Black;
            this.btnLoginScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginScreen.BackgroundImage")));
            this.btnLoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginScreen.FlatAppearance.BorderSize = 0;
            this.btnLoginScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginScreen.Location = new System.Drawing.Point(3, 7);
            this.btnLoginScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginScreen.Name = "btnLoginScreen";
            this.btnLoginScreen.Size = new System.Drawing.Size(36, 33);
            this.btnLoginScreen.TabIndex = 37;
            this.btnLoginScreen.UseVisualStyleBackColor = false;
            this.btnLoginScreen.Click += new System.EventHandler(this.btnLoginScreen_Click);
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.ForeColor = System.Drawing.Color.Silver;
            this.lblHosgeldin.Location = new System.Drawing.Point(84, 10);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(91, 23);
            this.lblHosgeldin.TabIndex = 39;
            this.lblHosgeldin.Text = "Hosgeldin";
            this.lblHosgeldin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPoster
            // 
            this.pbPoster.BackColor = System.Drawing.Color.Black;
            this.pbPoster.Image = ((System.Drawing.Image)(resources.GetObject("pbPoster.Image")));
            this.pbPoster.Location = new System.Drawing.Point(29, 73);
            this.pbPoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(205, 261);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 1;
            this.pbPoster.TabStop = false;
            // 
            // btnYeniFilmEkle
            // 
            this.btnYeniFilmEkle.AutoSize = true;
            this.btnYeniFilmEkle.BackColor = System.Drawing.Color.Silver;
            this.btnYeniFilmEkle.Location = new System.Drawing.Point(78, 447);
            this.btnYeniFilmEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniFilmEkle.Name = "btnYeniFilmEkle";
            this.btnYeniFilmEkle.Size = new System.Drawing.Size(109, 30);
            this.btnYeniFilmEkle.TabIndex = 3;
            this.btnYeniFilmEkle.Text = "Yeni Film Ekle";
            this.btnYeniFilmEkle.UseVisualStyleBackColor = false;
            this.btnYeniFilmEkle.Click += new System.EventHandler(this.btnYeniFilmEkle_Click);
            // 
            // cbFilmler
            // 
            this.cbFilmler.BackColor = System.Drawing.Color.Silver;
            this.cbFilmler.FormattingEnabled = true;
            this.cbFilmler.Location = new System.Drawing.Point(29, 338);
            this.cbFilmler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilmler.Name = "cbFilmler";
            this.cbFilmler.Size = new System.Drawing.Size(205, 24);
            this.cbFilmler.TabIndex = 0;
            this.cbFilmler.SelectedIndexChanged += new System.EventHandler(this.cbFilmler_SelectedIndexChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = true;
            this.btnGuncelle.BackColor = System.Drawing.Color.Silver;
            this.btnGuncelle.Location = new System.Drawing.Point(138, 367);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(96, 30);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = true;
            this.btnSil.BackColor = System.Drawing.Color.Silver;
            this.btnSil.Location = new System.Drawing.Point(29, 367);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 30);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.BackColor = System.Drawing.Color.Silver;
            this.txtFilmAd.Location = new System.Drawing.Point(402, 139);
            this.txtFilmAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(501, 22);
            this.txtFilmAd.TabIndex = 19;
            // 
            // txtFilmAciklama
            // 
            this.txtFilmAciklama.BackColor = System.Drawing.Color.Silver;
            this.txtFilmAciklama.Location = new System.Drawing.Point(402, 199);
            this.txtFilmAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilmAciklama.Multiline = true;
            this.txtFilmAciklama.Name = "txtFilmAciklama";
            this.txtFilmAciklama.Size = new System.Drawing.Size(501, 147);
            this.txtFilmAciklama.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(329, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(278, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Film Açıklaması";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(311, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Film Süresi";
            // 
            // txtFilmSuresi
            // 
            this.txtFilmSuresi.BackColor = System.Drawing.Color.Silver;
            this.txtFilmSuresi.Location = new System.Drawing.Point(402, 350);
            this.txtFilmSuresi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilmSuresi.Name = "txtFilmSuresi";
            this.txtFilmSuresi.Size = new System.Drawing.Size(88, 22);
            this.txtFilmSuresi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(342, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Poster";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPosterSec
            // 
            this.btnPosterSec.AutoSize = true;
            this.btnPosterSec.BackColor = System.Drawing.Color.Silver;
            this.btnPosterSec.Location = new System.Drawing.Point(808, 372);
            this.btnPosterSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPosterSec.Name = "btnPosterSec";
            this.btnPosterSec.Size = new System.Drawing.Size(95, 30);
            this.btnPosterSec.TabIndex = 27;
            this.btnPosterSec.Text = "Poster Seç..";
            this.btnPosterSec.UseVisualStyleBackColor = false;
            this.btnPosterSec.Click += new System.EventHandler(this.btnPosterSec_Click);
            // 
            // txtResimYolu
            // 
            this.txtResimYolu.BackColor = System.Drawing.Color.DarkGray;
            this.txtResimYolu.Enabled = false;
            this.txtResimYolu.Location = new System.Drawing.Point(402, 376);
            this.txtResimYolu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResimYolu.Name = "txtResimYolu";
            this.txtResimYolu.Size = new System.Drawing.Size(403, 22);
            this.txtResimYolu.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(493, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Dakika";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(282, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Film Kategorisi";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.BackColor = System.Drawing.Color.Silver;
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(402, 169);
            this.cbKategoriler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(382, 24);
            this.cbKategoriler.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(541, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "Film Özellikleri";
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.AutoSize = true;
            this.btnKategoriEkle.BackColor = System.Drawing.Color.Silver;
            this.btnKategoriEkle.Location = new System.Drawing.Point(786, 165);
            this.btnKategoriEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(113, 30);
            this.btnKategoriEkle.TabIndex = 34;
            this.btnKategoriEkle.Text = "Kategori Ekle..";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // kategoriEklePanel
            // 
            this.kategoriEklePanel.Controls.Add(this.btnGeri);
            this.kategoriEklePanel.Controls.Add(this.label9);
            this.kategoriEklePanel.Controls.Add(this.btnKategoriKayıt);
            this.kategoriEklePanel.Controls.Add(this.txtKategoriAd);
            this.kategoriEklePanel.Location = new System.Drawing.Point(271, 101);
            this.kategoriEklePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kategoriEklePanel.Name = "kategoriEklePanel";
            this.kategoriEklePanel.Size = new System.Drawing.Size(696, 323);
            this.kategoriEklePanel.TabIndex = 4;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DimGray;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Location = new System.Drawing.Point(325, 156);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(36, 33);
            this.btnGeri.TabIndex = 24;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(153, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kategori Adı";
            // 
            // btnKategoriKayıt
            // 
            this.btnKategoriKayıt.AutoSize = true;
            this.btnKategoriKayıt.Location = new System.Drawing.Point(430, 126);
            this.btnKategoriKayıt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKategoriKayıt.Name = "btnKategoriKayıt";
            this.btnKategoriKayıt.Size = new System.Drawing.Size(118, 30);
            this.btnKategoriKayıt.TabIndex = 2;
            this.btnKategoriKayıt.Text = "Kategoriyi Ekle";
            this.btnKategoriKayıt.UseVisualStyleBackColor = true;
            this.btnKategoriKayıt.Click += new System.EventHandler(this.btnKategoriKayıt_Click);
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(256, 130);
            this.txtKategoriAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(168, 22);
            this.txtKategoriAd.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(337, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Film ID";
            // 
            // txtFilmID
            // 
            this.txtFilmID.BackColor = System.Drawing.Color.DarkGray;
            this.txtFilmID.Enabled = false;
            this.txtFilmID.Location = new System.Drawing.Point(402, 113);
            this.txtFilmID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilmID.Name = "txtFilmID";
            this.txtFilmID.Size = new System.Drawing.Size(88, 22);
            this.txtFilmID.TabIndex = 35;
            // 
            // FilmEditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(979, 519);
            this.Controls.Add(this.kategoriEklePanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFilmID);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbKategoriler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResimYolu);
            this.Controls.Add(this.btnPosterSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilmSuresi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.txtFilmAciklama);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FilmEditScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmleri Düzenleme Paneli";
            this.Load += new System.EventHandler(this.FilmEditScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.kategoriEklePanel.ResumeLayout(false);
            this.kategoriEklePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFilmler;
        private System.Windows.Forms.Button btnYeniFilmEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.TextBox txtFilmAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmSuresi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPosterSec;
        private System.Windows.Forms.TextBox txtResimYolu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Panel kategoriEklePanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKategoriKayıt;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFilmID;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnLoginScreen;
    }
}

namespace prjSinemaWithDatabase
{
    partial class FilmScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginScreen = new System.Windows.Forms.Button();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.cbFilmler = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.lblFilmKategorisi = new System.Windows.Forms.Label();
            this.lblFilmAciklamasi = new System.Windows.Forms.Label();
            this.lblFilmSuresi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoginScreen);
            this.panel1.Controls.Add(this.lblHosgeldin);
            this.panel1.Controls.Add(this.pbPoster);
            this.panel1.Controls.Add(this.cbFilmler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 519);
            this.panel1.TabIndex = 1;
            // 
            // btnLoginScreen
            // 
            this.btnLoginScreen.BackColor = System.Drawing.Color.Black;
            this.btnLoginScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginScreen.BackgroundImage")));
            this.btnLoginScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginScreen.FlatAppearance.BorderSize = 0;
            this.btnLoginScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginScreen.Location = new System.Drawing.Point(3, 8);
            this.btnLoginScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoginScreen.Name = "btnLoginScreen";
            this.btnLoginScreen.Size = new System.Drawing.Size(36, 33);
            this.btnLoginScreen.TabIndex = 52;
            this.btnLoginScreen.UseVisualStyleBackColor = false;
            this.btnLoginScreen.Click += new System.EventHandler(this.btnLoginScreen_Click);
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.ForeColor = System.Drawing.Color.Silver;
            this.lblHosgeldin.Location = new System.Drawing.Point(82, 8);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(91, 23);
            this.lblHosgeldin.TabIndex = 38;
            this.lblHosgeldin.Text = "Hosgeldin";
            this.lblHosgeldin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPoster
            // 
            this.pbPoster.BackColor = System.Drawing.Color.Black;
            this.pbPoster.Image = ((System.Drawing.Image)(resources.GetObject("pbPoster.Image")));
            this.pbPoster.Location = new System.Drawing.Point(27, 65);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(205, 261);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPoster.TabIndex = 1;
            this.pbPoster.TabStop = false;
            // 
            // cbFilmler
            // 
            this.cbFilmler.BackColor = System.Drawing.Color.Silver;
            this.cbFilmler.FormattingEnabled = true;
            this.cbFilmler.Location = new System.Drawing.Point(27, 332);
            this.cbFilmler.Name = "cbFilmler";
            this.cbFilmler.Size = new System.Drawing.Size(205, 24);
            this.cbFilmler.TabIndex = 0;
            this.cbFilmler.SelectedIndexChanged += new System.EventHandler(this.cbFilmler_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(532, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 47;
            this.label7.Text = "Film Özellikleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(281, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Film Kategorisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(310, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Film Süresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(277, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Film Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(328, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Film Adı";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Location = new System.Drawing.Point(401, 100);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(20, 17);
            this.lblFilmAdi.TabIndex = 48;
            this.lblFilmAdi.Text = "...";
            // 
            // lblFilmKategorisi
            // 
            this.lblFilmKategorisi.AutoSize = true;
            this.lblFilmKategorisi.Location = new System.Drawing.Point(401, 135);
            this.lblFilmKategorisi.Name = "lblFilmKategorisi";
            this.lblFilmKategorisi.Size = new System.Drawing.Size(20, 17);
            this.lblFilmKategorisi.TabIndex = 49;
            this.lblFilmKategorisi.Text = "...";
            // 
            // lblFilmAciklamasi
            // 
            this.lblFilmAciklamasi.Location = new System.Drawing.Point(401, 170);
            this.lblFilmAciklamasi.Name = "lblFilmAciklamasi";
            this.lblFilmAciklamasi.Size = new System.Drawing.Size(525, 168);
            this.lblFilmAciklamasi.TabIndex = 50;
            this.lblFilmAciklamasi.Text = "...";
            // 
            // lblFilmSuresi
            // 
            this.lblFilmSuresi.AutoSize = true;
            this.lblFilmSuresi.Location = new System.Drawing.Point(401, 359);
            this.lblFilmSuresi.Name = "lblFilmSuresi";
            this.lblFilmSuresi.Size = new System.Drawing.Size(20, 17);
            this.lblFilmSuresi.TabIndex = 51;
            this.lblFilmSuresi.Text = "...";
            // 
            // FilmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(979, 519);
            this.Controls.Add(this.lblFilmSuresi);
            this.Controls.Add(this.lblFilmAciklamasi);
            this.Controls.Add(this.lblFilmKategorisi);
            this.Controls.Add(this.lblFilmAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FilmScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film İzleme Paneli";
            this.Load += new System.EventHandler(this.FilmScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.ComboBox cbFilmler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Label lblFilmKategorisi;
        private System.Windows.Forms.Label lblFilmAciklamasi;
        private System.Windows.Forms.Label lblFilmSuresi;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnLoginScreen;
    }
}
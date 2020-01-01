namespace OgrenciSinav
{
    partial class GirisForm
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
            this.components = new System.ComponentModel.Container();
            this.mtbKullaniciAd = new System.Windows.Forms.MaskedTextBox();
            this.mtbParola = new System.Windows.Forms.MaskedTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnGiris = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCıkıs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbKullaniciAd
            // 
            this.mtbKullaniciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbKullaniciAd.Location = new System.Drawing.Point(84, 250);
            this.mtbKullaniciAd.Mask = "00000000000";
            this.mtbKullaniciAd.Name = "mtbKullaniciAd";
            this.mtbKullaniciAd.Size = new System.Drawing.Size(162, 34);
            this.mtbKullaniciAd.TabIndex = 0;
            // 
            // mtbParola
            // 
            this.mtbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbParola.Location = new System.Drawing.Point(83, 323);
            this.mtbParola.Mask = "00000000000";
            this.mtbParola.Name = "mtbParola";
            this.mtbParola.PasswordChar = '*';
            this.mtbParola.Size = new System.Drawing.Size(161, 34);
            this.mtbParola.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.ForeColor = System.Drawing.Color.White;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(80, 214);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(118, 24);
            this.lblKullanıcıAdı.TabIndex = 4;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(80, 287);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(73, 24);
            this.lblParola.TabIndex = 5;
            this.lblParola.Text = "Parola :";
            // 
            // btnGiris
            // 
            this.btnGiris.Active = false;
            this.btnGiris.Activecolor = System.Drawing.Color.Empty;
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.BorderRadius = 0;
            this.btnGiris.ButtonText = "GİRİŞ";
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiris.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiris.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.btnGiris.Iconimage_right = null;
            this.btnGiris.Iconimage_right_Selected = null;
            this.btnGiris.Iconimage_Selected = null;
            this.btnGiris.IconMarginLeft = 0;
            this.btnGiris.IconMarginRight = 0;
            this.btnGiris.IconRightVisible = true;
            this.btnGiris.IconRightZoom = 0D;
            this.btnGiris.IconVisible = true;
            this.btnGiris.IconZoom = 90D;
            this.btnGiris.IsTab = false;
            this.btnGiris.Location = new System.Drawing.Point(28, 379);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnGiris.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGiris.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiris.selected = false;
            this.btnGiris.Size = new System.Drawing.Size(130, 59);
            this.btnGiris.TabIndex = 34;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Textcolor = System.Drawing.Color.White;
            this.btnGiris.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Active = false;
            this.btnCıkıs.Activecolor = System.Drawing.Color.Empty;
            this.btnCıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnCıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCıkıs.BorderRadius = 0;
            this.btnCıkıs.ButtonText = "ÇIKIŞ";
            this.btnCıkıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCıkıs.DisabledColor = System.Drawing.Color.Gray;
            this.btnCıkıs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCıkıs.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.btnCıkıs.Iconimage_right = null;
            this.btnCıkıs.Iconimage_right_Selected = null;
            this.btnCıkıs.Iconimage_Selected = null;
            this.btnCıkıs.IconMarginLeft = 0;
            this.btnCıkıs.IconMarginRight = 0;
            this.btnCıkıs.IconRightVisible = true;
            this.btnCıkıs.IconRightZoom = 0D;
            this.btnCıkıs.IconVisible = true;
            this.btnCıkıs.IconZoom = 90D;
            this.btnCıkıs.IsTab = false;
            this.btnCıkıs.Location = new System.Drawing.Point(166, 379);
            this.btnCıkıs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnCıkıs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCıkıs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCıkıs.selected = false;
            this.btnCıkıs.Size = new System.Drawing.Size(131, 59);
            this.btnCıkıs.TabIndex = 35;
            this.btnCıkıs.Text = "ÇIKIŞ";
            this.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCıkıs.Textcolor = System.Drawing.Color.White;
            this.btnCıkıs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCıkıs.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OgrenciSinav.Properties.Resources.kisspng_user_profile_computer_icons_clip_art_portable_netw_pagar_tangsel_beranda_5c602815045751_7523865415498055890178;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 199);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(332, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.mtbParola);
            this.Controls.Add(this.mtbKullaniciAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisForm";
            this.Load += new System.EventHandler(this.GirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbKullaniciAd;
        private System.Windows.Forms.MaskedTextBox mtbParola;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private Bunifu.Framework.UI.BunifuFlatButton btnCıkıs;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace OgrenciSinav
{
    partial class OgrenciForm
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
            this.dgvOgrenci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtAdi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoyadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mtbTCKN1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mtbTCKN = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenci
            // 
            this.dgvOgrenci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenci.Location = new System.Drawing.Point(12, 293);
            this.dgvOgrenci.Name = "dgvOgrenci";
            this.dgvOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgrenci.Size = new System.Drawing.Size(1381, 409);
            this.dgvOgrenci.TabIndex = 0;
            this.dgvOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenci_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYADI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "TCKN :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "ÖĞRENCİ EKLE";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(463, 13);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(228, 59);
            this.bunifuFlatButton3.TabIndex = 35;
            this.bunifuFlatButton3.Text = "ÖĞRENCİ EKLE";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "ÖĞRENCİ GÜNCELLE";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(463, 83);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(228, 59);
            this.bunifuFlatButton1.TabIndex = 36;
            this.bunifuFlatButton1.Text = "ÖĞRENCİ GÜNCELLE";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "ÖĞRENCİ SİL";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(463, 157);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(228, 59);
            this.bunifuFlatButton2.TabIndex = 37;
            this.bunifuFlatButton2.Text = "ÖĞRENCİ SİL";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAdi.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAdi.ForeColor = System.Drawing.Color.White;
            this.txtAdi.HintForeColor = System.Drawing.Color.Empty;
            this.txtAdi.HintText = "";
            this.txtAdi.isPassword = false;
            this.txtAdi.LineFocusedColor = System.Drawing.Color.White;
            this.txtAdi.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtAdi.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtAdi.LineThickness = 3;
            this.txtAdi.Location = new System.Drawing.Point(115, 25);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.MaxLength = 32767;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(274, 31);
            this.txtAdi.TabIndex = 38;
            this.txtAdi.Text = "    ";
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSoyadi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSoyadi.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoyadi.ForeColor = System.Drawing.Color.White;
            this.txtSoyadi.HintForeColor = System.Drawing.Color.Empty;
            this.txtSoyadi.HintText = "";
            this.txtSoyadi.isPassword = false;
            this.txtSoyadi.LineFocusedColor = System.Drawing.Color.White;
            this.txtSoyadi.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtSoyadi.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSoyadi.LineThickness = 3;
            this.txtSoyadi.Location = new System.Drawing.Point(115, 76);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadi.MaxLength = 32767;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(274, 33);
            this.txtSoyadi.TabIndex = 39;
            this.txtSoyadi.Text = "    ";
            this.txtSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mtbTCKN1
            // 
            this.mtbTCKN1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mtbTCKN1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mtbTCKN1.BackColor = System.Drawing.Color.Green;
            this.mtbTCKN1.characterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mtbTCKN1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbTCKN1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mtbTCKN1.ForeColor = System.Drawing.Color.DarkRed;
            this.mtbTCKN1.HintForeColor = System.Drawing.Color.Empty;
            this.mtbTCKN1.HintText = "";
            this.mtbTCKN1.isPassword = false;
            this.mtbTCKN1.LineFocusedColor = System.Drawing.Color.White;
            this.mtbTCKN1.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.mtbTCKN1.LineMouseHoverColor = System.Drawing.Color.White;
            this.mtbTCKN1.LineThickness = 3;
            this.mtbTCKN1.Location = new System.Drawing.Point(115, 126);
            this.mtbTCKN1.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTCKN1.MaxLength = 32767;
            this.mtbTCKN1.Name = "mtbTCKN1";
            this.mtbTCKN1.Size = new System.Drawing.Size(274, 33);
            this.mtbTCKN1.TabIndex = 41;
            this.mtbTCKN1.Text = "    ";
            this.mtbTCKN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mtbTCKN
            // 
            this.mtbTCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbTCKN.Location = new System.Drawing.Point(115, 126);
            this.mtbTCKN.Mask = "00000000000";
            this.mtbTCKN.Name = "mtbTCKN";
            this.mtbTCKN.Size = new System.Drawing.Size(274, 30);
            this.mtbTCKN.TabIndex = 44;
            this.mtbTCKN.ValidatingType = typeof(int);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1405, 714);
            this.Controls.Add(this.mtbTCKN);
            this.Controls.Add(this.mtbTCKN1);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            this.Load += new System.EventHandler(this.OgrenciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoyadi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAdi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mtbTCKN1;
        private System.Windows.Forms.MaskedTextBox mtbTCKN;
    }
}
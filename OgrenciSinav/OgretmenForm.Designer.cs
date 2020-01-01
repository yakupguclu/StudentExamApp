namespace OgrenciSinav
{
    partial class OgretmenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenForm));
            this.dgvSorular = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.pbSikA = new System.Windows.Forms.PictureBox();
            this.pbSikB = new System.Windows.Forms.PictureBox();
            this.pbSikD = new System.Windows.Forms.PictureBox();
            this.pbSikC = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoruEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOgrenciEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCikis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlSoruEkle = new System.Windows.Forms.Panel();
            this.txtSoru = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtD = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtA = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCevap = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbKonu = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMetin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOgrenciDetay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlOgrenciDetay = new System.Windows.Forms.Panel();
            this.dgvOgrenciDetay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSeach = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikC)).BeginInit();
            this.pnlSoruEkle.SuspendLayout();
            this.pnlOgrenciDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciDetay)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSorular
            // 
            this.dgvSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorular.Location = new System.Drawing.Point(43, 336);
            this.dgvSorular.MultiSelect = false;
            this.dgvSorular.Name = "dgvSorular";
            this.dgvSorular.RowTemplate.Height = 24;
            this.dgvSorular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSorular.Size = new System.Drawing.Size(1155, 338);
            this.dgvSorular.TabIndex = 0;
            this.dgvSorular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSorular_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru Metini :";
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "Resim Seçiniz";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(688, 80);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(264, 158);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 11;
            this.pbResim.TabStop = false;
            // 
            // pbSikA
            // 
            this.pbSikA.Location = new System.Drawing.Point(43, 151);
            this.pbSikA.Name = "pbSikA";
            this.pbSikA.Size = new System.Drawing.Size(107, 70);
            this.pbSikA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikA.TabIndex = 16;
            this.pbSikA.TabStop = false;
            // 
            // pbSikB
            // 
            this.pbSikB.Location = new System.Drawing.Point(179, 151);
            this.pbSikB.Name = "pbSikB";
            this.pbSikB.Size = new System.Drawing.Size(107, 69);
            this.pbSikB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikB.TabIndex = 18;
            this.pbSikB.TabStop = false;
            // 
            // pbSikD
            // 
            this.pbSikD.Location = new System.Drawing.Point(463, 151);
            this.pbSikD.Name = "pbSikD";
            this.pbSikD.Size = new System.Drawing.Size(107, 70);
            this.pbSikD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikD.TabIndex = 22;
            this.pbSikD.TabStop = false;
            // 
            // pbSikC
            // 
            this.pbSikC.Location = new System.Drawing.Point(313, 152);
            this.pbSikC.Name = "pbSikC";
            this.pbSikC.Size = new System.Drawing.Size(107, 69);
            this.pbSikC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikC.TabIndex = 20;
            this.pbSikC.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1013, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "CEVAP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1008, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "KONU :";
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Active = false;
            this.btnSoruEkle.Activecolor = System.Drawing.Color.Empty;
            this.btnSoruEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSoruEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoruEkle.BorderRadius = 0;
            this.btnSoruEkle.ButtonText = "SORU EKLE";
            this.btnSoruEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnSoruEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSoruEkle.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.btnSoruEkle.Iconimage_right = null;
            this.btnSoruEkle.Iconimage_right_Selected = null;
            this.btnSoruEkle.Iconimage_Selected = null;
            this.btnSoruEkle.IconMarginLeft = 0;
            this.btnSoruEkle.IconMarginRight = 0;
            this.btnSoruEkle.IconRightVisible = true;
            this.btnSoruEkle.IconRightZoom = 0D;
            this.btnSoruEkle.IconVisible = true;
            this.btnSoruEkle.IconZoom = 90D;
            this.btnSoruEkle.IsTab = false;
            this.btnSoruEkle.Location = new System.Drawing.Point(1, 105);
            this.btnSoruEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSoruEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSoruEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSoruEkle.selected = false;
            this.btnSoruEkle.Size = new System.Drawing.Size(228, 59);
            this.btnSoruEkle.TabIndex = 33;
            this.btnSoruEkle.Text = "SORU EKLE";
            this.btnSoruEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoruEkle.Textcolor = System.Drawing.Color.White;
            this.btnSoruEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Active = false;
            this.btnOgrenciEkle.Activecolor = System.Drawing.Color.Empty;
            this.btnOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnOgrenciEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenciEkle.BorderRadius = 0;
            this.btnOgrenciEkle.ButtonText = "ÖĞRENCİ EKLE";
            this.btnOgrenciEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenciEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btnOgrenciEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOgrenciEkle.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.btnOgrenciEkle.Iconimage_right = null;
            this.btnOgrenciEkle.Iconimage_right_Selected = null;
            this.btnOgrenciEkle.Iconimage_Selected = null;
            this.btnOgrenciEkle.IconMarginLeft = 0;
            this.btnOgrenciEkle.IconMarginRight = 0;
            this.btnOgrenciEkle.IconRightVisible = true;
            this.btnOgrenciEkle.IconRightZoom = 0D;
            this.btnOgrenciEkle.IconVisible = true;
            this.btnOgrenciEkle.IconZoom = 90D;
            this.btnOgrenciEkle.IsTab = false;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(1, 172);
            this.btnOgrenciEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnOgrenciEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOgrenciEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOgrenciEkle.selected = false;
            this.btnOgrenciEkle.Size = new System.Drawing.Size(228, 59);
            this.btnOgrenciEkle.TabIndex = 34;
            this.btnOgrenciEkle.Text = "ÖĞRENCİ EKLE";
            this.btnOgrenciEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciEkle.Textcolor = System.Drawing.Color.White;
            this.btnOgrenciEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Active = false;
            this.btnCikis.Activecolor = System.Drawing.Color.Empty;
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.BorderRadius = 0;
            this.btnCikis.ButtonText = "ÇIKIŞ";
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.DisabledColor = System.Drawing.Color.Gray;
            this.btnCikis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCikis.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.btnCikis.Iconimage_right = null;
            this.btnCikis.Iconimage_right_Selected = null;
            this.btnCikis.Iconimage_Selected = null;
            this.btnCikis.IconMarginLeft = 0;
            this.btnCikis.IconMarginRight = 0;
            this.btnCikis.IconRightVisible = true;
            this.btnCikis.IconRightZoom = 0D;
            this.btnCikis.IconVisible = true;
            this.btnCikis.IconZoom = 90D;
            this.btnCikis.IsTab = false;
            this.btnCikis.Location = new System.Drawing.Point(1, 306);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnCikis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCikis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCikis.selected = false;
            this.btnCikis.Size = new System.Drawing.Size(228, 59);
            this.btnCikis.TabIndex = 35;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Textcolor = System.Drawing.Color.White;
            this.btnCikis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pnlSoruEkle
            // 
            this.pnlSoruEkle.Controls.Add(this.txtSoru);
            this.pnlSoruEkle.Controls.Add(this.txtD);
            this.pnlSoruEkle.Controls.Add(this.txtC);
            this.pnlSoruEkle.Controls.Add(this.txtB);
            this.pnlSoruEkle.Controls.Add(this.txtA);
            this.pnlSoruEkle.Controls.Add(this.bunifuFlatButton6);
            this.pnlSoruEkle.Controls.Add(this.bunifuFlatButton5);
            this.pnlSoruEkle.Controls.Add(this.bunifuFlatButton4);
            this.pnlSoruEkle.Controls.Add(this.txtCevap);
            this.pnlSoruEkle.Controls.Add(this.cmbKonu);
            this.pnlSoruEkle.Controls.Add(this.bunifuThinButton25);
            this.pnlSoruEkle.Controls.Add(this.txtMetin);
            this.pnlSoruEkle.Controls.Add(this.bunifuThinButton24);
            this.pnlSoruEkle.Controls.Add(this.bunifuThinButton23);
            this.pnlSoruEkle.Controls.Add(this.bunifuThinButton22);
            this.pnlSoruEkle.Controls.Add(this.bunifuThinButton21);
            this.pnlSoruEkle.Controls.Add(this.label1);
            this.pnlSoruEkle.Controls.Add(this.dgvSorular);
            this.pnlSoruEkle.Controls.Add(this.pbResim);
            this.pnlSoruEkle.Controls.Add(this.label3);
            this.pnlSoruEkle.Controls.Add(this.label2);
            this.pnlSoruEkle.Controls.Add(this.pbSikA);
            this.pnlSoruEkle.Controls.Add(this.pbSikB);
            this.pnlSoruEkle.Controls.Add(this.pbSikC);
            this.pnlSoruEkle.Controls.Add(this.pbSikD);
            this.pnlSoruEkle.Location = new System.Drawing.Point(260, 102);
            this.pnlSoruEkle.Name = "pnlSoruEkle";
            this.pnlSoruEkle.Size = new System.Drawing.Size(1237, 690);
            this.pnlSoruEkle.TabIndex = 36;
            this.pnlSoruEkle.Visible = false;
            // 
            // txtSoru
            // 
            this.txtSoru.BorderColorFocused = System.Drawing.Color.White;
            this.txtSoru.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtSoru.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtSoru.BorderThickness = 3;
            this.txtSoru.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoru.Font = new System.Drawing.Font("Candara Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.ForeColor = System.Drawing.Color.White;
            this.txtSoru.isPassword = false;
            this.txtSoru.Location = new System.Drawing.Point(777, 253);
            this.txtSoru.MaxLength = 32767;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(86, 31);
            this.txtSoru.TabIndex = 47;
            this.txtSoru.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSoru.Visible = false;
            // 
            // txtD
            // 
            this.txtD.BorderColorFocused = System.Drawing.Color.White;
            this.txtD.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtD.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtD.BorderThickness = 3;
            this.txtD.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtD.Font = new System.Drawing.Font("Candara Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtD.ForeColor = System.Drawing.Color.White;
            this.txtD.isPassword = false;
            this.txtD.Location = new System.Drawing.Point(463, 228);
            this.txtD.MaxLength = 32767;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(107, 43);
            this.txtD.TabIndex = 46;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtD.Visible = false;
            // 
            // txtC
            // 
            this.txtC.BorderColorFocused = System.Drawing.Color.White;
            this.txtC.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtC.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtC.BorderThickness = 3;
            this.txtC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtC.Font = new System.Drawing.Font("Candara Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtC.ForeColor = System.Drawing.Color.White;
            this.txtC.isPassword = false;
            this.txtC.Location = new System.Drawing.Point(313, 228);
            this.txtC.MaxLength = 32767;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(107, 43);
            this.txtC.TabIndex = 45;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtC.Visible = false;
            // 
            // txtB
            // 
            this.txtB.BorderColorFocused = System.Drawing.Color.White;
            this.txtB.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtB.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtB.BorderThickness = 3;
            this.txtB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtB.Font = new System.Drawing.Font("Candara Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtB.ForeColor = System.Drawing.Color.White;
            this.txtB.isPassword = false;
            this.txtB.Location = new System.Drawing.Point(179, 226);
            this.txtB.MaxLength = 32767;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(107, 45);
            this.txtB.TabIndex = 44;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtB.Visible = false;
            // 
            // txtA
            // 
            this.txtA.BorderColorFocused = System.Drawing.Color.White;
            this.txtA.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtA.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtA.BorderThickness = 3;
            this.txtA.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtA.Font = new System.Drawing.Font("Candara Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtA.ForeColor = System.Drawing.Color.White;
            this.txtA.isPassword = false;
            this.txtA.Location = new System.Drawing.Point(43, 227);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.MaxLength = 32767;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(107, 44);
            this.txtA.TabIndex = 43;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtA.Visible = false;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Active = false;
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "ÇIKART";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(1017, 267);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(161, 43);
            this.bunifuFlatButton6.TabIndex = 42;
            this.bunifuFlatButton6.Text = "ÇIKART";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = false;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "GÜNCELLE";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(1017, 216);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(161, 43);
            this.bunifuFlatButton5.TabIndex = 41;
            this.bunifuFlatButton5.Text = "GÜNCELLE";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = false;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Empty;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "EKLE";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(1017, 167);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(161, 43);
            this.bunifuFlatButton4.TabIndex = 40;
            this.bunifuFlatButton4.Text = "EKLE";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtCevap
            // 
            this.txtCevap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCevap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCevap.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCevap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCevap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.ForeColor = System.Drawing.Color.White;
            this.txtCevap.HintForeColor = System.Drawing.Color.Empty;
            this.txtCevap.HintText = "";
            this.txtCevap.isPassword = false;
            this.txtCevap.LineFocusedColor = System.Drawing.Color.White;
            this.txtCevap.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtCevap.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCevap.LineThickness = 3;
            this.txtCevap.Location = new System.Drawing.Point(1012, 120);
            this.txtCevap.Margin = new System.Windows.Forms.Padding(4);
            this.txtCevap.MaxLength = 32767;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(204, 33);
            this.txtCevap.TabIndex = 39;
            this.txtCevap.Text = "   ";
            this.txtCevap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbKonu
            // 
            this.cmbKonu.BackColor = System.Drawing.Color.Transparent;
            this.cmbKonu.BorderRadius = 3;
            this.cmbKonu.DisabledColor = System.Drawing.Color.Gray;
            this.cmbKonu.ForeColor = System.Drawing.Color.White;
            this.cmbKonu.items = new string[0];
            this.cmbKonu.Location = new System.Drawing.Point(1012, 40);
            this.cmbKonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbKonu.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbKonu.selectedIndex = -1;
            this.cmbKonu.Size = new System.Drawing.Size(221, 53);
            this.cmbKonu.TabIndex = 38;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 1;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "SORU RESMİ SEÇ";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 1;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.Location = new System.Drawing.Point(688, 12);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(264, 52);
            this.bunifuThinButton25.TabIndex = 37;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMetin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMetin.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMetin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMetin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMetin.ForeColor = System.Drawing.Color.White;
            this.txtMetin.HintForeColor = System.Drawing.Color.Empty;
            this.txtMetin.HintText = "";
            this.txtMetin.isPassword = false;
            this.txtMetin.LineFocusedColor = System.Drawing.Color.White;
            this.txtMetin.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtMetin.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtMetin.LineThickness = 3;
            this.txtMetin.Location = new System.Drawing.Point(43, 40);
            this.txtMetin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMetin.MaxLength = 32767;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(620, 33);
            this.txtMetin.TabIndex = 36;
            this.txtMetin.Text = "    ";
            this.txtMetin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 1;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "D";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 1;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(463, 92);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(107, 52);
            this.bunifuThinButton24.TabIndex = 35;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.btnSikD_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 1;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "C";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 1;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(313, 92);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(107, 52);
            this.bunifuThinButton23.TabIndex = 34;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.btnSikC_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 1;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "B";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 1;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(179, 92);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(107, 52);
            this.bunifuThinButton22.TabIndex = 33;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.btnSikB_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "A";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(43, 92);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(107, 52);
            this.bunifuThinButton21.TabIndex = 1;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.btnSikA_Click);
            // 
            // btnOgrenciDetay
            // 
            this.btnOgrenciDetay.Active = false;
            this.btnOgrenciDetay.Activecolor = System.Drawing.Color.Empty;
            this.btnOgrenciDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnOgrenciDetay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOgrenciDetay.BorderRadius = 0;
            this.btnOgrenciDetay.ButtonText = "ÖĞRENCİ DETAY";
            this.btnOgrenciDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenciDetay.DisabledColor = System.Drawing.Color.Gray;
            this.btnOgrenciDetay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOgrenciDetay.Iconimage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.btnOgrenciDetay.Iconimage_right = null;
            this.btnOgrenciDetay.Iconimage_right_Selected = null;
            this.btnOgrenciDetay.Iconimage_Selected = null;
            this.btnOgrenciDetay.IconMarginLeft = 0;
            this.btnOgrenciDetay.IconMarginRight = 0;
            this.btnOgrenciDetay.IconRightVisible = true;
            this.btnOgrenciDetay.IconRightZoom = 0D;
            this.btnOgrenciDetay.IconVisible = true;
            this.btnOgrenciDetay.IconZoom = 90D;
            this.btnOgrenciDetay.IsTab = false;
            this.btnOgrenciDetay.Location = new System.Drawing.Point(1, 239);
            this.btnOgrenciDetay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOgrenciDetay.Name = "btnOgrenciDetay";
            this.btnOgrenciDetay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnOgrenciDetay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnOgrenciDetay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOgrenciDetay.selected = false;
            this.btnOgrenciDetay.Size = new System.Drawing.Size(228, 59);
            this.btnOgrenciDetay.TabIndex = 37;
            this.btnOgrenciDetay.Text = "ÖĞRENCİ DETAY";
            this.btnOgrenciDetay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciDetay.Textcolor = System.Drawing.Color.White;
            this.btnOgrenciDetay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciDetay.Click += new System.EventHandler(this.btnOgrenciDetay_Click);
            // 
            // pnlOgrenciDetay
            // 
            this.pnlOgrenciDetay.Controls.Add(this.dgvOgrenciDetay);
            this.pnlOgrenciDetay.Location = new System.Drawing.Point(240, 105);
            this.pnlOgrenciDetay.Name = "pnlOgrenciDetay";
            this.pnlOgrenciDetay.Size = new System.Drawing.Size(1198, 690);
            this.pnlOgrenciDetay.TabIndex = 48;
            this.pnlOgrenciDetay.Visible = false;
            // 
            // dgvOgrenciDetay
            // 
            this.dgvOgrenciDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciDetay.Location = new System.Drawing.Point(25, 30);
            this.dgvOgrenciDetay.Name = "dgvOgrenciDetay";
            this.dgvOgrenciDetay.RowTemplate.Height = 24;
            this.dgvOgrenciDetay.Size = new System.Drawing.Size(1153, 606);
            this.dgvOgrenciDetay.TabIndex = 0;
            this.dgvOgrenciDetay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciDetay_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.txtSeach);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1512, 84);
            this.panel1.TabIndex = 49;
            // 
            // txtSeach
            // 
            this.txtSeach.BorderColorFocused = System.Drawing.Color.White;
            this.txtSeach.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeach.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtSeach.BorderThickness = 3;
            this.txtSeach.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSeach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeach.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeach.isPassword = false;
            this.txtSeach.Location = new System.Drawing.Point(965, 22);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeach.MaxLength = 32767;
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(370, 44);
            this.txtSeach.TabIndex = 4;
            this.txtSeach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1342, 22);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(45, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::OgrenciSinav.Properties.Resources.ApkLogo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, -19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 122);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Location = new System.Drawing.Point(12, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 305);
            this.panel2.TabIndex = 50;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(-319, -111);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(801, 535);
            this.Logo.TabIndex = 40;
            this.Logo.TabStop = false;
            // 
            // OgretmenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1509, 787);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlOgrenciDetay);
            this.Controls.Add(this.btnOgrenciDetay);
            this.Controls.Add(this.pnlSoruEkle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.btnSoruEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgretmenForm";
            this.Text = "SoruForm";
            this.Load += new System.EventHandler(this.SoruForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikC)).EndInit();
            this.pnlSoruEkle.ResumeLayout(false);
            this.pnlSoruEkle.PerformLayout();
            this.pnlOgrenciDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciDetay)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSorular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdResim;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.PictureBox pbSikA;
        private System.Windows.Forms.PictureBox pbSikB;
        private System.Windows.Forms.PictureBox pbSikD;
        private System.Windows.Forms.PictureBox pbSikC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnSoruEkle;
        private Bunifu.Framework.UI.BunifuFlatButton btnOgrenciEkle;
        private Bunifu.Framework.UI.BunifuFlatButton btnCikis;
        private System.Windows.Forms.Panel pnlSoruEkle;
        private Bunifu.Framework.UI.BunifuDropdown cmbKonu;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMetin;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCevap;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSoru;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtD;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtC;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtB;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtA;
        private Bunifu.Framework.UI.BunifuFlatButton btnOgrenciDetay;
        private System.Windows.Forms.Panel pnlOgrenciDetay;
        private System.Windows.Forms.DataGridView dgvOgrenciDetay;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSeach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Logo;
    }
}
namespace OgrenciSinav
{
    partial class SoruForm
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
            this.dgvSorular = new System.Windows.Forms.DataGridView();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.pbSikA = new System.Windows.Forms.PictureBox();
            this.btnSikA = new System.Windows.Forms.Button();
            this.btnSikB = new System.Windows.Forms.Button();
            this.pbSikB = new System.Windows.Forms.PictureBox();
            this.btnSikD = new System.Windows.Forms.Button();
            this.pbSikD = new System.Windows.Forms.PictureBox();
            this.btnSikC = new System.Windows.Forms.Button();
            this.pbSikC = new System.Windows.Forms.PictureBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKonu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSorular
            // 
            this.dgvSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSorular.Location = new System.Drawing.Point(12, 236);
            this.dgvSorular.MultiSelect = false;
            this.dgvSorular.Name = "dgvSorular";
            this.dgvSorular.RowTemplate.Height = 24;
            this.dgvSorular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSorular.Size = new System.Drawing.Size(1169, 313);
            this.dgvSorular.TabIndex = 0;
            this.dgvSorular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSorular_CellClick);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(12, 64);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(217, 166);
            this.txtMetin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru Metini :";
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "Resim Seçiniz";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(696, 47);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(234, 107);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 11;
            this.pbResim.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(696, 0);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(234, 40);
            this.btnResimSec.TabIndex = 12;
            this.btnResimSec.Text = "SORU Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1074, 193);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 37);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1074, 150);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 37);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(1074, 107);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 37);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // pbSikA
            // 
            this.pbSikA.Location = new System.Drawing.Point(244, 44);
            this.pbSikA.Name = "pbSikA";
            this.pbSikA.Size = new System.Drawing.Size(107, 69);
            this.pbSikA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikA.TabIndex = 16;
            this.pbSikA.TabStop = false;
            // 
            // btnSikA
            // 
            this.btnSikA.Location = new System.Drawing.Point(244, 4);
            this.btnSikA.Name = "btnSikA";
            this.btnSikA.Size = new System.Drawing.Size(107, 37);
            this.btnSikA.TabIndex = 17;
            this.btnSikA.Text = "A ŞIKKI";
            this.btnSikA.UseVisualStyleBackColor = true;
            this.btnSikA.Click += new System.EventHandler(this.btnSikA_Click);
            // 
            // btnSikB
            // 
            this.btnSikB.Location = new System.Drawing.Point(357, 4);
            this.btnSikB.Name = "btnSikB";
            this.btnSikB.Size = new System.Drawing.Size(107, 37);
            this.btnSikB.TabIndex = 19;
            this.btnSikB.Text = "B ŞIKKI";
            this.btnSikB.UseVisualStyleBackColor = true;
            this.btnSikB.Click += new System.EventHandler(this.btnSikB_Click);
            // 
            // pbSikB
            // 
            this.pbSikB.Location = new System.Drawing.Point(357, 44);
            this.pbSikB.Name = "pbSikB";
            this.pbSikB.Size = new System.Drawing.Size(107, 69);
            this.pbSikB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikB.TabIndex = 18;
            this.pbSikB.TabStop = false;
            // 
            // btnSikD
            // 
            this.btnSikD.Location = new System.Drawing.Point(583, 4);
            this.btnSikD.Name = "btnSikD";
            this.btnSikD.Size = new System.Drawing.Size(107, 37);
            this.btnSikD.TabIndex = 23;
            this.btnSikD.Text = "D ŞIKKI";
            this.btnSikD.UseVisualStyleBackColor = true;
            this.btnSikD.Click += new System.EventHandler(this.btnSikD_Click);
            // 
            // pbSikD
            // 
            this.pbSikD.Location = new System.Drawing.Point(583, 44);
            this.pbSikD.Name = "pbSikD";
            this.pbSikD.Size = new System.Drawing.Size(107, 69);
            this.pbSikD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikD.TabIndex = 22;
            this.pbSikD.TabStop = false;
            // 
            // btnSikC
            // 
            this.btnSikC.Location = new System.Drawing.Point(470, 4);
            this.btnSikC.Name = "btnSikC";
            this.btnSikC.Size = new System.Drawing.Size(107, 37);
            this.btnSikC.TabIndex = 21;
            this.btnSikC.Text = "C ŞIKKI";
            this.btnSikC.UseVisualStyleBackColor = true;
            this.btnSikC.Click += new System.EventHandler(this.btnSikC_Click);
            // 
            // pbSikC
            // 
            this.pbSikC.Location = new System.Drawing.Point(470, 47);
            this.pbSikC.Name = "pbSikC";
            this.pbSikC.Size = new System.Drawing.Size(107, 69);
            this.pbSikC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSikC.TabIndex = 20;
            this.pbSikC.TabStop = false;
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(711, 160);
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(100, 22);
            this.txtSoru.TabIndex = 24;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(470, 122);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(107, 22);
            this.txtC.TabIndex = 26;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(244, 121);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(107, 22);
            this.txtA.TabIndex = 25;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(357, 121);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 27;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(583, 121);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(107, 22);
            this.txtD.TabIndex = 28;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(945, 193);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(100, 22);
            this.txtCevap.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(954, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "CEVAP";
            // 
            // cmbKonu
            // 
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.Location = new System.Drawing.Point(978, 44);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(166, 24);
            this.cmbKonu.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(989, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "KONU :";
            // 
            // SoruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.btnSikD);
            this.Controls.Add(this.pbSikD);
            this.Controls.Add(this.btnSikC);
            this.Controls.Add(this.pbSikC);
            this.Controls.Add(this.btnSikB);
            this.Controls.Add(this.pbSikB);
            this.Controls.Add(this.btnSikA);
            this.Controls.Add(this.pbSikA);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.dgvSorular);
            this.Name = "SoruForm";
            this.Text = "SoruForm";
            this.Load += new System.EventHandler(this.SoruForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSikC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSorular;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdResim;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.PictureBox pbSikA;
        private System.Windows.Forms.Button btnSikA;
        private System.Windows.Forms.Button btnSikB;
        private System.Windows.Forms.PictureBox pbSikB;
        private System.Windows.Forms.Button btnSikD;
        private System.Windows.Forms.PictureBox pbSikD;
        private System.Windows.Forms.Button btnSikC;
        private System.Windows.Forms.PictureBox pbSikC;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKonu;
        private System.Windows.Forms.Label label3;
    }
}
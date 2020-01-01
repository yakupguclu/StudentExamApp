using OgrenciSinav.ORM;
using OgrenciSinav.ORM.Entity;
using OgrenciSinav.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinav
{
    public partial class OgretmenForm : Form
    {
        public OgretmenForm()
        {
            InitializeComponent();
        }
        
        public void Listele()
        {
            Soru soru = new Soru();
            Ogrenci ogrenci = new Ogrenci();
            dgvSorular.DataSource = Sorular.SoruListele(soru);
            dgvOgrenciDetay.DataSource = OgrenciDetaylar.OgrenciDetayListele(ogrenci);
            List<Konu> ListKonu=Konular.KonuGetir();
            for(int i = 0; i < ListKonu.Count;i++)
            {
                cmbKonu.Items.Add(ListKonu[i].KonuIsim);
            }
        }
        private void SoruForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ofdResim.ShowDialog();
            pbResim.ImageLocation = ofdResim.FileName;
            txtSoru.Text = ofdResim.FileName.ToString();
        }
        private void btnSikA_Click(object sender, EventArgs e)
        {
            ofdResim.ShowDialog();
            pbSikA.ImageLocation = ofdResim.FileName;
            txtA.Text = ofdResim.FileName.ToString();
        }
        private void btnSikB_Click(object sender, EventArgs e)
        {
            ofdResim.ShowDialog();
            pbSikB.ImageLocation = ofdResim.FileName;
            txtB.Text = ofdResim.FileName.ToString();
        }
        private void btnSikC_Click(object sender, EventArgs e)
        {
            ofdResim.ShowDialog();
            pbSikC.ImageLocation = ofdResim.FileName;
            txtC.Text = ofdResim.FileName.ToString();
        }
        private void btnSikD_Click(object sender, EventArgs e)
        {
            ofdResim.ShowDialog();
            pbSikD.ImageLocation = ofdResim.FileName;
            txtD.Text = ofdResim.FileName.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Soru soru = new Soru();
            soru.Metin = txtMetin.Text;
            soru.DogruCevap = txtCevap.Text;
            soru.SikA = txtA.Text;
            soru.SikB = txtB.Text;
            soru.SikC = txtC.Text;
            soru.SikD = txtD.Text;
            soru.SoruResim = txtSoru.Text.ToString();
            soru.KonuID = cmbKonu.selectedIndex;
            if (!Sorular.SoruEkle(soru))
                MessageBox.Show("HATA");
            else
                MessageBox.Show("Ekleme Başarılı");
            Listele();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Soru soru = new Soru();
            soru.Metin = txtMetin.Text;
            soru.DogruCevap = txtCevap.Text;
            soru.SikA = txtA.Text;
            soru.SikB = txtB.Text;
            soru.SikC = txtC.Text;
            soru.SikD = txtD.Text;
            soru.SoruResim = txtSoru.Text.ToString();
            soru.KonuID = cmbKonu.selectedIndex;
            soru.SoruID = Convert.ToInt32(txtCevap.Tag);
            if(!Sorular.SoruGuncelle(soru))
                MessageBox.Show("HATA");
            else
                MessageBox.Show("Güncelleme Başarılı");
            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Soru soru = new Soru();
            soru.SoruID = Convert.ToInt32(txtCevap.Tag);
            if(!Sorular.SoruSil(soru))
                MessageBox.Show("HATA");
            else
                MessageBox.Show("Silme İşlemi Başarılı");
            Listele();
        }
        private void dgvSorular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbResim.ImageLocation = txtSoru.Text = dgvSorular.CurrentRow.Cells["SoruResim"].Value.ToString();
            pbSikA.ImageLocation = txtA.Text = dgvSorular.CurrentRow.Cells["SikA"].Value.ToString();
            pbSikB.ImageLocation = txtB.Text = dgvSorular.CurrentRow.Cells["SikB"].Value.ToString();
            pbSikC.ImageLocation = txtC.Text = dgvSorular.CurrentRow.Cells["SikC"].Value.ToString();
            pbSikD.ImageLocation = txtD.Text = dgvSorular.CurrentRow.Cells["SikD"].Value.ToString();
            txtCevap.Text = dgvSorular.CurrentRow.Cells["DogruCevap"].Value.ToString();
            txtMetin.Text = dgvSorular.CurrentRow.Cells["Metin"].Value.ToString();
            txtCevap.Tag = dgvSorular.CurrentRow.Cells["SoruID"].Value.ToString();
            cmbKonu.Text = dgvSorular.CurrentRow.Cells["Konu"].Value.ToString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciForm ogr = new OgrenciForm();
            ogr.Show();
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            pnlOgrenciDetay.Visible = false;
            pnlSoruEkle.Visible = true;
        }

        private void btnOgrenciDetay_Click(object sender, EventArgs e)
        {
            pnlOgrenciDetay.Visible = true;
            pnlSoruEkle.Visible = false;
        }

        private void dgvOgrenciDetay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

using OgrenciSinav.ORM;
using OgrenciSinav.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinav
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = txtAdi.Text;
            ogr.Soyad = txtSoyadi.Text;
            ogr.TCKN = mtbTCKN.Text;
            if(!Ogrenciler.OgrenciEkle(ogr))
                MessageBox.Show("Ekleme Başarısız");
            Listele();
        }
        public void Listele()
        {
            Ogrenci ogrenci = new Ogrenci();
            dgvOgrenci.DataSource = Ogrenciler.OgrenciListele(ogrenci);
        }

        private void dgvOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOgrenci.CurrentRow == null) return;
            txtAdi.Text = dgvOgrenci.CurrentRow.Cells["Ad"].Value.ToString();
            txtSoyadi.Text = dgvOgrenci.CurrentRow.Cells["Soyad"].Value.ToString();
            mtbTCKN.Text = dgvOgrenci.CurrentRow.Cells["TCKN"].Value.ToString();
            txtAdi.Tag = dgvOgrenci.CurrentRow.Cells["OgrenciID"].Value;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAdi.Text;
            ogrenci.Soyad = txtSoyadi.Text;
            ogrenci.TCKN = mtbTCKN.Text;
            ogrenci.OgrenciID = Convert.ToInt32(txtAdi.Tag);
            if(!Ogrenciler.OgrenciGuncelle(ogrenci))
                MessageBox.Show("Güncelleme Başarısız");
            else
                MessageBox.Show("Güncelleme Başarılı");
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciID = (int)txtAdi.Tag;
            if(!Ogrenciler.OgrenciSil(ogrenci))
                MessageBox.Show("Silme İşlemi Başarısız");
            else
                MessageBox.Show("Silme İşlemi Başarılı");
            Listele();
        }
    }
}

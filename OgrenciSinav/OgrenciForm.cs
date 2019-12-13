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
    }
}

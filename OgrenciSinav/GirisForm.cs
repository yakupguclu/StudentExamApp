using OgrenciSinav.ORM;
using OgrenciSinav.ORM.Entity;
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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
           ogrenci.OgrenciID = mtbKullaniciAd.Text;
           ogrenci.TCKN = mtbParola.Text;
           Ogretmen ogretmen = new Ogretmen();
           ogretmen.OgretmenID = mtbKullaniciAd.Text;
           ogretmen.TCKN = mtbParola.Text;

            if (mtbKullaniciAd.Text == "" || mtbParola.Text == "")
            {
                MessageBox.Show("Hatalı Veri Girişi");
            }
            else if (Loginler.OgretmenGirisKontrol(ogretmen))
           {
               this.Hide();
               OgretmenForm form = new OgretmenForm();
               form.Show();
               MessageBox.Show("Giriş Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
           }
           else if (Loginler.GirisKontrol(ogrenci) == true)
            {
                Loginler.GirisLogEkle(ogrenci);
                this.Hide();
                AnaForm ana = new AnaForm();
                ana.Show();
                MessageBox.Show("Giriş Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}

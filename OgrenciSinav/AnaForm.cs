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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        List<Soru> listSorular;
        int i = 0;
        int puanSayac = 0;
        int soruSayisi = 0;
        int dakika = 60;
        int saniye = 60;
        static int dogruSayisi = 0;
        static int yanlisSayisi = 0;

        private void AnaForm_Load(object sender, EventArgs e)
        {
            btnSonuclar.Visible = false;
            listSorular = Sorular.SoruGetir();
            timer.Start();
            List<Login> listLogin = new List<Login>();
            listLogin = Loginler.OgrBilgiGetir();
            lblAdSoyad.Text = listLogin[0].Ad + " " + listLogin[0].Soyad;
            lblOgrenciNo.Text = listLogin[0].OgrenciID;
        }
        
        private void btnGEC_Click(object sender, EventArgs e)
        {
                btnGec.Text = "SONRAKİ";
                lblSoruMetin.Visible = true;
                SoruGoster(i);
                if (i < listSorular.Count)
                {
                    //SoruDetay Ekleme
                    SoruDetay ogrenci = new SoruDetay();
                    ogrenci.SoruID = listSorular[i].SoruID;
                    ogrenci.KonuID = listSorular[i].KonuID;
                    ogrenci.OgrenciID = lblOgrenciNo.Text;
                    if (rbSikA.Checked == true)
                    {
                        ogrenci.VerilenCevap = "A";
                    }
                    if (rbSikB.Checked == true)
                    {
                        ogrenci.VerilenCevap = "B";
                    }
                    if (rbSikC.Checked == true)
                    {
                        ogrenci.VerilenCevap = "C";
                    }
                    if (rbSikD.Checked == true)
                    {
                        ogrenci.VerilenCevap = "D";
                    }
                    SoruDetaylar.DetayEkle(ogrenci);
                }
                i++;
                soruSayisi++;
        }

        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            yanlisSayisi = 20 - dogruSayisi;

            OgrenciDetay ogrenci = new OgrenciDetay();
            ogrenci.Puan = puanSayac;
            ogrenci.CozulenSoruSayisi = (soruSayisi-1);
            ogrenci.OgrenciID = lblOgrenciNo.Text;
            ogrenci.DogruSayisi = dogruSayisi;
            ogrenci.YanlisSayisi = yanlisSayisi;
            OgrenciDetaylar.DetayEkle(ogrenci);

            MessageBox.Show("Puanınız : "+puanSayac.ToString()+"\nDoğru Sayısı : "+dogruSayisi.ToString()+
                "\nYanlış Sayısı : "+yanlisSayisi.ToString()+"\nSoru Sayısı : "+(soruSayisi-1).ToString());
            btnSonuclar.Visible = false;
        }
        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            SonuclarForm frm = new SonuclarForm();
            frm.Show();
            this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            timer.Interval = 1200;
            prgbZaman.Minimum = 0;
            prgbZaman.Maximum = 12000;
            prgbZaman.Step = 1;
            
            if (prgbZaman.Value == prgbZaman.Maximum)
                return;
            prgbZaman.Value += 1;

            saniye = saniye - 1;
            lblSaniye.Text = Convert.ToString(saniye);
            lblDakika.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {
                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;
            }
            if (lblDakika.Text == "-1")
            {
                timer.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                this.BackColor = Color.Red;
                MessageBox.Show("Sınav Süreniz Doldu");
                btnGec.Visible = false;
            }
        }
        public void SoruGoster(int i)
        {
            try
            {
                pbSoru.ImageLocation = listSorular[i].SoruResim;
                lblSoruMetin.Text = listSorular[i].Metin;
                pbSikA.ImageLocation = listSorular[i].SikA;
                pbSikB.ImageLocation = listSorular[i].SikB;
                pbSikC.ImageLocation = listSorular[i].SikC;
                pbSikD.ImageLocation = listSorular[i].SikD;

                if (rbSikA.Checked == true && listSorular[i].DogruCevap == "A")
                {
                    puanSayac += 5;
                    dogruSayisi += 1;
                    Sorular.AsamaNoGuncelle(listSorular[i].SoruID);
                }
                if (rbSikB.Checked == true && listSorular[i].DogruCevap == "B")
                {
                    puanSayac += 5;
                    dogruSayisi += 1;
                    Sorular.AsamaNoGuncelle(listSorular[i].SoruID);
                }
                if (rbSikC.Checked == true && listSorular[i].DogruCevap == "C")
                {
                    puanSayac += 5;
                    dogruSayisi += 1;
                    Sorular.AsamaNoGuncelle(listSorular[i].SoruID);
                }
                if (rbSikD.Checked == true && listSorular[i].DogruCevap == "D")
                {
                    puanSayac += 5;
                    dogruSayisi += 1;
                    Sorular.AsamaNoGuncelle(listSorular[i].SoruID);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sınav Bitti\nSonuçları Görmek İçin Sonuçlar Butonuna Basınız", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGec.Visible = false;
                btnSonuclar.Visible = true;
            }
        }
        private void btnSorular_Click(object sender, EventArgs e)
        {
            pnlSınav.Visible = true;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSinav_Click(object sender, EventArgs e)
        {
         pnlIlletisim.Visible = false;
         pnlKaynak.Visible = false;
         pnlVideo.Visible = false;
         pnlSınav.Visible = true;
        }
        private void btnVideo_Click_1(object sender, EventArgs e)
        {
            pnlIlletisim.Visible = false;
            pnlKaynak.Visible = false;
            pnlSınav.Visible = false;
            pnlVideo.Visible = true;
            Video.URL = Application.StartupPath + "/Video.mp4";
            Video.URL = "";
        }
        private void btnKaynak_Click(object sender, EventArgs e)
        {
            pnlKaynak.Visible = true;
            pnlSınav.Visible = false;
            pnlVideo.Visible = false;
            pnlIlletisim.Visible = false;
        }
        private void btnIletisim_Click(object sender, EventArgs e)
        {
            pnlIlletisim.Visible = true;
            pnlKaynak.Visible = false;
            pnlSınav.Visible = false;
            pnlVideo.Visible = false;
        }
        private void btnIstatistik_Click_1(object sender, EventArgs e)
        {
            SonuclarForm frm1 = new SonuclarForm();
            frm1.Show();
        }
    }
}

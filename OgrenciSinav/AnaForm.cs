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
        int dogruSayisi = 0;
        int yanlisSayisi = 0;

        private void AnaForm_Load(object sender, EventArgs e)
        {
            listSorular = Sorular.SoruGetir();
            timer.Start();
        }
        
        private void btnGEC_Click(object sender, EventArgs e)
        {
            btnGec.Text = "SONRAKİ SORU";
            SoruGoster(i);
            if (i<20)
            {
                //SoruDetay Ekleme
                SoruDetay ogrenci = new SoruDetay();
                ogrenci.SoruID = listSorular[i].SoruID;
                ogrenci.KonuID = listSorular[i].KonuID;
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
                if(!SoruDetaylar.DetayEkle(ogrenci))
                    MessageBox.Show("Test");
            }
            i++;
            soruSayisi++;
        }

        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            OgrenciDetay ogrenci = new OgrenciDetay();
            ogrenci.Tarih = DateTime.Today.Date;
            ogrenci.Puan = puanSayac;
            ogrenci.CozulenSoruSayisi = soruSayisi;
            if(!OgrenciDetaylar.DetayEkle(ogrenci))
                MessageBox.Show("HATA");
            yanlisSayisi = 20 - dogruSayisi;

            MessageBox.Show("Puanınız : "+puanSayac.ToString()+"\nDoğru Sayısı : "+dogruSayisi.ToString()+
                "\nYanlış Sayısı : "+yanlisSayisi.ToString()+"\nSoru Sayısı : "+(soruSayisi-1).ToString());

        }
        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            SonuclarForm frm = new SonuclarForm();
            this.Hide();
            frm.Show();
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
                }
                if (rbSikB.Checked == true && listSorular[i].DogruCevap == "B")
                {
                    puanSayac += 5;

                }
                if (rbSikC.Checked == true && listSorular[i].DogruCevap == "C")
                {
                    puanSayac += 5;
                }
                if (rbSikD.Checked == true && listSorular[i].DogruCevap == "D")
                {
                    puanSayac += 5;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sınav Bitti\nSonuçları Görmek İçin Sonuçlar Butonuna Basınız", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGec.Visible = false;
                btnSonuclar.Visible = true;
            }
        }

       
    }
}

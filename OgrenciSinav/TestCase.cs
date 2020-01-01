using NUnit.Framework;
using OgrenciSinav.ORM;
using OgrenciSinav.ORM.Entity;
using OgrenciSinav.ORM.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav
{
    public class TestCase
    {
        [TestCase]
        public void GirisTesti()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciID = "9";
            ogrenci.TCKN = "11111111111";
            Assert.AreEqual(true, Loginler.GirisKontrol(ogrenci));
        }
        [TestCase]
        public void IstatistikTest()
        {
            Assert.AreEqual(30, SoruDetaylar.IstatistikCek(2));
        }
        [TestCase]
        public void OgrenciEkleTest()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Tufan";
            ogrenci.Soyad = "BOZBEŞPARMAK";
            ogrenci.TCKN = "12345678901";
            Assert.AreEqual(true, Ogrenciler.OgrenciEkle(ogrenci));
        }
        [TestCase]
        public void OgrenciDetayTest()
        {
            OgrenciDetay ogrenci = new OgrenciDetay();
            ogrenci.CozulenSoruSayisi = 20;
            ogrenci.Puan = 50;
            ogrenci.OgrenciID = "9";
            Assert.AreEqual(true, OgrenciDetaylar.DetayEkle(ogrenci));
        }
    }
}

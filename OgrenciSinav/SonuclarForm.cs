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
    public partial class SonuclarForm : Form
    {
        public SonuclarForm()
        {
            InitializeComponent();
        }

        private void SonuclarForm_Load(object sender, EventArgs e)
        {
            
            //Soru İstatistik
            chart1.Series["MutlakDeğer"].Points.Add(SoruDetaylar.IstatistikCek(0));
            chart1.Series["MutlakDeğer"].Points.Add(SoruDetaylar.IstatistikCek(1));
            chart1.Series["MutlakDeğer"].Points.Add(SoruDetaylar.IstatistikCek(2));
            chart1.Series["MutlakDeğer"].Points.Add(SoruDetaylar.IstatistikCek(3));
            chart1.Series["MutlakDeğer"].Points.Add(SoruDetaylar.IstatistikCek(4));
            chart1.Series["MutlakDeğer"].Points.Add(SoruDetaylar.IstatistikCek(5));


            chart1.Series["MutlakDeğer"].Points[0].AxisLabel = "Mutlak\nDeğer";
            chart1.Series["MutlakDeğer"].Points[1].AxisLabel = "Mantık\n";
            chart1.Series["MutlakDeğer"].Points[2].AxisLabel = "Modüler\nAritmetik";
            chart1.Series["MutlakDeğer"].Points[3].AxisLabel = "Problemler";
            chart1.Series["MutlakDeğer"].Points[4].AxisLabel = "Ardışık\nSayılar";
            chart1.Series["MutlakDeğer"].Points[5].AxisLabel = "Çarpanları\nAyırma";
           

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;

            chart2.Series["SoruSayısı"].Points.Add(SoruDetaylar.IstatistikCek(6));
            chart2.Series["SoruSayısı"].Points.Add(SoruDetaylar.IstatistikCek(7));
            chart2.Series["SoruSayısı"].Points.Add(SoruDetaylar.IstatistikCek(8));
            chart2.Series["SoruSayısı"].Points.Add(SoruDetaylar.IstatistikCek(9));
            chart2.Series["SoruSayısı"].Points.Add(SoruDetaylar.IstatistikCek(10));
            

            chart2.Series["SoruSayısı"].Points[0].AxisLabel = "Sayılar";
            chart2.Series["SoruSayısı"].Points[1].AxisLabel = "Bölme\nBölünebilme";
            chart2.Series["SoruSayısı"].Points[2].AxisLabel = "OBEB\nOKEK";
            chart2.Series["SoruSayısı"].Points[3].AxisLabel = "Oran\nOrantı";
            chart2.Series["SoruSayısı"].Points[4].AxisLabel = "Denklemler";

            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = -70;

            //Genel İstatistik
           
            chartGenel.Series["Genel"].Points.Add(Convert.ToInt32(SoruDetaylar.GenelIstatistik("ToplamSoru")));
            chartGenel.Series["Genel"].Points.Add(Convert.ToInt32(SoruDetaylar.GenelIstatistik("OrtalamaPuan")));

            chartGenel.Series["Genel"].Points[0].AxisLabel = "Toplam\nSoru";
            chartGenel.Series["Genel"].Points[1].AxisLabel = "Ortalama\nPuan";


        }
        
    }
}

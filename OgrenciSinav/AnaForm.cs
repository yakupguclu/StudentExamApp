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

        private void AnaForm_Load(object sender, EventArgs e)
        {
            listSorular = Sorular.SoruGetir();
        }
        
        private void btnGEC_Click(object sender, EventArgs e)
        {
            SoruGoster(i);
            i++;
        }
        public void SoruGoster(int i)
        {
            try
            {
                rtSoruMetin.Text = listSorular[i].Metin;
                rbSikA.Text = listSorular[i].SikA;
                rbSikB.Text= listSorular[i].SikB;
                rbSikC.Text = listSorular[i].SikC;
                rbSikD.Text = listSorular[i].SikD;
            }
            catch (Exception)
            {
                MessageBox.Show("Sınav Bitti..","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
    }
}

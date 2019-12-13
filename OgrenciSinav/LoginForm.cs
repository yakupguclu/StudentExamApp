using OgrenciSinav.ORM;
using OgrenciSinav.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinav
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.OgrenciID = txtKullaniciAd.Text;
            o.TCKN = txtParola.Text;
            if (Login.GirisKontrol(o) == true)
            {
                this.Hide();
                AnaForm ana = new AnaForm();
                ana.Show();
                MessageBox.Show("Giriş Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("HATALI GİRİŞ","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}

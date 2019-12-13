using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM
{
    public class Ogrenci
    {
        public string OgrenciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public int OgretmenID { get; set; }
        public int DersID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM.Entity
{
    public class SoruDetay
    {
        public string OgrenciID { get; set; }
        public int SoruID { get; set; }
        public int DersID { get; set; }
        public string VerilenCevap { get; set; }
        public int KonuID { get; set; }
    }
}

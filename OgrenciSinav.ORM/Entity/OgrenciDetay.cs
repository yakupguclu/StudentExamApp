using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM.Entity
{
    public class OgrenciDetay:SoruDetay
    {
        public int CozulenSoruSayisi { get; set; }
        public int Puan { get; set; }
        public DateTime Tarih { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM.Entity
{
    public class OgrenciDetay
    {
        public string OgrenciID { get; set; }
        public int CozulenSoruSayisi { get; set; }
        public int Puan { get; set; }
        public DateTime Tarih { get; set; }
    }
}

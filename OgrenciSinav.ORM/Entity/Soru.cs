using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM.Entity
{
    public class Soru
    {
        public int SoruID { get; set; }
        public string Metin { get; set; }
        public string SoruResim { get; set; }
        public string SikA { get; set; }
        public string SikB { get; set; }
        public string SikC { get; set; }
        public string SikD { get; set; }
        public string DogruCevap { get; set; }
        public int KonuID { get; set; }
        public int AsamaNO { get; set; }
    }
}


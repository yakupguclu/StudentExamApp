using OgrenciSinav.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM.Facade
{
    public class Konular
    {
        public static List<Konu> KonuGetir()
        {
            SqlCommand komut = new SqlCommand("Select * from Konu", Tools.Baglanti);
            Tools.Baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            List<Konu> Konular = new List<Konu>();
            while (dr.Read())
            {
                Konu entity = new Konu();
                entity.KonuIsim = dr["Konu"].ToString();
                entity.KonuID = (int)dr["KonuID"];
                Konular.Add(entity);
            }
            Tools.Baglanti.Close();
            return Konular;
        }
    }
}

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
    public class Sorular
    {
        public static List<Soru> SoruGetir()
        {
            List<Soru> SoruListesi = new List<Soru>();
            SqlCommand komut = new SqlCommand("Exec SoruGetir", Tools.Baglanti);
            Tools.Baglanti.Open();
            List<Soru> listSorular = new List<Soru>();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Soru entity1 = new Soru();
                entity1.SoruID = (int)dr[0];
                entity1.Metin = dr["Metin"].ToString();
                entity1.SikA = dr["SikA"].ToString();
                entity1.SikB = dr["SikB"].ToString();
                entity1.SikC = dr["SikC"].ToString();
                entity1.SikD = dr["SikD"].ToString();
                listSorular.Add(entity1);
            }
            Tools.Baglanti.Close();
            return listSorular;
        }
    }
}

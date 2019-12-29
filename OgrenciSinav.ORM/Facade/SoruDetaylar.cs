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
    public class SoruDetaylar
    {
        

        public static bool DetayEkle(SoruDetay entity)
        {
            SqlCommand komut = new SqlCommand("SoruDetayEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@soruid", entity.SoruID);
            komut.Parameters.AddWithValue("@verilencevap", entity.VerilenCevap);
            komut.Parameters.AddWithValue("@konuid", entity.KonuID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static int IstatistikCek(int KonuID)
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) as 'Sayac' FROM SoruDetay WHERE KonuID='"+KonuID+"'", Tools.Baglanti);
            Tools.Baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                KonuID = (int)dr["Sayac"];
            }
            Tools.Baglanti.Close();
            return KonuID;
        }
        public static string GenelIstatistik(string entity)
        {
            SqlCommand komut = new SqlCommand(entity, Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            Tools.Baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                entity = dr["Genel"].ToString();
            }
            Tools.Baglanti.Close();
            return entity;
        }

    }
}

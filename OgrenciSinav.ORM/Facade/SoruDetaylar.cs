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
            komut.Parameters.AddWithValue("@ogrid", entity.OgrenciID);
            komut.Parameters.AddWithValue("@soruid", entity.SoruID);
            komut.Parameters.AddWithValue("@verilencevap", entity.VerilenCevap);
            komut.Parameters.AddWithValue("@konuid", entity.KonuID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static int IstatistikCek(int KonuID)
        {
            SqlConnection sd = new SqlConnection(@"Data Source=YAKUP\SQLEXPRESS;Initial Catalog=StudentExam;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) as 'Sayac' FROM SoruDetay WHERE KonuID='"+KonuID+"'",sd);
            sd.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                KonuID = (int)dr["Sayac"];
            }
            sd.Close();
            return KonuID;
        }
        public static string GenelIstatistik(string entity)
        {
            SqlConnection sd = new SqlConnection(@"Data Source=YAKUP\SQLEXPRESS;Initial Catalog=StudentExam;Integrated Security=True");
            SqlCommand komut = new SqlCommand(entity, sd);
            komut.CommandType = CommandType.StoredProcedure;
            sd.Open();
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                entity = dr["Genel"].ToString();
            }
            sd.Close();
            return entity;
        }

    }
}

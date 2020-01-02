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
    public class OgrenciDetaylar
    {
        public static bool DetayEkle(OgrenciDetay entity)
        {
            SqlCommand komut = new SqlCommand("OgrenciDetayEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ogrid", entity.OgrenciID);
            komut.Parameters.AddWithValue("@cozulensorusayisi", entity.CozulenSoruSayisi);
            komut.Parameters.AddWithValue("@puan", entity.Puan);
            komut.Parameters.AddWithValue("@dogrusayisi", entity.DogruSayisi);
            komut.Parameters.AddWithValue("@yanlissayisi", entity.YanlisSayisi);
            return Tools.ExecuteNonQuery(komut);
        }
        public static List<OgrenciDetay> SonSinavİst()
        {
            SqlConnection sd = new SqlConnection(@"Data Source=YAKUP\SQLEXPRESS;Initial Catalog=StudentExam;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SonSinavİst", sd);
            komut.CommandType = CommandType.StoredProcedure;
            sd.Open();
            List<OgrenciDetay> listSonuc = new List<OgrenciDetay>();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                OgrenciDetay ogrenci = new OgrenciDetay();
                ogrenci.CozulenSoruSayisi = (int)dr["CozulenSoruSayisi"];
                ogrenci.DogruSayisi = (int)dr["DogruSayisi"];
                ogrenci.YanlisSayisi = (int)dr["YanlisSayisi"];
                ogrenci.Puan = (int)dr["Puan"];
                listSonuc.Add(ogrenci);
            }
            sd.Close();
            return listSonuc;
        }
        public static DataTable OgrenciDetayListele(Ogrenci entity)
        {
            SqlDataAdapter sda = new SqlDataAdapter("OgrenciDetayListele", Tools.Baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}

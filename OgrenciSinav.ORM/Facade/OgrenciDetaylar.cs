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
            return Tools.ExecuteNonQuery(komut);
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

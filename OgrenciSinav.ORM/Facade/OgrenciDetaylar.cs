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
            komut.Parameters.AddWithValue("@tarih", entity.Tarih);
            return Tools.ExecuteNonQuery(komut);
        }
    }
}

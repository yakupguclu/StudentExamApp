using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM.Facade
{
    public class Ogrenciler
    {
        public static DataTable OgrenciListele(Ogrenci entity)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Exec OgrenciListele", Tools.Baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static bool OgrenciEkle(Ogrenci entity)
        {
            SqlCommand komut = new SqlCommand("OgrenciEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@ad", entity.Ad);
            komut.Parameters.AddWithValue("@soyad", entity.Soyad);
            komut.Parameters.AddWithValue("@tckn", entity.TCKN);
            return Tools.ExecuteNonQuery(komut);
        }
    }
}

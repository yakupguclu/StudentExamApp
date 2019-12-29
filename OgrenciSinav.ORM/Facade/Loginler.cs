using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OgrenciSinav.ORM.Facade
{
    public class Loginler
    {
        public static bool GirisKontrol(Ogrenci entity)
        {
            SqlCommand komut = new SqlCommand("LoginKontrol", Tools.Baglanti);
            Tools.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.OgrenciID);
            komut.Parameters.AddWithValue("@p", entity.TCKN);
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                Tools.Baglanti.Close();
                return true;
            }
            else
            {
                Tools.Baglanti.Close();
                return false;
            }
            
        }
    }
}

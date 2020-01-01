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
        public static bool OgretmenGirisKontrol(Ogretmen entity)
        {
            SqlCommand komut = new SqlCommand("OgretmenLoginKontrol", Tools.Baglanti);
            Tools.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", entity.OgretmenID);
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
        public static bool GirisLogEkle(Ogrenci entity)
        {
            SqlCommand komut = new SqlCommand("GirisLogEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id",entity.OgrenciID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static List<Login> OgrBilgiGetir()
        {
            SqlCommand komut = new SqlCommand("OgrBilgiGetir", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            Tools.Baglanti.Open();
            List<Login> listLogin = new List<Login>();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Login login = new Login();
                login.OgrenciID = dr["OgrenciID"].ToString();
                login.Ad = dr["Ad"].ToString();
                login.Soyad = dr["Soyad"].ToString();
                listLogin.Add(login);
            }
            return listLogin;
        }
    }
}

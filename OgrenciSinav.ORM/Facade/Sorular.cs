using OgrenciSinav.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciSinav.ORM.Facade
{
    public class Sorular
    {
        
        public static List<Soru> SoruGetir()
        {
            SqlCommand komut = new SqlCommand("Exec SoruGetir", Tools.Baglanti);
            Tools.Baglanti.Open();
            List<Soru> listSorular = new List<Soru>();
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                Soru entity = new Soru();
                entity.SoruID = (int)dr[0];
                entity.Metin = dr["Metin"].ToString();
                entity.SikA = dr["SikA"].ToString();
                entity.SikB = dr["SikB"].ToString();
                entity.SikC = dr["SikC"].ToString();
                entity.SikD = dr["SikD"].ToString();
                entity.SoruResim = dr["SoruResim"].ToString();
                entity.DogruCevap = dr["DogruCevap"].ToString();
                entity.KonuID = (int)dr["KonuID"];
                listSorular.Add(entity);
            }
            Tools.Baglanti.Close();
            
            SqlCommand komut1 = new SqlCommand("Exec SoruGetirTamamla", Tools.Baglanti);
            Tools.Baglanti.Open();
            dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                Soru entity = new Soru();
                entity.SoruID = (int)dr[0];
                entity.Metin = dr["Metin"].ToString();
                entity.SikA = dr["SikA"].ToString();
                entity.SikB = dr["SikB"].ToString();
                entity.SikC = dr["SikC"].ToString();
                entity.SikD = dr["SikD"].ToString();
                entity.SoruResim = dr["SoruResim"].ToString();
                entity.DogruCevap = dr["DogruCevap"].ToString();
                listSorular.Add(entity);
            }
            Tools.Baglanti.Close();
            return listSorular;
        }
        public static bool SoruEkle(Soru entity)
        {
            SqlCommand komut = new SqlCommand("SoruEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@sresim",entity.SoruResim);
            komut.Parameters.AddWithValue("@sika",entity.SikA);
            komut.Parameters.AddWithValue("@sikb", entity.SikB);
            komut.Parameters.AddWithValue("@sikc", entity.SikC);
            komut.Parameters.AddWithValue("@sikd", entity.SikD);
            komut.Parameters.AddWithValue("@cevap", entity.DogruCevap);
            komut.Parameters.AddWithValue("@metin", entity.Metin);
            komut.Parameters.AddWithValue("@konuid", entity.KonuID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static bool SoruGuncelle(Soru entity)
        {
            SqlCommand komut = new SqlCommand("SoruGuncelle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@sresim", entity.SoruResim);
            komut.Parameters.AddWithValue("@sika", entity.SikA);
            komut.Parameters.AddWithValue("@sikb", entity.SikB);
            komut.Parameters.AddWithValue("@sikc", entity.SikC);
            komut.Parameters.AddWithValue("@sikd", entity.SikD);
            komut.Parameters.AddWithValue("@cevap", entity.DogruCevap);
            komut.Parameters.AddWithValue("@metin", entity.Metin);
            komut.Parameters.AddWithValue("@konuid", entity.KonuID);
            komut.Parameters.AddWithValue("@soruid", entity.SoruID);            
            return Tools.ExecuteNonQuery(komut);
        }
        public static bool SoruSil(Soru entity)
        {
            SqlCommand komut = new SqlCommand("SoruSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@soruid", entity.SoruID);
            return Tools.ExecuteNonQuery(komut);
        }
        public static DataTable SoruListele(Soru entity)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SoruListele", Tools.Baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public static bool AsamaNoGuncelle(int id)
        {
            SqlCommand komut = new SqlCommand("AsamaNoGuncelle",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id", id);
            return Tools.ExecuteNonQuery(komut);
        }

    }
}


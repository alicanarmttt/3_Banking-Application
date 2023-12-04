using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDenemesi
{
    internal class HareketKaydet
    {
        public static void kaydet(int mId, string msj)
        {
            SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
            SqlCommand kmt = new SqlCommand("insert into TblHareketler(musteriID, Islem, tarih) values (@p1, @p2, @p3)",baglanti);
            
            kmt.Parameters.AddWithValue("@p1", mId);
            kmt.Parameters.AddWithValue("@p2", msj);
            kmt.Parameters.AddWithValue("@p3", DateTime.Now);

            baglanti.Open();
            kmt.ExecuteNonQuery();

            baglanti.Close();
        }
    }
}

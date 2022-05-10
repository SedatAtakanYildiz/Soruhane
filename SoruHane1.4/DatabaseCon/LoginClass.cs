using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SoruHane1._4
{
    public class LoginClass
    {
        public int MyProperty { get; set; }
        public bool QueryLogin(string kullaniciadi, string sifre, int tipi)
        {
            //sql'de procedure çalıştırıp gönderilen parametre bilgilerinde kullanıcı olup olmadığı döndürür
            SqlCommand komut = new SqlCommand("exec LoginQuery @p1,@p2,@p3", Datacon.baglanti());
            komut.Parameters.AddWithValue("@p1", tipi);
            komut.Parameters.AddWithValue("@p2", kullaniciadi);
            komut.Parameters.AddWithValue("@p3", sifre);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Global.glbl.OnlineUserId= Convert.ToInt16(dr[0]);
                Global.glbl.OnlineUserName= Convert.ToString(dr[1]);
                Datacon.baglanti().Close();
                return true;
            }
            else
            {
                Datacon.baglanti().Close();
                return false;
            }
        }
    }
}

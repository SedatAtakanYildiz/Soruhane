using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SoruHane1._4
{
    public class QueryClass
    {
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
                glblclass.OnlineUserId = Convert.ToInt16(dr[0]);
                glblclass.OnlineUserNickName = Convert.ToString(dr[1]);
                glblclass.OnlineUserName = Convert.ToString(dr[3]);
                glblclass.OnlineUserSurname = Convert.ToString(dr[4]);
                Datacon.baglanti().Close();
                return true;
            }
            else
            {
                Datacon.baglanti().Close();
                return false;
            }
        }
        public bool ForgotPassword(string kullaniciadi, string mail, string yeniSifre)
        {
            //sql'de procedure çalıştırıp gönderilen parametre bilgilerinde kullanıcı olup olmadığı döndürür
            SqlCommand komut = new SqlCommand("exec ForgotPassword @p1,@p2", Datacon.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciadi);
            komut.Parameters.AddWithValue("@p2", mail);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
               if( ChangePassword(yeniSifre, Convert.ToInt16(dr[0]))==true)
                { return true; }
                else { return false; }
                Datacon.baglanti().Close();
                
            }
            else
            {
                Datacon.baglanti().Close();
                return false;
            }
        }

        public bool ChangePassword(string YeniSifre,int IdUser)
        {
            SqlCommand komut = new SqlCommand("UPDATE tbluser SET UserPass = @p2 WHERE UserID=@p1", Datacon.baglanti());
            komut.Parameters.AddWithValue("@p1", IdUser);
            komut.Parameters.AddWithValue("@p2", YeniSifre);
            int dr = komut.ExecuteNonQuery();
            if (dr != 0)
            {
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

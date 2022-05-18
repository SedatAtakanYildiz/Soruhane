using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SoruHane1._4
{
    public class RegisterClass:UserClass
    {
        public bool QueryRegister()
        {

            //sql'de procedure çalıştırıp gönderilen parametre bilgileri ile kullanıcıyu veritabanına ekler
            SqlCommand komut = new SqlCommand("exec UserRegister @p1,@p2,@p3,@p4,@p5,@p6,@p7", Datacon.baglanti());
            komut.Parameters.AddWithValue("@p1", UserNickName);
            komut.Parameters.AddWithValue("@p2", UserPass);
            komut.Parameters.AddWithValue("@p3", UserTypeId);
            komut.Parameters.AddWithValue("@p4", UserName);
            komut.Parameters.AddWithValue("@p5", UserSurname);
            komut.Parameters.AddWithValue("@p6", UserMail);
            komut.Parameters.AddWithValue("@p7", 0);
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

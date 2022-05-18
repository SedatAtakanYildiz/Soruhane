using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SoruHane1._4
{
    public class UserClass
    {
        public int UserId { get; set; }
        public string UserNickName { get; set; }
        public string UserName { get; set; }
        public string UserSurname{ get; set; }
        public int UserTypeId { get; set; }
        public string UserMail { get; set; }    
        public string UserPass { get; set; }

        public void UserInfoPullDb(int PullUserId)
        {   // Kullanıcı bilgilerini veritabanından çeker
            SqlCommand komut = new SqlCommand("exec PullUserInfo @p1", Datacon.baglanti());
            komut.Parameters.AddWithValue("@p1", PullUserId);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                UserId = Convert.ToInt16(dr[0]);
                UserNickName = Convert.ToString(dr[1]);
                UserPass = Convert.ToString(dr[2]);
                UserTypeId = Convert.ToInt16(dr[3]);
                UserName = Convert.ToString(dr[4]);
                UserSurname = Convert.ToString(dr[5]);
                UserMail = Convert.ToString(dr[6]);

                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }

    }
}

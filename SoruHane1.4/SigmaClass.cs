using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SoruHane1._4
{
    public class SigmaClass
    {
        private int SigmaId { get; set; }   
        private int SigmaUserId { get; set; } = glblclass.OnlineUserId;
        public int Sigma1 { get; set; }
        public int Sigma2 { get; set; }
        public int Sigma3 { get; set; }
        public int Sigma4 { get; set; }
        public int Sigma5 { get; set; }

        public void SigmaPull()
        {   // öğrenciye ait olan sigma süre değerlerini çeker
            SqlCommand komut = new SqlCommand("SELECT * FROM tblSigmaStudent Where UserId=@p1", Datacon.baglanti());
            komut.Parameters.AddWithValue("@p1", SigmaUserId);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SigmaId= Convert.ToInt16(dr[0]);
                Sigma1 = Convert.ToInt16(dr[2]);
                Sigma2 = Convert.ToInt16(dr[3]);
                Sigma3 = Convert.ToInt16(dr[4]);
                Sigma4 = Convert.ToInt16(dr[5]);
                Sigma5 = Convert.ToInt16(dr[6]);

                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }
        public bool SigmaChange()
        {   //Öğrencin gönderdiği sigma süre değerlerini veritabanına kaydeder
                SqlCommand komut = new SqlCommand("EXEC SigmaChange @userId,@s1,@s2,@s3,@s4,@s5", Datacon.baglanti());
                komut.Parameters.AddWithValue("@userId", SigmaUserId);
                komut.Parameters.AddWithValue("@s1", Sigma1);
                komut.Parameters.AddWithValue("@s2", Sigma2);
                komut.Parameters.AddWithValue("@s3", Sigma3);
                komut.Parameters.AddWithValue("@s4", Sigma4);
                komut.Parameters.AddWithValue("@s5", Sigma5);

            int cmd = komut.ExecuteNonQuery();
                if (cmd != 0)
                {
                Datacon.baglanti().Close();
                return true; 
                
                }
            else { return false; }
            
        }

    }
}

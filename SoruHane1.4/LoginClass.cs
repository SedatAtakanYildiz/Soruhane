using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SoruHane1._4.DatabaseCon
{
    public class LoginClass
    {
        public bool QueryLogin(string posta, string sifre, int tipi)
        {
            SqlCommand komut = new SqlCommand("exec LoginQuery @p1,@p2,@p3", Datacon.baglanti());
            komut.Parameters.AddWithValue("@p1", posta);
            komut.Parameters.AddWithValue("@p2", sifre);
            komut.Parameters.AddWithValue("@p3", tipi);
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

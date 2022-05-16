using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SoruHane1._4
{
    public static class Datacon
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-S2JDHI8\\;Initial Catalog=SinavSistemi;Integrated Security=True"); //Veri tabanına bağlanıyor
            baglan.Open();
            return baglan;
        }
    }
}

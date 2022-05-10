using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SoruHane1._4.DatabaseCon
{
    public static class Datacon
    {
        public static SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-HRC1BT6\\;Initial Catalog=OtelRez;Integrated Security=True"); //Veri tabanına bağlanıyor
            baglan.Open();
            return baglan;
        }
    }
}

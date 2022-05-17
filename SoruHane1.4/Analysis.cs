using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SoruHane1._4
{
    public class Analysis
    {
        private int UserId { get; set; } = glblclass.OnlineUserId;
        public string UnitName { get; set; }
        public int Correct { get; set; }
        public int Incorrect { get; set; }
        public List<Analysis> AnalysisCorrect = new List<Analysis>();
        public List<Analysis> AnalysisInCorrect = new List<Analysis>();
        public void PullAnalysisCorrect()
        {
            SqlCommand komut = new SqlCommand("EXEC AnalysisUnitCorrect " + glblclass.OnlineUserId, Datacon.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            
            
                while (dr.Read()==true)
                {
                    Analysis s = new Analysis();
                    s.UnitName = Convert.ToString(dr[0]);
                    s.Correct = Convert.ToInt16(dr[1]);
                    AnalysisCorrect.Add(s);
                }

                Datacon.baglanti().Close();
            
            

        }
        public void PullAnalysisInCorrect()
        {
            SqlCommand komut = new SqlCommand("EXEC AnalysisUnitInCorrect " + glblclass.OnlineUserId, Datacon.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    Analysis s = new Analysis();
                    s.UnitName = Convert.ToString(dr[0]);
                    s.Incorrect = Convert.ToInt16(dr[1]);
                    AnalysisInCorrect.Add(s);
                }
                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }

        }

    }
}

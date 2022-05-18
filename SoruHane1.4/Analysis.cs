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
        private int UnitId { get; set; }
        public string UnitName { get; set; }
        public int Correct { get; set; }
        public int Incorrect { get; set; }

        public List<Analysis> AnalysisList = new List<Analysis>(); // Uniteleri liste halinde tutup verileri işleyebilmemiz için oluşturuldu

        public void PullAnalysis()
        {

            SqlCommand komut = new SqlCommand("select * from tblunit", Datacon.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            { //Veritabanından Uniteler tablosunu okur 
                Analysis s = new Analysis();
                s.UnitId = Convert.ToInt16(dr[0]); //gelen değeri unit ıd olarak kayıt eder
                s.UnitName = Convert.ToString(dr[1]); //gelen değeri unit name olarak kayıt eder

                SqlCommand komut2 = new SqlCommand("EXEC AnalysisUnitCorrect @p1,@p2", Datacon.baglanti()); //Gönderilen ıd e sahip Unitenin doğru saysısını getirir
                komut2.Parameters.AddWithValue("@p1", glblclass.OnlineUserId);
                komut2.Parameters.AddWithValue("@p2",s.UnitId);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if(dr2.Read() == true)
                {
                    s.Correct = Convert.ToInt16(dr2[1]); 
                }
                else { s.Correct = 0; }

                SqlCommand komut3 = new SqlCommand("EXEC AnalysisUnitInCorrect @p1,@p2", Datacon.baglanti());//Gönderilen ıd e sahip Unitenin yanlış saysısını getirir
                komut3.Parameters.AddWithValue("@p1", glblclass.OnlineUserId);
                komut3.Parameters.AddWithValue("@p2", s.UnitId);
                SqlDataReader dr3 = komut3.ExecuteReader();
                if (dr3.Read() == true)
                {
                    s.Incorrect = Convert.ToInt16(dr3[1]);
                }
                else { s.Incorrect = 0; }
                AnalysisList.Add(s); // oluşturulan nesneyeyi listeye ekler



            }
            Datacon.baglanti().Close();

           
            

        }
    }
}

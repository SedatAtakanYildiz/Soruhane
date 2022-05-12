using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SoruHane1._4
{
    public class QuestionClass
    {
        public int QuestionId { get; set; }
        public string QuestionImgPath { get; set; }
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public int UnitId { get; set; }
        public int IsOk { get; set; }   
        public char AnswerCorrect { get; set; } 

        public bool QuestionAdd()
        {
            SqlCommand komut = new SqlCommand("exec AddQuestion @path,@qtext,@AnswerA,@AnswerB,@AnswerC,@Answerd,@unitid,@isOk,@AnswerCorrect", Datacon.baglanti());
            komut.Parameters.AddWithValue("@path", QuestionImgPath);
            komut.Parameters.AddWithValue("@qtext", QuestionText);
            komut.Parameters.AddWithValue("@AnswerA", AnswerA);
            komut.Parameters.AddWithValue("@AnswerB", AnswerB);
            komut.Parameters.AddWithValue("@AnswerC", AnswerC);
            komut.Parameters.AddWithValue("@AnswerD", AnswerD);
            komut.Parameters.AddWithValue("@unitid", UnitId);
            komut.Parameters.AddWithValue("@isOk", IsOk);
            komut.Parameters.AddWithValue("@AnswerCorrect", AnswerCorrect);
            int cmd = komut.ExecuteNonQuery();
            if (cmd != null)
            {
                Datacon.baglanti().Close();
                return true;
            }
            else { return false; }

        }
    }
}

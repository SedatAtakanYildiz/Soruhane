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
        public int IsOk { get; set; } = 0;   
        public char AnswerCorrect { get; set; }
        public char AnswerStudent { get; set; }
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
            if (cmd != 0)
            {
                Datacon.baglanti().Close();
                return true;
            }
            else { return false; }

        }
        public void QuestionOk(int questionId)
        {
            SqlCommand komut = new SqlCommand("EXEC QuestionOk @QuestionId,@isOk", Datacon.baglanti());
            komut.Parameters.AddWithValue("@QuestionId", questionId);
            komut.Parameters.AddWithValue("@isOk", 1);
            int cmd = komut.ExecuteNonQuery();
            if (cmd != 0)
            {
                Datacon.baglanti().Close();
            }
            else {  }
        }
        public void QuestionNo(int questionId)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM tblquestions WHERE questionID=@QuestionId", Datacon.baglanti());
            komut.Parameters.AddWithValue("@QuestionId", questionId);
            int cmd = komut.ExecuteNonQuery();
            if (cmd != 0)
            {
                Datacon.baglanti().Close();
            }
            else { }
        }
        public void QuestionPull(int PullIsOk)
        {
            SqlCommand komut = new SqlCommand("EXEC QuestionPull @IsOk", Datacon.baglanti());
            komut.Parameters.AddWithValue("@IsOk", PullIsOk);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                QuestionId = Convert.ToInt16(dr[0]);
                QuestionText = Convert.ToString(dr[1]);
                QuestionImgPath = Convert.ToString(dr[2]);
                AnswerA = Convert.ToString(dr[3]);
                AnswerB = Convert.ToString(dr[4]);
                AnswerC = Convert.ToString(dr[5]);
                AnswerD = Convert.ToString(dr[6]);
                UnitId = Convert.ToInt16(dr[7]);
                IsOk = Convert.ToInt16(dr[8]);
                AnswerCorrect = Convert.ToChar(dr[9]);
                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }

    }
}

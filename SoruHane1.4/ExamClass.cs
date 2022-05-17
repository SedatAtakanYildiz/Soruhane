using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SoruHane1._4
{
    public class ExamClass : QuestionClass
    {
        public int ExamDetailId { get; set; }   // exam class
        public int isCorrect { get; set; }  //exam class

        public List<ExamClass> soru = new List<ExamClass>();
        public void SoruCek()
        {
            SqlCommand komut = new SqlCommand("EXEC PullForSigmaAllQuestion " + glblclass.OnlineUserId, Datacon.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    if (soru.Count > 10) { break; }
                    ExamClass s = new ExamClass();
                    s.QuestionId = Convert.ToInt16(dr[0]);
                    s.QuestionText = Convert.ToString(dr[1]);
                    s.QuestionImgPath = Convert.ToString(dr[2]);
                    s.AnswerA = Convert.ToString(dr[3]);
                    s.AnswerB = Convert.ToString(dr[4]);
                    s.AnswerC = Convert.ToString(dr[5]);
                    s.AnswerD = Convert.ToString(dr[6]);
                    s.AnswerCorrect = Convert.ToChar(dr[7]);
                    soru.Add(s);
                }

                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }

            SqlCommand SigmaSorguPull = new SqlCommand("EXEC PullForSigma @userId", Datacon.baglanti());
            SigmaSorguPull.Parameters.AddWithValue("@userId", glblclass.OnlineUserId);
            SqlDataReader drSgm = SigmaSorguPull.ExecuteReader();
            if (drSgm.Read())
            {
                while (drSgm.Read())
                {
                    ExamClass s = new ExamClass();
                    s.QuestionId = Convert.ToInt16(drSgm[0]);
                    s.QuestionText = Convert.ToString(drSgm[1]);
                    s.QuestionImgPath = Convert.ToString(drSgm[2]);
                    s.AnswerA = Convert.ToString(drSgm[3]);
                    s.AnswerB = Convert.ToString(drSgm[4]);
                    s.AnswerC = Convert.ToString(drSgm[5]);
                    s.AnswerD = Convert.ToString(drSgm[6]);
                    s.AnswerCorrect = Convert.ToChar(drSgm[7]);
                    s.isCorrect = Convert.ToInt16(drSgm[8]);
                    s.ExamDetailId = Convert.ToInt16(drSgm[9]);
                    soru.Add(s);

                }

                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }
        public void SinavBitir()
        {
            int ExamId;
            SqlCommand komut = new SqlCommand("INSERT INTO tblexam (userID,examDate) values(@userId, GETDATE()) SELECT SCOPE_IDENTITY()", Datacon.baglanti());
            komut.Parameters.AddWithValue("@userId", glblclass.OnlineUserId);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                ExamId = Convert.ToInt16(dr[0]);// gelen Sınav Idsini tutuyoruz
                for (int i = 0; i < soru.Count; i++)
                {

                    if (i < 10)
                    {
                        SqlCommand komut2 = new SqlCommand("INSERT INTO tblexamdetail(examID,questionID,answer,isCorrect) VALUES(@examId, @questionId, @answer, @isCorrect)", Datacon.baglanti());
                        komut2.Parameters.AddWithValue("@examId", ExamId);
                        komut2.Parameters.AddWithValue("@questionId", soru[i].QuestionId);
                        if (soru[i].AnswerCorrect == soru[i].AnswerStudent) { komut2.Parameters.AddWithValue("@answer", 1); komut2.Parameters.AddWithValue("@isCorrect", 1); }
                        else { komut2.Parameters.AddWithValue("@answer", 0); komut2.Parameters.AddWithValue("@isCorrect", 0); }
                        int cmd = komut2.ExecuteNonQuery();
                        if (cmd != 0)
                        {
                            Datacon.baglanti().Close();
                        }
                    }

                    else
                    {

                        SqlCommand komut3 = new SqlCommand("EXEC ChangeForSigma @examDetailId,@isCorrect", Datacon.baglanti());
                        komut3.Parameters.AddWithValue("@examDetailId", soru[i].ExamDetailId);
                        if (soru[i].AnswerCorrect == soru[i].AnswerStudent)
                        { int NewIsCorrect = soru[i].isCorrect + 1; komut3.Parameters.AddWithValue("@isCorrect", soru[i].isCorrect + 1); }
                        else { komut3.Parameters.AddWithValue("@isCorrect", 0); }
                        int cmd2 = komut3.ExecuteNonQuery();
                        if (cmd2 != 0)
                        {
                            Datacon.baglanti().Close();
                        }
                    }

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

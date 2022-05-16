using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoruHane1._4.OgrFormlar
{
    public partial class FrmSerbestSinav : Form
    {
        private Button gecerliBtn;
        private char ogrenciCevap;
        private int soruSira = 0;
        public FrmSerbestSinav()
        {
            InitializeComponent();
        }
        List<QuestionClass> soru = new List<QuestionClass>();

        
        private void FrmSerbestSinav_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT TOP 11 * FROM tblquestions ORDER BY NEWID()", Datacon.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    QuestionClass s = new QuestionClass();
                    s.QuestionId = Convert.ToInt16(dr[0]);
                    s.QuestionText = Convert.ToString(dr[1]);
                    s.QuestionImgPath = Convert.ToString(dr[2]);
                    s.AnswerA = Convert.ToString(dr[3]);
                    s.AnswerB = Convert.ToString(dr[4]);
                    s.AnswerC = Convert.ToString(dr[5]);
                    s.AnswerD = Convert.ToString(dr[6]);
                    s.AnswerCorrect = Convert.ToChar(dr[9]);
                    soru.Add(s);

                }

                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
        }    
        //metodlar
        public void SoruGetir()
        {

            if (soruSira < soru.Count)
            {
                TxtSoru.Text = soruSira + 1 + "-)" + soru[soruSira].QuestionText;
                BtnA.Text = soru[soruSira].AnswerA;
                btnB.Text = soru[soruSira].AnswerB;
                BtnC.Text = soru[soruSira].AnswerC;
                BtnD.Text = soru[soruSira].AnswerD;
                if (soru[soruSira].QuestionImgPath != null)
                {
                    pictureSoru.ImageLocation = soru[soruSira].QuestionImgPath;
                }
                ++soruSira;
            }
            else
            {

                TxtSoru.Text = "Soruları göndermek için sınavı bitir butonuna basınız!";
                tusKontrol();
            }
            

        }
        public void tusKontrol (){
            BtnA.Visible = false;
            btnB.Visible = false;
            BtnC.Visible = false;
            BtnD.Visible = false;
            pictureSoru.Visible = false;
            BtnSinavilerle.Visible = false;
        }
        private void SeciliTus(object btnsender)
        {
            if (btnsender != null)
            {
                if (gecerliBtn != (Button)btnsender)
                {
                    VarsayilanaDon();
                    gecerliBtn = (Button)btnsender;
                    gecerliBtn.BackColor = Color.FromArgb(35, 35, 50);
                }
            }
        }
        private void VarsayilanaDon()
        {
            foreach (Control oncekiBtn in PnlCevap.Controls)
            {
                if (oncekiBtn.GetType() == typeof(Button))
                {
                    oncekiBtn.BackColor = Color.FromArgb(39, 39, 58);
                }
            }
        }
        //butonlar
        private void BtnSinavBasla_Click_1(object sender, EventArgs e)
        {
            BtnSinavBasla.Visible = false;
            BtnA.Visible = true;
            btnB.Visible = true;
            BtnC.Visible = true;
            BtnD.Visible = true;
            BtnSinavilerle.Visible = true;
            BtnSinavBitir.Visible = true;
            SoruGetir();
        }

        private void BtnA_Click_1(object sender, EventArgs e)
        {
            SeciliTus(sender);
            ogrenciCevap = 'A';
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            SeciliTus(sender);
            ogrenciCevap = 'B';
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            SeciliTus(sender);
            ogrenciCevap = 'C';
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            SeciliTus(sender);
            ogrenciCevap = 'D';
        }

        private void BtnSinavilerle_Click_1(object sender, EventArgs e)
        {
            gecerliBtn = null;
            SeciliTus(sender);
            soru[soruSira - 1].AnswerStudent = ogrenciCevap;
            SoruGetir();
        }

        private void BtnSinavBitir_Click_1(object sender, EventArgs e)
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
                    SqlCommand komut2 = new SqlCommand("INSERT INTO tblexamdetail(examID,questionID,answer,isCorrect) VALUES(@examId, @questionId, @answer, @isCorrect)", Datacon.baglanti());
                    komut2.Parameters.AddWithValue("@examId", ExamId);
                    komut2.Parameters.AddWithValue("@questionId", soru[i].QuestionId);
                    if (soru[i].AnswerCorrect == soru[i].AnswerStudent) { komut2.Parameters.AddWithValue("@answer", 1); komut2.Parameters.AddWithValue("@isCorrect", 3); }
                    else { komut2.Parameters.AddWithValue("@answer", 0); komut2.Parameters.AddWithValue("@isCorrect", 0); }
                    int cmd = komut2.ExecuteNonQuery();
                    if (cmd != 0)
                    {
                        Datacon.baglanti().Close();

                    }
                }
                TxtSoru.Text = "Sınavınız başarıyla gönderilmiştir";
                Datacon.baglanti().Close();
            }
            else
            {
                TxtSoru.Text = "Sistemsel Bir Arza Çıkmıştır Sınavınız İptal Edilmiştir";
                Datacon.baglanti().Close();
            }
            BtnSinavBitir.Visible = false;
            tusKontrol();
        }
    }
}

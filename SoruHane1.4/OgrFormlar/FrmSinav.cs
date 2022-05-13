using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SoruHane1._4.OgrFormlar
{
    public partial class FrmSinav : Form
    {
        private char ogrenciCevap;
        private int soruSira=1;
        public FrmSinav()
        {
            InitializeComponent();
        }
        List<QuestionClass> soru = new List<QuestionClass>();
        private void FrmSinav_Load(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("SELECT TOP 7 * FROM tblquestions ORDER BY NEWID()", Datacon.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    QuestionClass s = new QuestionClass();
                    s.QuestionId= Convert.ToInt16(dr[0]);
                    s.QuestionText= Convert.ToString(dr[1]);
                    s.QuestionImgPath = Convert.ToString(dr[2]);
                    s.AnswerA = Convert.ToString(dr[3]);
                    s.AnswerB = Convert.ToString(dr[4]);
                    s.AnswerC = Convert.ToString(dr[5]);
                    s.AnswerD = Convert.ToString(dr[6]);
                    s.AnswerCorrect = Convert.ToChar(dr[9]);
                    s.AnswerCorrect = Convert.ToChar(dr[9]);
                    soru.Add(s);
                }
                Datacon.baglanti().Close();
            }
            else
            {
                Datacon.baglanti().Close();
            }
            TxtSoru.Text = soruSira + "-)" + soru[soruSira].QuestionText;
            BtnA.Text = soruSira + "-)" + soru[soruSira].AnswerA;
            btnB.Text = soruSira + "-)" + soru[soruSira].AnswerB;
            BtnC.Text = soruSira + "-)" + soru[soruSira].AnswerC;
            BtnD.Text = soruSira + "-)" + soru[soruSira].AnswerD;
            pictureSoru.ImageLocation = soru[soruSira].QuestionImgPath;
            //MessageBox.Show("Soru Id: " + soru[0].QuestionId + "\n" +
            //        "Soru Yazısı: " + soru[0].QuestionText + "\n" +
            //        "Soru Fotoğraf yolu: " + soru[0].QuestionImgPath + "\n" +
            //        "A şıkı: " + soru[0].AnswerA + "\n" +
            //        "B şıkı:: " + soru[0].AnswerB + "\n" +
            //        "C şıkı: " + soru[0].AnswerC + "\n" +
            //        "D şıkı:: " + soru[0].AnswerD + "\n");
            //for (int i = 0; i < 4; i++)
            //{
            //    MessageBox.Show("Soru Id: " + soru[i].QuestionId + "\n" +
            //        "Soru Yazısı: " + soru[i].QuestionText + "\n" +
            //        "Soru Fotoğraf yolu: " + soru[i].QuestionImgPath + "\n" +
            //        "A şıkı: " + soru[i].AnswerA + "\n" +
            //        "B şıkı:: " + soru[i].AnswerB + "\n" +
            //        "C şıkı: " + soru[i].AnswerC + "\n" +
            //        "D şıkı:: " + soru[i].AnswerD + "\n");
            //}

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            ogrenciCevap = 'A';
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            ogrenciCevap = 'B';
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            ogrenciCevap = 'C';
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            ogrenciCevap = 'D';
        }

        private void BtnSinavilerle_Click(object sender, EventArgs e)
        {
            soruSira++;
            if(soruSira<5)
            {
                TxtSoru.Text = soruSira + "-)" + soru[soruSira].QuestionText;
                BtnA.Text = soru[soruSira].AnswerA;
                btnB.Text = soru[soruSira].AnswerB;
                BtnC.Text = soru[soruSira].AnswerC;
                BtnD.Text = soru[soruSira].AnswerD;
                pictureSoru.ImageLocation = soru[soruSira].QuestionImgPath;
            }
          
        }
    }
}

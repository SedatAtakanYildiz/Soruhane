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
    public partial class FrmSinav : Form
    {
        private Button gecerliBtn;
        private char ogrenciCevap;
        private int soruSira = 0;
        private int Sayac = 60;
        ExamClass exam = new ExamClass();
        public FrmSinav()
        {
            InitializeComponent();
        }
        private void FrmSinav_Load(object sender, EventArgs e)
        {

      
        exam.SigmaSoruCek();// Sigma prensiplerine uygunsa soruyu getirir
        }

        private void BtnA_Click(object sender, EventArgs e)
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

        private void BtnSinavBasla_Click_1(object sender, EventArgs e)
        {
            BtnSinavBasla.Visible = false;
            BtnA.Visible = true;
            btnB.Visible = true;
            BtnC.Visible = true;
            BtnD.Visible = true;
            BtnSinavilerle.Visible = true;
            BtnSinavBitir.Visible = true;
            lblZaman.Visible = true;
            pictureZaman.Visible = true;
            SoruGetir();
        }

        private void BtnSinavilerle_Click_1(object sender, EventArgs e)
        {
            gecerliBtn = null;
            SeciliTus(sender);
            exam.soru[soruSira - 1].AnswerStudent = ogrenciCevap;
            SoruGetir();

        }

        private void BtnSinavBitir_Click_1(object sender, EventArgs e)
        {
            TmrSoruSuresi.Stop();
            exam.SinavBitir();
            BtnSinavBitir.Visible = false;
            TusKontrol();
        }
        //metodlar
        private void SoruGetir()
        {

            if (soruSira < exam.soru.Count)
            {
                TxtSoru.Text = soruSira + 1 + "-)" + exam.soru[soruSira].QuestionText;
                BtnA.Text = exam.soru[soruSira].AnswerA;
                btnB.Text = exam.soru[soruSira].AnswerB;
                BtnC.Text = exam.soru[soruSira].AnswerC;
                BtnD.Text = exam.soru[soruSira].AnswerD;
                if (exam.soru[soruSira].QuestionImgPath != null)
                {
                    pictureSoru.ImageLocation = exam.soru[soruSira].QuestionImgPath;
                }
            }
            else
            {

                TxtSoru.Text = "Soruları göndermek için sınavı bitir butonuna basınız!";
                TusKontrol();

            }
            ++soruSira;
            ZamanKnt();

        }
        private void TusKontrol()
        {
            BtnA.Visible = false;
            btnB.Visible = false;
            BtnC.Visible = false;
            BtnD.Visible = false;
            pictureSoru.Visible = false;
            BtnSinavilerle.Visible = false;
            pictureZaman.Visible = false;
            lblZaman.Visible = false;
        }
        private void SeciliTus(object btnsender)
        {
            if(btnsender != null)
            {
                if(gecerliBtn != (Button)btnsender)
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
        private void ZamanKnt()
        {
            Sayac = 60;
            TmrSoruSuresi.Start();
        }

        private void TmrSoruSuresi_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = Sayac.ToString();
            Sayac--; 
            if (Sayac == 0)
            {
                TmrSoruSuresi.Stop();
                BtnSinavilerle_Click_1(BtnSinavilerle, new EventArgs());
            }
        }
    }
        
    }

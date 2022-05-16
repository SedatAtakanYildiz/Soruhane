using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHane1._4.adminFormlar
{
    public partial class frmSoruOnayla : Form
    {
        public frmSoruOnayla()
        {
            InitializeComponent();
        }
        QuestionClass ques = new QuestionClass();
        private void SoruGetir()
        {
            ques.QuestionPull(0);
            TxtSoru.Text = ques.QuestionText;
            pictureSoru.ImageLocation = ques.QuestionImgPath;
            BtnA.Text = ques.AnswerA;
            btnB.Text = ques.AnswerB;
            BtnC.Text = ques.AnswerC;
            BtnD.Text = ques.AnswerD;
        }
        private void btnSoruGor_Click(object sender, EventArgs e)
        {
            btnSoruGor.Visible = false;
            BtnA.Visible = true;
            btnB.Visible = true;
            BtnC.Visible = true;
            BtnD.Visible = true;
            btnOnaylama.Visible = true;
            BtnOnay.Visible = true;
            btnBitir.Visible = true;
            SoruGetir();
        }

        private void BtnOnay_Click(object sender, EventArgs e)
        {
           ques.QuestionOk(ques.QuestionId);
            SoruGetir();
        }
    }
}

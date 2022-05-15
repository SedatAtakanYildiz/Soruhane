using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHane1._4
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            RegisterClass rgstrc =new RegisterClass();
            rgstrc.UserName = textIsim.Text;
            rgstrc.UserSurname=textSoyIsim.Text;
            rgstrc.UserNickName = textKullaniciAd.Text;
            rgstrc.UserPass=textSifre.Text;
            rgstrc.UserMail = textEposta.Text;
            rgstrc.UserTypeId = 3;
            if(rgstrc.QueryRegister()==true)
            {
                FrmLogin Lgn = new FrmLogin();
                Lgn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata oluştu lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}

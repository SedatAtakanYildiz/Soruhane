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
    public partial class FrmAdmin_sorumuKayıt : Form
    {
        int tip;
        public FrmAdmin_sorumuKayıt()
        {
            InitializeComponent();
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            if (RdAdmin.Checked==true)
            {
                tip = 1;
                kayit();
            }
            else if (RdSorumlu.Checked == true) { 
                tip = 2;
                kayit();
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir Kullanıcı Tipi Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodlar
        private void kayit()
        {
            RegisterClass rgstrc = new RegisterClass();
            rgstrc.UserName = textIsim.Text;
            rgstrc.UserSurname = textSoyIsim.Text;
            rgstrc.UserNickName = textKullaniciAd.Text;
            rgstrc.UserPass = textSifre.Text;
            rgstrc.UserMail = textEposta.Text;
            rgstrc.UserTypeId = tip;
            if (rgstrc.QueryRegister() == true)
            {
                MessageBox.Show("Kaydınız onaylanmıştır.", "Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else
            {
                MessageBox.Show("Hata oluştu lütfen daha sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

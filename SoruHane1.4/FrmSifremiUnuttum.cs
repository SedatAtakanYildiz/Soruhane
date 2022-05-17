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
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if ((txtYeniSifre.Text == txtSifreTekrar.Text))
            {
                QueryClass querycls = new QueryClass(); 
                if (querycls.ForgotPassword(txtKullaniciAd.Text, txtMail.Text,txtYeniSifre.Text) == true) {
                    MessageBox.Show("Şifreniz Başarıyla Değiştirilmiştir.", "Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Girdiğiniz Bilgiler Uyuşmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FrmLogin Lgn = new FrmLogin();
                Lgn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Yeni Şifreler Uyuşmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

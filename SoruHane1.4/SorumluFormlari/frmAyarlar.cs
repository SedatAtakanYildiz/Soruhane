using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHane1._4.SorumluFormlari
{
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            UserClass usrcls=new UserClass();
            usrcls.UserInfoPullDb(glblclass.OnlineUserId);
            if ((txtYeniSifre.Text == txtTekrarSifre.Text)&&TxtEskiSifre.Text==usrcls.UserPass)
            {
                QueryClass querycls=new QueryClass();  
                if(querycls.ChangePassword(txtYeniSifre.Text, glblclass.OnlineUserId) ==true)
                { 
                MessageBox.Show("Şifreniz Başarıyla Güncellenmiştir", "İşlem Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Sistemsel bir hata oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else { MessageBox.Show("Şifreleriniz Eşleşememektedir Lütfen Bilgilerinizin Doğruluğunu Kontrol Ediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
    }
}

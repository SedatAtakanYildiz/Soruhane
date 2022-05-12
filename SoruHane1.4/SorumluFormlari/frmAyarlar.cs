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
            //umut sql bağlantısı gerek yine ben becerremedim şimdilik senin querylerle yapamadım
            //ifin yanında && komutu ile txtEskiSifre ile adamın ıd sindeki sifreninde karşılaştırılıp yeni şifrenin atanması gerekiyor.
            if ((txtYeniSifre.Text == txtTekrarSifre.Text))
            {
                MessageBox.Show("Şifreniz Başarıyla Güncellenmiştir", "İşlem Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Şifreleriniz Eşleşememektedir Lütfen Bilgilerinizin Doğruluğunu Kontrol Ediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
    }
}

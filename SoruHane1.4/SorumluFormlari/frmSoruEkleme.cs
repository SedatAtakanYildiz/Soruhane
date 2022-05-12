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
    public partial class frmSoruEkleme : Form
    {
        //alanlar
        private char dogruCevap; 
        public frmSoruEkleme()
        {
            InitializeComponent();
        }

        private void TxtA_Click(object sender, EventArgs e)
        {
            TxtA.Text = "";
        }

        private void txtB_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
        }

        private void txtC_Click(object sender, EventArgs e)
        {
            txtC.Text = "";
        }

        private void TxtD_Click(object sender, EventArgs e)
        {
            TxtD.Text = "";
        }

        private void TxtSoru_Click(object sender, EventArgs e)
        {
            TxtSoru.Text = "";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            dogruCevap = 'A';
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            dogruCevap = 'B';
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            dogruCevap = 'C';
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            dogruCevap = 'D';
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            TxtSoru.Text = "Lütfen sorunuzu bu alana giriniz.";
            TxtA.Text = "A şıkkını giriniz";
            txtB.Text = "B şıkkını giriniz";
            txtC.Text = "C şıkkını giriniz";
            TxtD.Text = "D şıkkını giriniz";
            cmbUnute.Text = "Lütfen Üniteyi Seçiniz";
            dogruCevap = ' ';
            
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {

            if ((TxtSoru.Text == "") || (TxtSoru.Text == "Lütfen sorunuzu bu alana giriniz."))
            {
                MessageBox.Show("Lütfen Geçerli Bir Soru Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temizle();
            }
            else
            {
                //sql kodu alanı else içinde yoksa döngüye giriyor
                //UMUTA NOT!!!!!!!!!!
                //doğru Cevap diye bir char değişkeni var yukarda onu kullan
                //sql kodlarını bunun üstüne yaz temizlenin altında kalırsa soru silinir (notu okuduktan sonra bu açıklamayı siliniz)
                MessageBox.Show("Sorunuz Başarıyla eklenmiştir", "İşlem Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }
    }
}

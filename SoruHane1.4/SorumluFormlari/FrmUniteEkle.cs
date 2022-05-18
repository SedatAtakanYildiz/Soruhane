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
    public partial class FrmUniteEkle : Form
    {
        public FrmUniteEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUniteEkle.Text != "")
            {
                QueryClass query=new QueryClass();
                if(query.AddUnit(txtUniteEkle.Text)==true) { MessageBox.Show("Unite başarı ile eklendi"); }
                else { MessageBox.Show("Sistemsel bir hata oluştu lütfen daha sonra tekrar deneyiniz"); }
            }
            else { MessageBox.Show("Ünite Adını Boş bıraktınız"); }
        }

        private void txtUniteEkle_Click(object sender, EventArgs e)
        {
            txtUniteEkle.Text = "";
        }
    }
}

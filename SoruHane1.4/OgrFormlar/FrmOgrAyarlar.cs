using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruHane1._4.OgrFormlar
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        SigmaClass sgmcls = new SigmaClass();   
        private void SigmaCek()
        {
            sgmcls.SigmaPull();
            TxtSigma1.Text =Convert.ToString(sgmcls.Sigma1);
            TxtSigma2.Text = Convert.ToString(sgmcls.Sigma2);
            TxtSigma3.Text = Convert.ToString(sgmcls.Sigma3);
            TxtSigma4.Text = Convert.ToString(sgmcls.Sigma4);
            TxtSigma5.Text = Convert.ToString(sgmcls.Sigma5);
        }
        private void BtnOnay_Click(object sender, EventArgs e)
        {
            sgmcls.Sigma1=Convert.ToInt16(TxtSigma1.Text);
            sgmcls.Sigma2=Convert.ToInt16(TxtSigma2.Text);  
            sgmcls.Sigma3=Convert.ToInt16(TxtSigma3.Text);
            sgmcls.Sigma4=Convert.ToInt16(TxtSigma4.Text);
            sgmcls.Sigma5=Convert.ToInt16(TxtSigma5.Text);
            if (sgmcls.SigmaChange() == true) MessageBox.Show("Sigma prensipleri tarihleri güncellenmiştir.");
            else MessageBox.Show("Bir sorun oluştu lütfen daha sonra tekrar deneyiniz.");
            SigmaCek();

        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            SigmaCek();
        }
    }
}

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
        }
    }
}

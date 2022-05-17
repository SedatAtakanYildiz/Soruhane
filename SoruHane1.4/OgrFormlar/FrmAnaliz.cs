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
    public partial class FrmAnaliz : Form
    { private string[] üniteler = { "ünite1", "ünite2", "ünite3", "ünite4", "ünite5", "ünite6" };
        private int[] dogrular = {10,8,5,15,13,10};
        private int [] yanlislar = {3,7,8,3,13,1}; 
        private int sayac = 0;
        public FrmAnaliz()
        {
            InitializeComponent();
        }

        private void BtnDogruYanlis_Click(object sender, EventArgs e)
        {
            
            if (sayac == 0) { 
            chartDogruYanlis.Visible = true;
            for(int i = 0; i < üniteler.Length; i++)
            {
                chartDogruYanlis.Series["Doğru"].Points.AddXY(üniteler[i], dogrular[i]);
                chartDogruYanlis.Series["Yanlış"].Points.AddXY(üniteler[i], yanlislar[i]);
            }
                sayac++;
            }

        }

        private void FrmAnaliz_Load(object sender, EventArgs e)
        {
           for (int i = 0; i < üniteler.Length; i++)
            {
                ChartUnite.Series["ünite1"].Points.AddXY(üniteler[i],dogrular[i]);
            }
            


        }
    }
}

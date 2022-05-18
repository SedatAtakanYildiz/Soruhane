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
    { 
        Analysis anls = new Analysis();
        public FrmAnaliz()
        {
            InitializeComponent();
        }

        private void BtnDogruYanlis_Click(object sender, EventArgs e)
        {
            
            chartDogruYanlis.Visible = true;
            for (int i = 0; i < anls.AnalysisList.Count; i++)
            {   // AnalysisList listesinde kayıtlı olan ünitelerin doğru yanlış sayılarını chart'a aktarır
                chartDogruYanlis.Series["Doğru"].Points.AddXY(anls.AnalysisList[i].UnitName, anls.AnalysisList[i].Correct);
                chartDogruYanlis.Series["Yanlış"].Points.AddXY(anls.AnalysisList[i].UnitName, anls.AnalysisList[i].Incorrect);
            }
            BtnDogruYanlis.Visible=false;

        }

        private void FrmAnaliz_Load(object sender, EventArgs e)
        {

            anls.PullAnalysis();
            for (int i = 0; i < anls.AnalysisList.Count; i++)
            {   //AnalysisList listesinde kayıtlı olan üniteleri chart'a aktarır
                ChartUnite.Series["Units"].Points.AddXY(anls.AnalysisList[i].UnitName, anls.AnalysisList[i].Correct);

            }
            ChartUnite.Series["Units"]["PieLabelStyle"] = "Disabled";

        }
    }
}

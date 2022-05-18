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
        private string[] Units = { "ünite1", "ünite2", "ünite3", "ünite4", "ünite5", "ünite6" };
        private int[] dogrular = {10,8,5,15,13,10};
        private int [] yanlislar = {3,7,8,3,13,1}; 
        private int sayac = 0;
        private int dizisayac = 0;
        Analysis anls = new Analysis();
        public FrmAnaliz()
        {
            InitializeComponent();
        }

        private void BtnDogruYanlis_Click(object sender, EventArgs e)
        {
            
            if (sayac == 0) { 
            chartDogruYanlis.Visible = true;
            for (int i = 0; i < anls.AnalysisList.Count; i++)
            {
                chartDogruYanlis.Series["Doğru"].Points.AddXY(anls.AnalysisList[i].UnitName, anls.AnalysisList[i].Correct);
                chartDogruYanlis.Series["Yanlış"].Points.AddXY(anls.AnalysisList[i].UnitName, anls.AnalysisList[i].Incorrect);
            }
                sayac++;
            }

        }

        private void FrmAnaliz_Load(object sender, EventArgs e)
        {


            //anls.PullAnalysisCorrect();
            //anls.PullAnalysisInCorrect();
            //for(int i = 0; i < anls.AnalysisCorrect.Count; i++)
            //{
            //    ChartUnite.Series["Units"].Points.AddXY(anls.AnalysisCorrect[i].UnitName, anls.AnalysisCorrect[i].Correct);

            //}

            
            anls.PullAnalysis();
            for (int i = 0; i < anls.AnalysisList.Count; i++)
            {
                ChartUnite.Series["Units"].Points.AddXY(anls.AnalysisList[i].UnitName, anls.AnalysisList[i].Correct);

            }
            ChartUnite.Series["Units"]["PieLabelStyle"] = "Disabled";

        }
    }
}

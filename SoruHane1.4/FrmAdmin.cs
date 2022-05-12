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
    public partial class FrmAdmin : Form
    {  
        //alanlar
        private Button gecerliBtn;
        private Random rnd;
        private int RenkIndex;
        private Form aktifForm;
        public FrmAdmin()
        {
            InitializeComponent();
            rnd = new Random();
            this.Text = String.Empty;
            this.ControlBox = false;
            BtnFormKapa.Visible = false;
        }
        //metodlar
        private Color TemaRengiSec()
        {
            int index = rnd.Next(TemaRengi.RenkListesi.Count);
            while (RenkIndex == index)
            {
                index = rnd.Next(TemaRengi.RenkListesi.Count);
            }
            RenkIndex = index;
            string renk = TemaRengi.RenkListesi[index];
            return ColorTranslator.FromHtml(renk);
        }

        private void AktiveBtn(object btnsender)
        {
            if (btnsender != null)
            {
                if (gecerliBtn != (Button)btnsender)
                {
                    varsayilanDon();
                    Color renk = TemaRengiSec();
                    gecerliBtn = (Button)btnsender;
                    gecerliBtn.BackColor = renk;
                    gecerliBtn.ForeColor = Color.White;
                    gecerliBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panelBaslik.BackColor = renk;
                    panelKullanici.BackColor = TemaRengi.ChangeColorBrightness(renk, -0.3);
                    BtnFormKapa.Visible = true;
                }
            }
        }
        private void varsayilanDon()
        {
            foreach (Control oncekiBtn in panelMenu.Controls)
            {
                if (oncekiBtn.GetType() == typeof(Button))
                {
                    oncekiBtn.BackColor = Color.FromArgb(51, 51, 76);
                    oncekiBtn.ForeColor = Color.Gainsboro;
                    oncekiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }
        private void YeniFormAc(Form yeniForm, object Btnsender)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            AktiveBtn(Btnsender);
            aktifForm = yeniForm;
            yeniForm.TopLevel = false;
            yeniForm.FormBorderStyle = FormBorderStyle.None;
            yeniForm.Dock = DockStyle.Fill;
            this.panelAna.Controls.Add(yeniForm);
            this.panelAna.Tag = yeniForm;
            yeniForm.BringToFront();
            yeniForm.Show();

        }
        private void BtnFormKapa_Click(object sender, EventArgs e)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            varsayilanDon();
            LblBaslik.Text = "ANA SAYFA";
            panelBaslik.BackColor = Color.FromArgb(0, 150, 136);
            panelKullanici.BackColor = Color.FromArgb(39, 39, 58);
            gecerliBtn = null;
            BtnFormKapa.Visible = false;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            LblBaslik.Text = "SORU ONAYLA";
            YeniFormAc(new adminFormlar.frmSoruOnayla(), sender);
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            LblBaslik.Text = "HESAP AYARLARI";
            YeniFormAc(new SorumluFormlari.frmAyarlar(), sender);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SoruHane1._4.SorumluFormlari
{
    public partial class frmSoruEkleme : Form
    {
        //alanlar
        private char dogruCevap;
        private string IMGYolu = "";
        List<int> Unitids = new List<int>();// Veritabanından Soru ünitelerinin ID'lerini listelemek için 
        QuestionClass ques=new QuestionClass(); 
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
                
                ques.QuestionText = TxtSoru.Text;
                ques.AnswerA = TxtA.Text;
                ques.AnswerB = txtB.Text;
                ques.AnswerC = txtC.Text;
                ques.AnswerD = TxtD.Text;
                ques.QuestionImgPath = IMGYolu;
                ques.UnitId = Convert.ToInt16(Unitids[cmbUnute.SelectedIndex]);
                ques.AnswerCorrect = dogruCevap;
                if (ques.QuestionAdd() == true)
                    MessageBox.Show("Sorunuz Başarıyla eklenmiştir", "İşlem Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Eklenemedi");
                temizle();
            }
        }

        private void btnFotoEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureSoruResmi.ImageLocation = openFileDialog1.FileName;
            IMGYolu= openFileDialog1.FileName;
        }


        private void frmSoruEkleme_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tblunit", Datacon.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Unitids.Add(Convert.ToInt16(dr[0])); // Oluşturlan @Unitids listesine Veritabanından gelen Ünitelerin Id'si aktarılır
                cmbUnute.Items.Add(dr[1].ToString());  // Veritabanından Gelen Ünitenin Adı combobox'a aktarılır
            }
            cmbUnute.SelectedIndex = 0;
            Datacon.baglanti().Close();
        }
    }
}

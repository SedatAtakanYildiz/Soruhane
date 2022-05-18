namespace SoruHane1._4.SorumluFormlari
{
    partial class frmSoruEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoruEkleme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFotoEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBitir = new System.Windows.Forms.Button();
            this.cmbUnute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureSoruResmi = new System.Windows.Forms.PictureBox();
            this.TxtD = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnB = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtSoru = new System.Windows.Forms.RichTextBox();
            this.btnD = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoruResmi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btnFotoEkle);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBitir);
            this.panel1.Controls.Add(this.cmbUnute);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureSoruResmi);
            this.panel1.Controls.Add(this.TxtD);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.txtC);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.txtB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnA);
            this.panel1.Controls.Add(this.TxtA);
            this.panel1.Controls.Add(this.TxtSoru);
            this.panel1.Controls.Add(this.btnD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 490);
            this.panel1.TabIndex = 2;
            // 
            // btnFotoEkle
            // 
            this.btnFotoEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFotoEkle.Location = new System.Drawing.Point(408, 216);
            this.btnFotoEkle.Name = "btnFotoEkle";
            this.btnFotoEkle.Size = new System.Drawing.Size(115, 23);
            this.btnFotoEkle.TabIndex = 16;
            this.btnFotoEkle.Text = "Fotoğraf Ekle (...)";
            this.btnFotoEkle.Click += new System.EventHandler(this.btnFotoEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(423, 337);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(130, 57);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(173, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Her şey bittikten sonra bitir butonuna tıklayınız";
            // 
            // btnBitir
            // 
            this.btnBitir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBitir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(104)))), ((int)(((byte)(57)))));
            this.btnBitir.FlatAppearance.BorderSize = 0;
            this.btnBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.btnBitir.Image = ((System.Drawing.Image)(resources.GetObject("btnBitir.Image")));
            this.btnBitir.Location = new System.Drawing.Point(423, 405);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(130, 57);
            this.btnBitir.TabIndex = 13;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // cmbUnute
            // 
            this.cmbUnute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUnute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.cmbUnute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUnute.ForeColor = System.Drawing.Color.Silver;
            this.cmbUnute.FormattingEnabled = true;
            this.cmbUnute.Location = new System.Drawing.Point(527, 116);
            this.cmbUnute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUnute.Name = "cmbUnute";
            this.cmbUnute.Size = new System.Drawing.Size(138, 23);
            this.cmbUnute.TabIndex = 12;
            this.cmbUnute.Text = "Lütfen Üniteyi Seçiniz";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(193, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "resim eklemek için artı sembolüne tıklayınız";
            // 
            // pictureSoruResmi
            // 
            this.pictureSoruResmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureSoruResmi.Image = ((System.Drawing.Image)(resources.GetObject("pictureSoruResmi.Image")));
            this.pictureSoruResmi.Location = new System.Drawing.Point(408, 98);
            this.pictureSoruResmi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureSoruResmi.Name = "pictureSoruResmi";
            this.pictureSoruResmi.Size = new System.Drawing.Size(115, 113);
            this.pictureSoruResmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSoruResmi.TabIndex = 10;
            this.pictureSoruResmi.TabStop = false;
            // 
            // TxtD
            // 
            this.TxtD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.TxtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtD.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtD.Location = new System.Drawing.Point(112, 445);
            this.TxtD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtD.Multiline = true;
            this.TxtD.Name = "TxtD";
            this.TxtD.Size = new System.Drawing.Size(261, 32);
            this.TxtD.TabIndex = 8;
            this.TxtD.Text = "D şıkkını giriniz";
            this.TxtD.Click += new System.EventHandler(this.TxtD_Click);
            // 
            // btnC
            // 
            this.btnC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Image = ((System.Drawing.Image)(resources.GetObject("btnC.Image")));
            this.btnC.Location = new System.Drawing.Point(49, 380);
            this.btnC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(59, 53);
            this.btnC.TabIndex = 7;
            this.btnC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtC
            // 
            this.txtC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtC.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtC.Location = new System.Drawing.Point(112, 397);
            this.txtC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(261, 30);
            this.txtC.TabIndex = 6;
            this.txtC.Text = "C şıkkını giriniz";
            this.txtC.Click += new System.EventHandler(this.txtC_Click);
            // 
            // btnB
            // 
            this.btnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.Location = new System.Drawing.Point(49, 329);
            this.btnB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(58, 52);
            this.btnB.TabIndex = 5;
            this.btnB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // txtB
            // 
            this.txtB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtB.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtB.Location = new System.Drawing.Point(111, 337);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(261, 32);
            this.txtB.TabIndex = 4;
            this.txtB.Text = "B şıkkını giriniz";
            this.txtB.Click += new System.EventHandler(this.txtB_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen soru alanını ve cevap alanlarını doldurduktan sonra doğru şıkkı işaretleyi" +
    "niz ";
            // 
            // btnA
            // 
            this.btnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Image = ((System.Drawing.Image)(resources.GetObject("btnA.Image")));
            this.btnA.Location = new System.Drawing.Point(49, 269);
            this.btnA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(59, 59);
            this.btnA.TabIndex = 2;
            this.btnA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // TxtA
            // 
            this.TxtA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.TxtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtA.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtA.Location = new System.Drawing.Point(112, 282);
            this.TxtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtA.Multiline = true;
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(261, 33);
            this.TxtA.TabIndex = 1;
            this.TxtA.Text = "A şıkkını giriniz";
            this.TxtA.Click += new System.EventHandler(this.TxtA_Click);
            // 
            // TxtSoru
            // 
            this.TxtSoru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.TxtSoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoru.ForeColor = System.Drawing.Color.Gainsboro;
            this.TxtSoru.Location = new System.Drawing.Point(60, 98);
            this.TxtSoru.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSoru.Name = "TxtSoru";
            this.TxtSoru.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtSoru.Size = new System.Drawing.Size(334, 167);
            this.TxtSoru.TabIndex = 0;
            this.TxtSoru.Text = "Lütfen sorunuzu bu alana giriniz.";
            this.TxtSoru.Click += new System.EventHandler(this.TxtSoru_Click);
            // 
            // btnD
            // 
            this.btnD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Image = ((System.Drawing.Image)(resources.GetObject("btnD.Image")));
            this.btnD.Location = new System.Drawing.Point(49, 430);
            this.btnD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(58, 51);
            this.btnD.TabIndex = 9;
            this.btnD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSoruEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 490);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSoruEkleme";
            this.Text = "soruEklemeFormu";
            this.Load += new System.EventHandler(this.frmSoruEkleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoruResmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TxtSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.PictureBox pictureSoruResmi;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox TxtD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.ComboBox cmbUnute;
        private DevExpress.XtraEditors.SimpleButton btnFotoEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
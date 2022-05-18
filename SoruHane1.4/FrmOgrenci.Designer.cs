namespace SoruHane1._4
{
    partial class FrmOgrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenci));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHesapAyarlari = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.btnSerbestSinav = new System.Windows.Forms.Button();
            this.btnSinav = new System.Windows.Forms.Button();
            this.panelKullanici = new System.Windows.Forms.Panel();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.panelBaslik = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.BtnFormKapa = new System.Windows.Forms.Button();
            this.LblBaslik = new System.Windows.Forms.Label();
            this.panelAna = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelKullanici.SuspendLayout();
            this.panelBaslik.SuspendLayout();
            this.panelAna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnHesapAyarlari);
            this.panelMenu.Controls.Add(this.btnAyarlar);
            this.panelMenu.Controls.Add(this.btnAnaliz);
            this.panelMenu.Controls.Add(this.btnSerbestSinav);
            this.panelMenu.Controls.Add(this.btnSinav);
            this.panelMenu.Controls.Add(this.panelKullanici);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 599);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHesapAyarlari
            // 
            this.btnHesapAyarlari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHesapAyarlari.FlatAppearance.BorderSize = 0;
            this.btnHesapAyarlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapAyarlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapAyarlari.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHesapAyarlari.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapAyarlari.Image")));
            this.btnHesapAyarlari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapAyarlari.Location = new System.Drawing.Point(0, 277);
            this.btnHesapAyarlari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHesapAyarlari.Name = "btnHesapAyarlari";
            this.btnHesapAyarlari.Size = new System.Drawing.Size(165, 49);
            this.btnHesapAyarlari.TabIndex = 5;
            this.btnHesapAyarlari.Text = "   Hesap Ayarları";
            this.btnHesapAyarlari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapAyarlari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHesapAyarlari.UseVisualStyleBackColor = true;
            this.btnHesapAyarlari.Click += new System.EventHandler(this.btnHesapAyarlari_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyarlar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.Location = new System.Drawing.Point(0, 228);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(165, 49);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "   Soru Zaman \r\n      Ayarları";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click_1);
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaliz.FlatAppearance.BorderSize = 0;
            this.btnAnaliz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaliz.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAnaliz.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaliz.Image")));
            this.btnAnaliz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliz.Location = new System.Drawing.Point(0, 179);
            this.btnAnaliz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(165, 49);
            this.btnAnaliz.TabIndex = 3;
            this.btnAnaliz.Text = "   Analiz";
            this.btnAnaliz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnaliz.UseVisualStyleBackColor = true;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click_1);
            // 
            // btnSerbestSinav
            // 
            this.btnSerbestSinav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerbestSinav.FlatAppearance.BorderSize = 0;
            this.btnSerbestSinav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerbestSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSerbestSinav.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSerbestSinav.Image = ((System.Drawing.Image)(resources.GetObject("btnSerbestSinav.Image")));
            this.btnSerbestSinav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerbestSinav.Location = new System.Drawing.Point(0, 130);
            this.btnSerbestSinav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSerbestSinav.Name = "btnSerbestSinav";
            this.btnSerbestSinav.Size = new System.Drawing.Size(165, 49);
            this.btnSerbestSinav.TabIndex = 2;
            this.btnSerbestSinav.Text = "   Serbest Sinav";
            this.btnSerbestSinav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSerbestSinav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSerbestSinav.UseVisualStyleBackColor = true;
            this.btnSerbestSinav.Click += new System.EventHandler(this.btnSerbestSinav_Click_1);
            // 
            // btnSinav
            // 
            this.btnSinav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinav.FlatAppearance.BorderSize = 0;
            this.btnSinav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinav.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSinav.Image = ((System.Drawing.Image)(resources.GetObject("btnSinav.Image")));
            this.btnSinav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinav.Location = new System.Drawing.Point(0, 81);
            this.btnSinav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSinav.Name = "btnSinav";
            this.btnSinav.Size = new System.Drawing.Size(165, 49);
            this.btnSinav.TabIndex = 0;
            this.btnSinav.Text = "   Sınav";
            this.btnSinav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSinav.UseVisualStyleBackColor = true;
            this.btnSinav.Click += new System.EventHandler(this.btnSinav_Click_1);
            // 
            // panelKullanici
            // 
            this.panelKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelKullanici.Controls.Add(this.lblSoyisim);
            this.panelKullanici.Controls.Add(this.lblIsim);
            this.panelKullanici.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKullanici.Location = new System.Drawing.Point(0, 0);
            this.panelKullanici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelKullanici.Name = "panelKullanici";
            this.panelKullanici.Size = new System.Drawing.Size(165, 81);
            this.panelKullanici.TabIndex = 1;
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyisim.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSoyisim.Location = new System.Drawing.Point(51, 39);
            this.lblSoyisim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(50, 17);
            this.lblSoyisim.TabIndex = 1;
            this.lblSoyisim.Text = "YILDIZ";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblIsim.Location = new System.Drawing.Point(34, 15);
            this.lblIsim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(93, 17);
            this.lblIsim.TabIndex = 0;
            this.lblIsim.Text = "Sedat Atakan";
            // 
            // panelBaslik
            // 
            this.panelBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelBaslik.Controls.Add(this.btnCikis);
            this.panelBaslik.Controls.Add(this.BtnFormKapa);
            this.panelBaslik.Controls.Add(this.LblBaslik);
            this.panelBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaslik.Location = new System.Drawing.Point(165, 0);
            this.panelBaslik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBaslik.Name = "panelBaslik";
            this.panelBaslik.Size = new System.Drawing.Size(805, 81);
            this.panelBaslik.TabIndex = 1;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(774, -2);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(31, 34);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // BtnFormKapa
            // 
            this.BtnFormKapa.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFormKapa.FlatAppearance.BorderSize = 0;
            this.BtnFormKapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFormKapa.Image = ((System.Drawing.Image)(resources.GetObject("BtnFormKapa.Image")));
            this.BtnFormKapa.Location = new System.Drawing.Point(0, 0);
            this.BtnFormKapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnFormKapa.Name = "BtnFormKapa";
            this.BtnFormKapa.Size = new System.Drawing.Size(68, 81);
            this.BtnFormKapa.TabIndex = 1;
            this.BtnFormKapa.UseVisualStyleBackColor = true;
            this.BtnFormKapa.Click += new System.EventHandler(this.BtnFormKapa_Click);
            // 
            // LblBaslik
            // 
            this.LblBaslik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblBaslik.AutoSize = true;
            this.LblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.LblBaslik.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBaslik.ForeColor = System.Drawing.Color.White;
            this.LblBaslik.Location = new System.Drawing.Point(316, 28);
            this.LblBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBaslik.Name = "LblBaslik";
            this.LblBaslik.Size = new System.Drawing.Size(146, 30);
            this.LblBaslik.TabIndex = 0;
            this.LblBaslik.Text = "ANA SAYFA";
            // 
            // panelAna
            // 
            this.panelAna.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelAna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAna.BackgroundImage")));
            this.panelAna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAna.Controls.Add(this.label5);
            this.panelAna.Controls.Add(this.label4);
            this.panelAna.Controls.Add(this.pictureBox1);
            this.panelAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAna.Location = new System.Drawing.Point(165, 81);
            this.panelAna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(805, 518);
            this.panelAna.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 26F);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(372, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 48);
            this.label5.TabIndex = 37;
            this.label5.Text = "HANE";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 26F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(259, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 46);
            this.label4.TabIndex = 36;
            this.label4.Text = "SORU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(970, 599);
            this.Controls.Add(this.panelAna);
            this.Controls.Add(this.panelBaslik);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(716, 454);
            this.Name = "FrmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrenci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOgrenci_Load_1);
            this.panelMenu.ResumeLayout(false);
            this.panelKullanici.ResumeLayout(false);
            this.panelKullanici.PerformLayout();
            this.panelBaslik.ResumeLayout(false);
            this.panelBaslik.PerformLayout();
            this.panelAna.ResumeLayout(false);
            this.panelAna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.Button btnSerbestSinav;
        private System.Windows.Forms.Button btnSinav;
        private System.Windows.Forms.Panel panelKullanici;
        private System.Windows.Forms.Panel panelBaslik;
        private System.Windows.Forms.Label LblBaslik;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Panel panelAna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnFormKapa;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnHesapAyarlari;
    }
}
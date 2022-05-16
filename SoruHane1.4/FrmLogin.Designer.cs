namespace SoruHane1._4
{
    partial class FrmLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.BtnUnuttum = new System.Windows.Forms.Button();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.RdSorumlu = new System.Windows.Forms.RadioButton();
            this.RdAdmin = new System.Windows.Forms.RadioButton();
            this.RdOgrenci = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textKullanici = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 489);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(-4, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tüm Hakları Saklıdır";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(-4, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Soru Hane v1.4   ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 19.8F);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(96, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 44);
            this.label5.TabIndex = 34;
            this.label5.Text = "HANE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 19.8F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(-7, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 44);
            this.label4.TabIndex = 33;
            this.label4.Text = "SORU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.BtnCıkıs);
            this.panel2.Controls.Add(this.BtnUnuttum);
            this.panel2.Controls.Add(this.BtnKayitOl);
            this.panel2.Controls.Add(this.btnGiris);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 489);
            this.panel2.TabIndex = 1;
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.Color.Transparent;
            this.BtnCıkıs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCıkıs.BackgroundImage")));
            this.BtnCıkıs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCıkıs.FlatAppearance.BorderSize = 0;
            this.BtnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCıkıs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCıkıs.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCıkıs.Location = new System.Drawing.Point(509, 0);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(31, 33);
            this.BtnCıkıs.TabIndex = 35;
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // BtnUnuttum
            // 
            this.BtnUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.BtnUnuttum.FlatAppearance.BorderSize = 0;
            this.BtnUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUnuttum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUnuttum.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUnuttum.Location = new System.Drawing.Point(6, 441);
            this.BtnUnuttum.Name = "BtnUnuttum";
            this.BtnUnuttum.Size = new System.Drawing.Size(177, 36);
            this.BtnUnuttum.TabIndex = 34;
            this.BtnUnuttum.Text = "Şifremi Unuttum";
            this.BtnUnuttum.UseVisualStyleBackColor = false;
            this.BtnUnuttum.Click += new System.EventHandler(this.BtnUnuttum_Click);
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.BtnKayitOl.FlatAppearance.BorderSize = 0;
            this.BtnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKayitOl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayitOl.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnKayitOl.Location = new System.Drawing.Point(396, 441);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(119, 36);
            this.BtnKayitOl.TabIndex = 33;
            this.BtnKayitOl.Text = "Kayıt Ol\r\n";
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGiris.Location = new System.Drawing.Point(325, 327);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(190, 37);
            this.btnGiris.TabIndex = 32;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.RdSorumlu);
            this.panel5.Controls.Add(this.RdAdmin);
            this.panel5.Controls.Add(this.RdOgrenci);
            this.panel5.Location = new System.Drawing.Point(0, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 51);
            this.panel5.TabIndex = 31;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(488, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // RdSorumlu
            // 
            this.RdSorumlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdSorumlu.AutoSize = true;
            this.RdSorumlu.BackColor = System.Drawing.Color.Transparent;
            this.RdSorumlu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdSorumlu.ForeColor = System.Drawing.Color.DimGray;
            this.RdSorumlu.Location = new System.Drawing.Point(298, 13);
            this.RdSorumlu.Name = "RdSorumlu";
            this.RdSorumlu.Size = new System.Drawing.Size(159, 25);
            this.RdSorumlu.TabIndex = 24;
            this.RdSorumlu.TabStop = true;
            this.RdSorumlu.Text = "Sınav Sorumlusu";
            this.RdSorumlu.UseVisualStyleBackColor = false;
            // 
            // RdAdmin
            // 
            this.RdAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdAdmin.AutoSize = true;
            this.RdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.RdAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.RdAdmin.Location = new System.Drawing.Point(39, 13);
            this.RdAdmin.Name = "RdAdmin";
            this.RdAdmin.Size = new System.Drawing.Size(84, 25);
            this.RdAdmin.TabIndex = 22;
            this.RdAdmin.TabStop = true;
            this.RdAdmin.Text = "Admin";
            this.RdAdmin.UseVisualStyleBackColor = false;
            // 
            // RdOgrenci
            // 
            this.RdOgrenci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RdOgrenci.AutoSize = true;
            this.RdOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.RdOgrenci.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdOgrenci.ForeColor = System.Drawing.Color.DimGray;
            this.RdOgrenci.Location = new System.Drawing.Point(162, 13);
            this.RdOgrenci.Name = "RdOgrenci";
            this.RdOgrenci.Size = new System.Drawing.Size(97, 25);
            this.RdOgrenci.TabIndex = 23;
            this.RdOgrenci.TabStop = true;
            this.RdOgrenci.Text = "Öğrenci";
            this.RdOgrenci.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(147, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kullanıcı Adı ve Şifre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.textSifre);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(0, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 47);
            this.panel4.TabIndex = 1;
            // 
            // textSifre
            // 
            this.textSifre.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.textSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textSifre.Location = new System.Drawing.Point(84, 6);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(347, 36);
            this.textSifre.TabIndex = 31;
            this.textSifre.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.textKullanici);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(0, 164);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 47);
            this.panel3.TabIndex = 0;
            // 
            // textKullanici
            // 
            this.textKullanici.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.textKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textKullanici.Location = new System.Drawing.Point(84, 6);
            this.textKullanici.Name = "textKullanici";
            this.textKullanici.Size = new System.Drawing.Size(347, 36);
            this.textKullanici.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGİN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textKullanici;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUnuttum;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton RdSorumlu;
        private System.Windows.Forms.RadioButton RdAdmin;
        private System.Windows.Forms.RadioButton RdOgrenci;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}


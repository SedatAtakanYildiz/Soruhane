﻿namespace SoruHane1._4.OgrFormlar
{
    partial class FrmSerbestSinav
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerbestSinav));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureZaman = new System.Windows.Forms.PictureBox();
            this.lblZaman = new System.Windows.Forms.Label();
            this.PnlCevap = new System.Windows.Forms.Panel();
            this.BtnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnSinavBitir = new System.Windows.Forms.Button();
            this.BtnSinavilerle = new System.Windows.Forms.Button();
            this.BtnSinavBasla = new System.Windows.Forms.Button();
            this.TxtSoru = new System.Windows.Forms.RichTextBox();
            this.pictureSoru = new System.Windows.Forms.PictureBox();
            this.TmrSoruSuresi = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZaman)).BeginInit();
            this.PnlCevap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.pictureZaman);
            this.panel1.Controls.Add(this.lblZaman);
            this.panel1.Controls.Add(this.PnlCevap);
            this.panel1.Controls.Add(this.BtnSinavBitir);
            this.panel1.Controls.Add(this.BtnSinavilerle);
            this.panel1.Controls.Add(this.BtnSinavBasla);
            this.panel1.Controls.Add(this.TxtSoru);
            this.panel1.Controls.Add(this.pictureSoru);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 627);
            this.panel1.TabIndex = 0;
            // 
            // pictureZaman
            // 
            this.pictureZaman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureZaman.Image = ((System.Drawing.Image)(resources.GetObject("pictureZaman.Image")));
            this.pictureZaman.Location = new System.Drawing.Point(607, 190);
            this.pictureZaman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureZaman.Name = "pictureZaman";
            this.pictureZaman.Size = new System.Drawing.Size(48, 48);
            this.pictureZaman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureZaman.TabIndex = 20;
            this.pictureZaman.TabStop = false;
            this.pictureZaman.Visible = false;
            // 
            // lblZaman
            // 
            this.lblZaman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(235)))));
            this.lblZaman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZaman.Location = new System.Drawing.Point(661, 198);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(46, 39);
            this.lblZaman.TabIndex = 19;
            this.lblZaman.Text = "60";
            this.lblZaman.Visible = false;
            // 
            // PnlCevap
            // 
            this.PnlCevap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlCevap.AutoSize = true;
            this.PnlCevap.Controls.Add(this.BtnA);
            this.PnlCevap.Controls.Add(this.btnB);
            this.PnlCevap.Controls.Add(this.BtnC);
            this.PnlCevap.Controls.Add(this.BtnD);
            this.PnlCevap.Location = new System.Drawing.Point(0, 268);
            this.PnlCevap.Name = "PnlCevap";
            this.PnlCevap.Size = new System.Drawing.Size(1023, 281);
            this.PnlCevap.TabIndex = 18;
            // 
            // BtnA
            // 
            this.BtnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnA.AutoSize = true;
            this.BtnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.BtnA.FlatAppearance.BorderSize = 0;
            this.BtnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnA.Image = ((System.Drawing.Image)(resources.GetObject("BtnA.Image")));
            this.BtnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnA.Location = new System.Drawing.Point(77, 4);
            this.BtnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(175, 70);
            this.BtnA.TabIndex = 2;
            this.BtnA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.Visible = false;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click_1);
            // 
            // btnB
            // 
            this.btnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnB.AutoSize = true;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.Location = new System.Drawing.Point(77, 78);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(175, 61);
            this.btnB.TabIndex = 3;
            this.btnB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Visible = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnC.AutoSize = true;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnC.Image = ((System.Drawing.Image)(resources.GetObject("BtnC.Image")));
            this.BtnC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnC.Location = new System.Drawing.Point(77, 143);
            this.BtnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(175, 66);
            this.BtnC.TabIndex = 4;
            this.BtnC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Visible = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnD.AutoSize = true;
            this.BtnD.FlatAppearance.BorderSize = 0;
            this.BtnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnD.Image = ((System.Drawing.Image)(resources.GetObject("BtnD.Image")));
            this.BtnD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnD.Location = new System.Drawing.Point(77, 213);
            this.BtnD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(175, 66);
            this.BtnD.TabIndex = 5;
            this.BtnD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Visible = false;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnSinavBitir
            // 
            this.BtnSinavBitir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSinavBitir.FlatAppearance.BorderSize = 0;
            this.BtnSinavBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSinavBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinavBitir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSinavBitir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSinavBitir.Image")));
            this.BtnSinavBitir.Location = new System.Drawing.Point(374, 541);
            this.BtnSinavBitir.Name = "BtnSinavBitir";
            this.BtnSinavBitir.Size = new System.Drawing.Size(203, 66);
            this.BtnSinavBitir.TabIndex = 17;
            this.BtnSinavBitir.Text = "  Sınavı Bitir";
            this.BtnSinavBitir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSinavBitir.UseVisualStyleBackColor = true;
            this.BtnSinavBitir.Visible = false;
            this.BtnSinavBitir.Click += new System.EventHandler(this.BtnSinavBitir_Click_1);
            // 
            // BtnSinavilerle
            // 
            this.BtnSinavilerle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSinavilerle.FlatAppearance.BorderSize = 0;
            this.BtnSinavilerle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSinavilerle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinavilerle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSinavilerle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSinavilerle.Image")));
            this.BtnSinavilerle.Location = new System.Drawing.Point(131, 541);
            this.BtnSinavilerle.Name = "BtnSinavilerle";
            this.BtnSinavilerle.Size = new System.Drawing.Size(203, 66);
            this.BtnSinavilerle.TabIndex = 16;
            this.BtnSinavilerle.Text = "  Sonraki Soru";
            this.BtnSinavilerle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSinavilerle.UseVisualStyleBackColor = true;
            this.BtnSinavilerle.Visible = false;
            this.BtnSinavilerle.Click += new System.EventHandler(this.BtnSinavilerle_Click_1);
            // 
            // BtnSinavBasla
            // 
            this.BtnSinavBasla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSinavBasla.FlatAppearance.BorderSize = 0;
            this.BtnSinavBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSinavBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSinavBasla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSinavBasla.Image = ((System.Drawing.Image)(resources.GetObject("BtnSinavBasla.Image")));
            this.BtnSinavBasla.Location = new System.Drawing.Point(165, 201);
            this.BtnSinavBasla.Name = "BtnSinavBasla";
            this.BtnSinavBasla.Size = new System.Drawing.Size(203, 66);
            this.BtnSinavBasla.TabIndex = 15;
            this.BtnSinavBasla.Text = "Sınava Başla";
            this.BtnSinavBasla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSinavBasla.UseVisualStyleBackColor = true;
            this.BtnSinavBasla.Click += new System.EventHandler(this.BtnSinavBasla_Click_1);
            // 
            // TxtSoru
            // 
            this.TxtSoru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.TxtSoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoru.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSoru.Location = new System.Drawing.Point(83, 52);
            this.TxtSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSoru.MaxLength = 1000;
            this.TxtSoru.Name = "TxtSoru";
            this.TxtSoru.ReadOnly = true;
            this.TxtSoru.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtSoru.Size = new System.Drawing.Size(489, 185);
            this.TxtSoru.TabIndex = 14;
            this.TxtSoru.Text = " Lütfen dikkat edin\n   Sorularda geri dönüş yoktur!\n   Her Soruda 1 dakika süreni" +
    "z vardır.\n   1 dkk sonra soru otomatik atlayacaktır!!\n   Başarılar Dileriz...";
            // 
            // pictureSoru
            // 
            this.pictureSoru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureSoru.Image = ((System.Drawing.Image)(resources.GetObject("pictureSoru.Image")));
            this.pictureSoru.Location = new System.Drawing.Point(578, 52);
            this.pictureSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSoru.Name = "pictureSoru";
            this.pictureSoru.Size = new System.Drawing.Size(133, 123);
            this.pictureSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSoru.TabIndex = 13;
            this.pictureSoru.TabStop = false;
            // 
            // TmrSoruSuresi
            // 
            this.TmrSoruSuresi.Interval = 1000;
            this.TmrSoruSuresi.Tick += new System.EventHandler(this.TmrSoruSuresi_Tick);
            // 
            // FrmSerbestSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSerbestSinav";
            this.Text = "FrmSerbestSinav";
            this.Load += new System.EventHandler(this.FrmSerbestSinav_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureZaman)).EndInit();
            this.PnlCevap.ResumeLayout(false);
            this.PnlCevap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer TmrSoruSuresi;
        private System.Windows.Forms.Panel PnlCevap;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnSinavBitir;
        private System.Windows.Forms.Button BtnSinavilerle;
        private System.Windows.Forms.Button BtnSinavBasla;
        private System.Windows.Forms.RichTextBox TxtSoru;
        private System.Windows.Forms.PictureBox pictureSoru;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.PictureBox pictureZaman;
    }
}
namespace SoruHane1._4.OgrFormlar
{
    partial class FrmSinav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinav));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSinavBitir = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSinavilerle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.TxtSoru = new System.Windows.Forms.RichTextBox();
            this.pictureSoru = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            this.BtnSinavBasla = new DevExpress.XtraEditors.SimpleButton();
=======
            this.BtnSinavilerle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSinavBitir = new DevExpress.XtraEditors.SimpleButton();
>>>>>>> b5953522bf748b1a20bbab68b7d7ace9aee0f9f7
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
<<<<<<< HEAD
            this.panel1.Controls.Add(this.BtnSinavBasla);
=======
>>>>>>> b5953522bf748b1a20bbab68b7d7ace9aee0f9f7
            this.panel1.Controls.Add(this.BtnSinavBitir);
            this.panel1.Controls.Add(this.BtnSinavilerle);
            this.panel1.Controls.Add(this.BtnD);
            this.panel1.Controls.Add(this.BtnC);
            this.panel1.Controls.Add(this.btnB);
            this.panel1.Controls.Add(this.BtnA);
            this.panel1.Controls.Add(this.TxtSoru);
            this.panel1.Controls.Add(this.pictureSoru);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 493);
            this.panel1.TabIndex = 1;
            // 
            // BtnSinavBitir
            // 
            this.BtnSinavBitir.Location = new System.Drawing.Point(622, 345);
            this.BtnSinavBitir.Name = "BtnSinavBitir";
            this.BtnSinavBitir.Size = new System.Drawing.Size(133, 46);
            this.BtnSinavBitir.TabIndex = 7;
            this.BtnSinavBitir.Text = "Sınavı Bitir";
            this.BtnSinavBitir.Click += new System.EventHandler(this.BtnSinavBitir_Click);
            // 
            // BtnSinavilerle
            // 
            this.BtnSinavilerle.Location = new System.Drawing.Point(622, 293);
            this.BtnSinavilerle.Name = "BtnSinavilerle";
            this.BtnSinavilerle.Size = new System.Drawing.Size(133, 46);
            this.BtnSinavilerle.TabIndex = 6;
            this.BtnSinavilerle.Text = "Sonraki Soru";
            this.BtnSinavilerle.Click += new System.EventHandler(this.BtnSinavilerle_Click);
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
            this.BtnD.Location = new System.Drawing.Point(58, 394);
            this.BtnD.Margin = new System.Windows.Forms.Padding(2);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(131, 54);
            this.BtnD.TabIndex = 5;
            this.BtnD.Text = "  D şıkkı";
            this.BtnD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
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
            this.BtnC.Location = new System.Drawing.Point(58, 345);
            this.BtnC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(131, 54);
            this.BtnC.TabIndex = 4;
            this.BtnC.Text = "  C şıkkı";
            this.BtnC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
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
            this.btnB.Location = new System.Drawing.Point(58, 297);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(131, 54);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "  B şıkkı";
            this.btnB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // BtnA
            // 
            this.BtnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnA.AutoSize = true;
            this.BtnA.FlatAppearance.BorderSize = 0;
            this.BtnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnA.Image = ((System.Drawing.Image)(resources.GetObject("BtnA.Image")));
            this.BtnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnA.Location = new System.Drawing.Point(58, 248);
            this.BtnA.Margin = new System.Windows.Forms.Padding(2);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(131, 54);
            this.BtnA.TabIndex = 2;
            this.BtnA.Text = "  A şıkkı";
            this.BtnA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // TxtSoru
            // 
            this.TxtSoru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtSoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.TxtSoru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoru.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSoru.Location = new System.Drawing.Point(58, 67);
            this.TxtSoru.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSoru.MaxLength = 1000;
            this.TxtSoru.Name = "TxtSoru";
            this.TxtSoru.ReadOnly = true;
            this.TxtSoru.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TxtSoru.Size = new System.Drawing.Size(367, 150);
            this.TxtSoru.TabIndex = 1;
            this.TxtSoru.Text = "1.soru\n     dünyanın en yakışıklı erkeği kimdir?";
            // 
            // pictureSoru
            // 
            this.pictureSoru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureSoru.Image = ((System.Drawing.Image)(resources.GetObject("pictureSoru.Image")));
            this.pictureSoru.Location = new System.Drawing.Point(463, 67);
            this.pictureSoru.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSoru.Name = "pictureSoru";
            this.pictureSoru.Size = new System.Drawing.Size(100, 100);
            this.pictureSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSoru.TabIndex = 0;
            this.pictureSoru.TabStop = false;
            // 
<<<<<<< HEAD
            // BtnSinavBasla
            // 
            this.BtnSinavBasla.Location = new System.Drawing.Point(622, 241);
            this.BtnSinavBasla.Name = "BtnSinavBasla";
            this.BtnSinavBasla.Size = new System.Drawing.Size(133, 46);
            this.BtnSinavBasla.TabIndex = 8;
            this.BtnSinavBasla.Text = "Sınav\'a Başla";
            this.BtnSinavBasla.Click += new System.EventHandler(this.BtnSinavBasla_Click);
=======
            // BtnSinavilerle
            // 
            this.BtnSinavilerle.Location = new System.Drawing.Point(378, 400);
            this.BtnSinavilerle.Name = "BtnSinavilerle";
            this.BtnSinavilerle.Size = new System.Drawing.Size(133, 46);
            this.BtnSinavilerle.TabIndex = 6;
            this.BtnSinavilerle.Text = "Sonraki Soru";
            this.BtnSinavilerle.Click += new System.EventHandler(this.BtnSinavilerle_Click);
            // 
            // BtnSinavBitir
            // 
            this.BtnSinavBitir.Location = new System.Drawing.Point(517, 400);
            this.BtnSinavBitir.Name = "BtnSinavBitir";
            this.BtnSinavBitir.Size = new System.Drawing.Size(133, 46);
            this.BtnSinavBitir.TabIndex = 7;
            this.BtnSinavBitir.Text = "Sınavı Bitir";
>>>>>>> b5953522bf748b1a20bbab68b7d7ace9aee0f9f7
            // 
            // FrmSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 493);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSinav";
            this.Text = "FrmSinav";
            this.Load += new System.EventHandler(this.FrmSinav_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.RichTextBox TxtSoru;
        private System.Windows.Forms.PictureBox pictureSoru;
        private DevExpress.XtraEditors.SimpleButton BtnSinavilerle;
        private DevExpress.XtraEditors.SimpleButton BtnSinavBitir;
<<<<<<< HEAD
        private DevExpress.XtraEditors.SimpleButton BtnSinavBasla;
=======
>>>>>>> b5953522bf748b1a20bbab68b7d7ace9aee0f9f7
    }
}
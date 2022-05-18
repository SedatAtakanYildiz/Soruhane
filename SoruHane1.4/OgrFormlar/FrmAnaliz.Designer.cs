namespace SoruHane1._4.OgrFormlar
{
    partial class FrmAnaliz
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaliz));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartDogruYanlis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnDogruYanlis = new System.Windows.Forms.Button();
            this.ChartUnite = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDogruYanlis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUnite)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.chartDogruYanlis);
            this.panel1.Controls.Add(this.BtnDogruYanlis);
            this.panel1.Controls.Add(this.ChartUnite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 638);
            this.panel1.TabIndex = 5;
            // 
            // chartDogruYanlis
            // 
            this.chartDogruYanlis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartDogruYanlis.BackColor = System.Drawing.Color.Transparent;
            this.chartDogruYanlis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartDogruYanlis.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 18;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 16;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Azure;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Azure;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 69.00081F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 1F;
            chartArea1.Position.Y = 12.19131F;
            this.chartDogruYanlis.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderWidth = 0;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            legend1.Title = "Üniteler";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleBackColor = System.Drawing.Color.Transparent;
            legend1.TitleForeColor = System.Drawing.Color.Gainsboro;
            this.chartDogruYanlis.Legends.Add(legend1);
            this.chartDogruYanlis.Location = new System.Drawing.Point(749, 63);
            this.chartDogruYanlis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDogruYanlis.Name = "chartDogruYanlis";
            this.chartDogruYanlis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doğru";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Yanlış";
            this.chartDogruYanlis.Series.Add(series1);
            this.chartDogruYanlis.Series.Add(series2);
            this.chartDogruYanlis.Size = new System.Drawing.Size(537, 462);
            this.chartDogruYanlis.TabIndex = 21;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.ForeColor = System.Drawing.Color.Gainsboro;
            title1.Name = "Title1";
            title1.Text = "Ünite Grafik";
            this.chartDogruYanlis.Titles.Add(title1);
            this.chartDogruYanlis.Visible = false;
            // 
            // BtnDogruYanlis
            // 
            this.BtnDogruYanlis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDogruYanlis.FlatAppearance.BorderSize = 0;
            this.BtnDogruYanlis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDogruYanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDogruYanlis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDogruYanlis.Image = ((System.Drawing.Image)(resources.GetObject("BtnDogruYanlis.Image")));
            this.BtnDogruYanlis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDogruYanlis.Location = new System.Drawing.Point(530, 557);
            this.BtnDogruYanlis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDogruYanlis.Name = "BtnDogruYanlis";
            this.BtnDogruYanlis.Size = new System.Drawing.Size(353, 66);
            this.BtnDogruYanlis.TabIndex = 20;
            this.BtnDogruYanlis.Text = "  Doğru Yanlış Bilgilerini Çek";
            this.BtnDogruYanlis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDogruYanlis.UseVisualStyleBackColor = true;
            this.BtnDogruYanlis.Click += new System.EventHandler(this.BtnDogruYanlis_Click);
            // 
            // ChartUnite
            // 
            this.ChartUnite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChartUnite.BackColor = System.Drawing.Color.Transparent;
            this.ChartUnite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChartUnite.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.IsLabelAutoFit = false;
            chartArea2.AxisX2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 69.00081F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.Y = 12.19131F;
            this.ChartUnite.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderWidth = 0;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.ForeColor = System.Drawing.Color.Gainsboro;
            legend2.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            legend2.Title = "Üniteler";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend2.TitleBackColor = System.Drawing.Color.Transparent;
            legend2.TitleForeColor = System.Drawing.Color.Gainsboro;
            this.ChartUnite.Legends.Add(legend2);
            this.ChartUnite.Location = new System.Drawing.Point(137, 63);
            this.ChartUnite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartUnite.Name = "ChartUnite";
            this.ChartUnite.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Units";
            this.ChartUnite.Series.Add(series3);
            this.ChartUnite.Size = new System.Drawing.Size(606, 490);
            this.ChartUnite.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title2.ForeColor = System.Drawing.Color.Gainsboro;
            title2.Name = "Title1";
            title2.Text = "Ünite Grafik";
            this.ChartUnite.Titles.Add(title2);
            // 
            // FrmAnaliz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 638);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAnaliz";
            this.Text = "FrmAnaliz";
            this.Load += new System.EventHandler(this.FrmAnaliz_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDogruYanlis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartUnite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartUnite;
        private System.Windows.Forms.Button BtnDogruYanlis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDogruYanlis;
    }
}
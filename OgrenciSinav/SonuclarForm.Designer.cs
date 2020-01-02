namespace OgrenciSinav
{
    partial class SonuclarForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SonuclarForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGenel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartSinav = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnKapat = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSinav)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.WallWidth = 10;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 21);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "MutlakDeğer";
            series1.XValueMember = "5";
            series1.YValueMembers = "10";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(750, 295);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Empty;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            this.chart2.BorderlineWidth = 5;
            chartArea2.Area3DStyle.WallWidth = 10;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(601, 21);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "SoruSayısı";
            series2.XValueMember = "5";
            series2.YValueMembers = "10";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(634, 295);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "SoruSayısı";
            // 
            // chartGenel
            // 
            chartArea3.Area3DStyle.WallWidth = 10;
            chartArea3.Name = "ChartArea1";
            this.chartGenel.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGenel.Legends.Add(legend3);
            this.chartGenel.Location = new System.Drawing.Point(22, 347);
            this.chartGenel.Name = "chartGenel";
            this.chartGenel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Genel";
            series3.XValueMember = "5";
            series3.YValueMembers = "10";
            this.chartGenel.Series.Add(series3);
            this.chartGenel.Size = new System.Drawing.Size(622, 295);
            this.chartGenel.TabIndex = 2;
            this.chartGenel.Text = "chartGenel";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(757, 522);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(354, 59);
            this.bunifuRating1.TabIndex = 3;
            this.bunifuRating1.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(798, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "GENEL İSTATİKLERİNİZİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(650, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "DAHA ÇOK SORU ÇÖZEREK GELİŞTİRE BİLİRSİNİZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(860, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "TEBRİKLER...";
            // 
            // chartSinav
            // 
            chartArea4.Area3DStyle.WallWidth = 10;
            chartArea4.Name = "ChartArea1";
            this.chartSinav.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSinav.Legends.Add(legend4);
            this.chartSinav.Location = new System.Drawing.Point(641, 347);
            this.chartSinav.Name = "chartSinav";
            this.chartSinav.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "SonSinav";
            series4.XValueMember = "5";
            series4.YValueMembers = "10";
            this.chartSinav.Series.Add(series4);
            this.chartSinav.Size = new System.Drawing.Size(594, 295);
            this.chartSinav.TabIndex = 7;
            this.chartSinav.Text = "chart3";
            // 
            // btnKapat
            // 
            this.btnKapat.Active = false;
            this.btnKapat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.BorderRadius = 0;
            this.btnKapat.ButtonText = "Kapat";
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.DisabledColor = System.Drawing.Color.Gray;
            this.btnKapat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKapat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKapat.Iconimage")));
            this.btnKapat.Iconimage_right = null;
            this.btnKapat.Iconimage_right_Selected = null;
            this.btnKapat.Iconimage_Selected = null;
            this.btnKapat.IconMarginLeft = 0;
            this.btnKapat.IconMarginRight = 0;
            this.btnKapat.IconRightVisible = true;
            this.btnKapat.IconRightZoom = 0D;
            this.btnKapat.IconVisible = true;
            this.btnKapat.IconZoom = 90D;
            this.btnKapat.IsTab = false;
            this.btnKapat.Location = new System.Drawing.Point(1242, 21);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKapat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKapat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKapat.selected = false;
            this.btnKapat.Size = new System.Drawing.Size(134, 59);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.Textcolor = System.Drawing.Color.White;
            this.btnKapat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // SonuclarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1421, 706);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.chartSinav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.chartGenel);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SonuclarForm";
            this.Text = "SonuclarForm";
            this.Load += new System.EventHandler(this.SonuclarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSinav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSinav;
        private Bunifu.Framework.UI.BunifuFlatButton btnKapat;
    }
}
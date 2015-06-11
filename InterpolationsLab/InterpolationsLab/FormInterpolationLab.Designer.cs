namespace InterpolationsLab
{
    partial class FormInterpolationLab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_Location = new System.Windows.Forms.Label();
            this.button_Lerp = new System.Windows.Forms.Button();
            this.chart_Plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Quadratic_Bezier = new System.Windows.Forms.Button();
            this.button_Cubic_Bezier = new System.Windows.Forms.Button();
            this.button_Cosine = new System.Windows.Forms.Button();
            this.button_SmoothStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Plot)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(786, 455);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Location = new System.Drawing.Point(24, 460);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(57, 13);
            this.label_Location.TabIndex = 3;
            this.label_Location.Text = "Location : ";
            // 
            // button_Lerp
            // 
            this.button_Lerp.Location = new System.Drawing.Point(624, 455);
            this.button_Lerp.Name = "button_Lerp";
            this.button_Lerp.Size = new System.Drawing.Size(66, 23);
            this.button_Lerp.TabIndex = 4;
            this.button_Lerp.Text = "LERP";
            this.button_Lerp.UseVisualStyleBackColor = true;
            this.button_Lerp.Click += new System.EventHandler(this.button_Lerp_Click);
            // 
            // chart_Plot
            // 
            chartArea3.AxisX.Interval = 100D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Maximum = 1000D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Interval = 20D;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Maximum = 180D;
            chartArea3.AxisY.Minimum = -180D;
            chartArea3.Name = "ChartArea_Main";
            this.chart_Plot.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_Plot.Legends.Add(legend3);
            this.chart_Plot.Location = new System.Drawing.Point(12, 23);
            this.chart_Plot.Name = "chart_Plot";
            this.chart_Plot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series13.ChartArea = "ChartArea_Main";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series13.Legend = "Legend1";
            series13.MarkerSize = 2;
            series13.Name = "Linear";
            series14.ChartArea = "ChartArea_Main";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series14.Legend = "Legend1";
            series14.MarkerSize = 2;
            series14.Name = "Cosine";
            series15.ChartArea = "ChartArea_Main";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.Legend = "Legend1";
            series15.MarkerSize = 2;
            series15.Name = "SmoothStep";
            series16.ChartArea = "ChartArea_Main";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series16.Legend = "Legend1";
            series16.Name = "Points";
            series17.ChartArea = "ChartArea_Main";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series17.Legend = "Legend1";
            series17.Name = "QuadraticBezier";
            series18.ChartArea = "ChartArea_Main";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series18.Legend = "Legend1";
            series18.Name = "CubicBezier";
            this.chart_Plot.Series.Add(series13);
            this.chart_Plot.Series.Add(series14);
            this.chart_Plot.Series.Add(series15);
            this.chart_Plot.Series.Add(series16);
            this.chart_Plot.Series.Add(series17);
            this.chart_Plot.Series.Add(series18);
            this.chart_Plot.Size = new System.Drawing.Size(923, 426);
            this.chart_Plot.TabIndex = 5;
            this.chart_Plot.Text = "Interpolations";
            this.chart_Plot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart_Plot_MouseClick);
            this.chart_Plot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_Plot_MouseMove);
            // 
            // button_Quadratic_Bezier
            // 
            this.button_Quadratic_Bezier.Location = new System.Drawing.Point(314, 455);
            this.button_Quadratic_Bezier.Name = "button_Quadratic_Bezier";
            this.button_Quadratic_Bezier.Size = new System.Drawing.Size(129, 23);
            this.button_Quadratic_Bezier.TabIndex = 6;
            this.button_Quadratic_Bezier.Text = "Quadratic Bezier";
            this.button_Quadratic_Bezier.UseVisualStyleBackColor = true;
            this.button_Quadratic_Bezier.Click += new System.EventHandler(this.button_Quadratic_Bezier_Click);
            // 
            // button_Cubic_Bezier
            // 
            this.button_Cubic_Bezier.Location = new System.Drawing.Point(179, 455);
            this.button_Cubic_Bezier.Name = "button_Cubic_Bezier";
            this.button_Cubic_Bezier.Size = new System.Drawing.Size(129, 23);
            this.button_Cubic_Bezier.TabIndex = 7;
            this.button_Cubic_Bezier.Text = "Cubic Bezier";
            this.button_Cubic_Bezier.UseVisualStyleBackColor = true;
            this.button_Cubic_Bezier.Click += new System.EventHandler(this.button_Cubic_Bezier_Click);
            // 
            // button_Cosine
            // 
            this.button_Cosine.Location = new System.Drawing.Point(557, 455);
            this.button_Cosine.Name = "button_Cosine";
            this.button_Cosine.Size = new System.Drawing.Size(61, 23);
            this.button_Cosine.TabIndex = 8;
            this.button_Cosine.Text = "Cosine";
            this.button_Cosine.UseVisualStyleBackColor = true;
            this.button_Cosine.Click += new System.EventHandler(this.button_Cosine_Click);
            // 
            // button_SmoothStep
            // 
            this.button_SmoothStep.Location = new System.Drawing.Point(468, 455);
            this.button_SmoothStep.Name = "button_SmoothStep";
            this.button_SmoothStep.Size = new System.Drawing.Size(83, 23);
            this.button_SmoothStep.TabIndex = 9;
            this.button_SmoothStep.Text = "SmoothStep";
            this.button_SmoothStep.UseVisualStyleBackColor = true;
            this.button_SmoothStep.Click += new System.EventHandler(this.button_SmoothStep_Click);
            // 
            // FormInterpolationLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 490);
            this.Controls.Add(this.button_SmoothStep);
            this.Controls.Add(this.button_Cosine);
            this.Controls.Add(this.button_Cubic_Bezier);
            this.Controls.Add(this.button_Quadratic_Bezier);
            this.Controls.Add(this.chart_Plot);
            this.Controls.Add(this.button_Lerp);
            this.Controls.Add(this.label_Location);
            this.Controls.Add(this.button_Clear);
            this.Name = "FormInterpolationLab";
            this.Text = "Interpolations Lab ( MindShine.ir )";
            ((System.ComponentModel.ISupportInitialize)(this.chart_Plot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Button button_Lerp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Plot;
        private System.Windows.Forms.Button button_Quadratic_Bezier;
        private System.Windows.Forms.Button button_Cubic_Bezier;
        private System.Windows.Forms.Button button_Cosine;
        private System.Windows.Forms.Button button_SmoothStep;

    }
}


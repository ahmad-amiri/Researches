
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InterpolationsLab
{

    public partial class FormInterpolationLab : Form
    {

        public FormInterpolationLab()
        {
            InitializeComponent();
            button_Clear.PerformClick();
        }

        private void button_Clear_Click(object sender, System.EventArgs e)
        {
            chart_Plot.Series["Points"].Points.Clear();
            chart_Plot.Series["Linear"].Points.Clear();
            chart_Plot.Series["Cosine"].Points.Clear();
            chart_Plot.Series["SmoothStep"].Points.Clear();
            chart_Plot.Series["QuadraticBezier"].Points.Clear();
            chart_Plot.Series["CubicBezier"].Points.Clear();

        }
 

        private void chart_Plot_MouseClick(object sender, MouseEventArgs e)
        {

            var pos = e.Location;
            var results = chart_Plot.HitTest(pos.X, pos.Y, false,
                                         ChartElementType.PlottingArea);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    var xVal = (float)Math.Round(result.ChartArea.AxisX.PixelPositionToValue(pos.X), 2);
                    var yVal = (float)Math.Round(result.ChartArea.AxisY.PixelPositionToValue(pos.Y), 2);
                    chart_Plot.Series["Points"].Points.AddXY(xVal, yVal);
                }
            }
        }

        private void chart_Plot_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            var results = chart_Plot.HitTest(pos.X, pos.Y, false,
                                         ChartElementType.PlottingArea);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    var xVal = (float)Math.Round(result.ChartArea.AxisX.PixelPositionToValue(pos.X), 2);
                    var yVal = (float)Math.Round(result.ChartArea.AxisY.PixelPositionToValue(pos.Y), 2);

                    label_Location.Text = "T = " + xVal + ", Value = " + yVal;

                }
            }
        }

        private void button_Quadratic_Bezier_Click(object sender, EventArgs e)
        {
            float p1;
            float p2;
            float p3;


            float startPointTime;
            float endPointTime;

            for (int i = 0; i < chart_Plot.Series["Points"].Points.Count - 2; i += 3)
            {

                if (i >= 3)
                {
                    p1 = (float)chart_Plot.Series["Points"].Points[i - 1].YValues[0];
                    p2 = (float)chart_Plot.Series["Points"].Points[i].YValues[0];
                    p3 = (float)chart_Plot.Series["Points"].Points[i + 1].YValues[0];

                    startPointTime = (float)chart_Plot.Series["Points"].Points[i - 1].XValue;
                    endPointTime = (float)chart_Plot.Series["Points"].Points[i + 1].XValue;
                }
                else
                {
                    p1 = (float)chart_Plot.Series["Points"].Points[i].YValues[0];
                    p2 = (float)chart_Plot.Series["Points"].Points[i + 1].YValues[0];
                    p3 = (float)chart_Plot.Series["Points"].Points[i + 2].YValues[0];

                    startPointTime = (float)chart_Plot.Series["Points"].Points[i].XValue;
                    endPointTime = (float)chart_Plot.Series["Points"].Points[i + 2].XValue;
                }



                var distance = endPointTime - startPointTime;

                for (float t = 0; t <= 1.0; t += 0.005f)
                {
                    var bezierPoint = Interpolations.QuadraticBezier(p1, p2, p3, t);
                    chart_Plot.Series["QuadraticBezier"].Points.AddXY(t * distance + startPointTime, bezierPoint);

                }
            }
        }

        private void button_Cubic_Bezier_Click(object sender, EventArgs e)
        {
            float p1;
            float p2;
            float p3;
            float p4;


            float startPointTime;
            float endPointTime;

            for (int i = 0; i < chart_Plot.Series["Points"].Points.Count - 3; i += 4)
            {

                if (i >= 3)
                {
                    p1 = (float)chart_Plot.Series["Points"].Points[i - 1].YValues[0];
                    p2 = (float)chart_Plot.Series["Points"].Points[i].YValues[0];
                    p3 = (float)chart_Plot.Series["Points"].Points[i + 1].YValues[0];
                    p4 = (float)chart_Plot.Series["Points"].Points[i + 2].YValues[0];

                    startPointTime = (float)chart_Plot.Series["Points"].Points[i - 1].XValue;
                    endPointTime = (float)chart_Plot.Series["Points"].Points[i + 2].XValue;
                }
                else
                {
                    p1 = (float)chart_Plot.Series["Points"].Points[i].YValues[0];
                    p2 = (float)chart_Plot.Series["Points"].Points[i + 1].YValues[0];
                    p3 = (float)chart_Plot.Series["Points"].Points[i + 2].YValues[0];
                    p4 = (float)chart_Plot.Series["Points"].Points[i + 3].YValues[0];

                    startPointTime = (float)chart_Plot.Series["Points"].Points[i].XValue;
                    endPointTime = (float)chart_Plot.Series["Points"].Points[i + 3].XValue;
                }



                var distance = endPointTime - startPointTime;

                for (float t = 0; t <= 1.0; t += 0.005f)
                {
                    var bezierPoint = Interpolations.CubicBezier(p1, p2, p3, p4, t);
                    chart_Plot.Series["CubicBezier"].Points.AddXY(t * distance + startPointTime, bezierPoint);

                }
            }
        }

        private void button_Lerp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chart_Plot.Series["Points"].Points.Count - 1; i++)
            {
                var p1 = (float)chart_Plot.Series["Points"].Points[i].YValues[0];
                var p2 = (float)chart_Plot.Series["Points"].Points[i + 1].YValues[0];

                var startPointTime = (float)chart_Plot.Series["Points"].Points[i].XValue;
                var endPointTime = (float)chart_Plot.Series["Points"].Points[i + 1].XValue;

                var distance = endPointTime - startPointTime;

                for (float t = 0; t <= 1.0; t += 0.005f)
                {

                    var lerpPoint = Interpolations.Linear(p1, p2, t);
                    chart_Plot.Series["Linear"].Points.AddXY(t * distance + startPointTime, lerpPoint);
                }
            }
        }

        private void button_Cosine_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chart_Plot.Series["Points"].Points.Count - 1; i++)
            {
                var p1 = (float)chart_Plot.Series["Points"].Points[i].YValues[0];
                var p2 = (float)chart_Plot.Series["Points"].Points[i + 1].YValues[0];

                var startPointTime = (float)chart_Plot.Series["Points"].Points[i].XValue;
                var endPointTime = (float)chart_Plot.Series["Points"].Points[i + 1].XValue;

                var distance = endPointTime - startPointTime;

                for (float t = 0; t <= 1.0; t += 0.005f)
                {
                    var cosinePoint = Interpolations.Cosine(p1, p2, t);
                    chart_Plot.Series["Cosine"].Points.AddXY(t * distance + startPointTime, cosinePoint);
                }
            }
        }

        private void button_SmoothStep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chart_Plot.Series["Points"].Points.Count - 1; i++)
            {
                var p1 = (float)chart_Plot.Series["Points"].Points[i].YValues[0];
                var p2 = (float)chart_Plot.Series["Points"].Points[i + 1].YValues[0];

                var startPointTime = (float)chart_Plot.Series["Points"].Points[i].XValue;
                var endPointTime = (float)chart_Plot.Series["Points"].Points[i + 1].XValue;

                var distance = endPointTime - startPointTime;

                for (float t = 0; t <= 1.0; t += 0.005f)
                {
                    var smoothPoint = Interpolations.SmoothStep(p1, p2, t);
                    chart_Plot.Series["SmoothStep"].Points.AddXY(t * distance + startPointTime, smoothPoint);
                }
            }
        }
    }
}

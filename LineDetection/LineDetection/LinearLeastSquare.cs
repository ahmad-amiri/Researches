using System;
using System.Collections.Generic;
using System.Drawing;


namespace Regression
{
    public class LinearLeastSquare : IModel
    {
        public double A1 { get; set; }
        public double A0 { set; get; }
        public void Fit(List<Point> dataset)
        {
            var m = dataset.Count;

            double xSigma = 0;
            double ySigma = 0;

            double x2Sigma = 0;
            double xySigma = 0;

            for (var i = 0; i < m; i++)
            {
                xSigma += dataset[i].X;
                ySigma += dataset[i].Y;

                x2Sigma += dataset[i].X * dataset[i].X;
                xySigma += dataset[i].X * dataset[i].Y;
            }

            A0 = (ySigma * x2Sigma - xSigma * xySigma) / (m * x2Sigma - (xSigma * xSigma));
            A1 = (m * xySigma - xSigma * ySigma) / (m * x2Sigma - (xSigma * xSigma));
        }


        public double GetError(List<Point> dataset)
        {
            // y = a1*x + a0;
            double errorSum = 0;
            double yModel;
            //double yData = 0;

            for (int i = 0; i < dataset.Count; i++)
            {
                yModel = A1 * dataset[i].X + A0;
                errorSum += Math.Pow(yModel - dataset[i].Y, 2);
            }

            return errorSum;
        }


        public double GetError(Point point)
        {
            var yModel = A1 * point.X + A0;
            return Math.Pow(yModel - point.Y, 2);
        }
    }
}

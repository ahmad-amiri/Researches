using System;
using System.Collections.Generic;
using System.Drawing;

namespace Regression
{
    public class RANSAC
    {
        private static Random randomGenerator = new Random(DateTime.Now.Millisecond);

            // http://en.wikipedia.org/w/index.php?title=RANSAC
            //Given:
            //    data - a set of observed data points
            //    model - a model that can be fitted to data points
            //    n - the minimum number of data values required to fit the model
            //    k - the maximum number of iterations allowed in the algorithm
            //    t - a threshold value for determining when a data point fits a model
            //    d - the number of close data values required to assert that a model fits well to data
            //Return:
            //    bestfit - model parameters which best fit the data (or nil if no good model is found)
            //iterations = 0
            //bestfit = nil
            //besterr = something really large
            //while iterations < k {
            //    maybeinliers = n randomly selected values from data
            //    maybemodel = model parameters fitted to maybeinliers
            //    alsoinliers = empty set
            //    for every point in data not in maybeinliers {
            //        if point fits maybemodel with an error smaller than t
            //             add point to alsoinliers
            //    }
            //    if the number of elements in alsoinliers is > d {
            //        % this implies that we may have found a good model
            //        % now test how good it is
            //        bettermodel = model parameters fitted to all points in maybeinliers and alsoinliers
            //        thiserr = a measure of how well model fits these points
            //        if thiserr < besterr {
            //            bestfit = bettermodel
            //            besterr = thiserr
            //        }
            //    }
            //    increment iterations
            //}
            //return bestfit
        private static int GetRandomNumber(int maxIndex)
        {
            return randomGenerator.Next(0, maxIndex);
        }
        public static LinearLeastSquare Fit(List<Point> data, int n, int k, double t, int d)
        {
            var iterations = 0;

            LinearLeastSquare bestFitModel = null;
            var bestError = Double.PositiveInfinity;

            while (iterations < k)
            {
                var maybeInliers = new List<Point>();
                var alsoInliers = new List<Point>();
                var maybeModel = new LinearLeastSquare();
                var maybeInliersIndexs = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    var index = GetRandomNumber(data.Count - 1);
                    maybeInliersIndexs.Add(index);
                    maybeInliers.Add(new Point(data[index].X, data[index].Y));
                }

                maybeModel.Fit(maybeInliers);

                for (int j = 0; j < data.Count; j++)
                {
                    if (!maybeInliersIndexs.Contains(j))
                    {
                        if (maybeModel.GetError(data[j]) < t) // fit with error smaller than t 
                        {
                            alsoInliers.Add(data[j]);
                        }
                    }
                }
                if (alsoInliers.Count > d)
                {
                    // this implies that we may have found a good model
                    // now test how good it is
                    var mergedDataset = new List<Point>();
                    mergedDataset.AddRange(alsoInliers);
                    mergedDataset.AddRange(maybeInliers);

                    var betterModel = new LinearLeastSquare();
                    betterModel.Fit(mergedDataset);
                    var thisError = betterModel.GetError(mergedDataset);
                    if (thisError < bestError)
                    {
                        bestFitModel = betterModel;
                        bestError = thisError;
                    }
                }

                iterations++;
            }
            return bestFitModel;
        }

    }
}

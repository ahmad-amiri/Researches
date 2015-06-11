using System.Collections.Generic;
using System.Drawing;


namespace Regression
{
    public interface IModel
    {
        /// <summary>
        /// Read Current State of Actuator. 
        /// </summary>
        void Fit(List<Point> dataset);
        double GetError(List<Point> dataset);
        double GetError(Point point);
    }
}

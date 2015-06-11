
using System;
using System.Drawing;

namespace InterpolationsLab
{
    public class Interpolations
    {

        public static float Linear(float p0, float p1, float t)
        {
            // Imprecise method which does not guarantee v = v1 when t = 1,
            // due to floating-point arithmetic error.
            //return p0 + t*(p1-p0);

            return (1 - t) * p0 + t * p1;
        }

        public static PointF Linear(PointF p1, PointF p2, float t)
        {
            return new PointF(Linear(p1.X, p2.X, t), Linear(p1.Y, p2.Y, t));
        }

        public static float Cosine(float p1, float p2, float t)
        {
            var newT = (float)(0.5 - (Math.Cos(Math.PI * t) / 2));
            return Linear(p1, p2, newT);
        }

        public static PointF Cosine(PointF p1, PointF p2, float t)
        {
            return new PointF(Cosine(p1.X, p2.X, t), Cosine(p1.Y, p2.Y, t));

        }

        public static float SmoothStep(float p1, float p2, float t)
        {
            var newT = ((t * t) * (3 - (2 * t)));
            return Linear(p1, p2, newT);
        }

        public static PointF SmoothStep(PointF p1, PointF p2, float t)
        {
            return new PointF(SmoothStep(p1.X, p2.X, t), SmoothStep(p1.Y, p2.Y, t));
        }

        public static float QuadraticBezier(float p1, float p2, float p3, float t)
        {
            return (((1 - t) * (1 - t)) * p1) + (2 * (1 - t) * t * p2) + (t * t * p3);
        }

        public static float CubicBezier(float p1, float p2, float p3, float p4, float t)
        {
            return ((1 - t) * (1 - t) * (1 - t) * p1) + (3 * (1 - t) * (1 - t) * t * p2) + (3 * (1 - t) * t * t * p3) + (t * t * t * p4);
        }
    }
}

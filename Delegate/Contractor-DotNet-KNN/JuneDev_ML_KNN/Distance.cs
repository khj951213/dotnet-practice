using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuneDev_ML_KNN
{
    public static class Distance
    {
        public static double EuclideanDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); 
        }
        public static double EuclideanDistance(double[] p, double[] q)
        {
            return Math.Sqrt(Math.Round(Math.Pow(q[0] - p[0], 2), 4, MidpointRounding.ToEven) + Math.Round(Math.Pow(q[1] - p[1], 2), 4, MidpointRounding.ToEven));
        }
    }
}

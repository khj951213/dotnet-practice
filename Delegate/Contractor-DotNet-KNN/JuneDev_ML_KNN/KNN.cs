namespace JuneDev_ML_KNN
{
    public class KNN
    {
        private readonly int _k; // find k neighbours
        private double[][] _points;

        public KNN(int k = 5)
        {
            _k = k;
            _points = new double[0][];
        }

        public void Fit(double[][] points)
        {
            _points = points;
        }

        public double[] Predict(double[] newPoint)
        {
            var distances = new double[_points.Length];

            for (int i = 0; i < _points.Length; i++)
            {
                distances[i] = Distance.EuclideanDistance(_points[i], newPoint);
            }

            //Array.Sort(distances);
            var res = new double[_k];
            for (int i = 0; i < _k; i++)
            {
                if (distances.Length-1 < i) break;
                res[i] = distances[i];
            }
            return res;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ObjectTracking
    {
        List<double> X = new List<double>(); // координаты X
        List<double> Y = new List<double>(); // координаты Y
        double[,] Vector = new double[1, 51]; // Вектор
        double[,] Vivlet = new double[64, 51]; // Вивлет

        public ObjectTracking(List<double> X, List<double> Y) {
            this.X = X;
            this.Y = Y;
            for (int i = 0; i < 51; i++)
            {
                Vector[0, i] = Math.Sqrt(Math.Pow((X[i+1] - X[i]),2)+Math.Pow((Y[i + 1] - Y[i]), 2));
                // sqrt((XY(i + 1, 1) - XY(i, 1)) ^ 2 + (XY(i + 1, 2) - XY(i, 2)) ^ 2);
            }

        }
    }
}

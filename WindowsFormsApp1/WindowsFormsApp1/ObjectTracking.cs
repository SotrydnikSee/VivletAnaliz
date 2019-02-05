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
        object result = null;
        public ObjectTracking(List<double> X, List<double> Y) {
            this.X = X;
            this.Y = Y;
            for (int i = 0; i < 51; i++)
            {
                Vector[0, i] = Math.Sqrt(Math.Pow((X[i+1] - X[i]),2)+Math.Pow((Y[i + 1] - Y[i]), 2));
                // sqrt((XY(i + 1, 1) - XY(i, 1)) ^ 2 + (XY(i + 1, 2) - XY(i, 2)) ^ 2);
            }

            MLApp.MLApp matlab = new MLApp.MLApp();
            matlab.Execute(@"cd c:\Users\vyrex2\Source\Repos\VivletAnaliz\WindowsFormsApp1\WindowsFormsApp1\sourse");
            matlab.Feval("myfunc", 1, out result, Vector);
            var res = (result as object[]).Select(x => (double[,])x).ToArray();
            object im = res.GetValue(0);
            Vivlet = (double[,])im;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    class ObjectTracking
    {
        private List<double> X; // координаты X
        private List<double> Y; // координаты Y
        private double[,] Vector = new double[1, 51]; // Вектор
        private double[,] Vivlet = new double[64, 51]; // Вивлет
        private object result = null; // создание object для вывода вивлета
        public ObjectTracking(List<double> X, List<double> Y) { // базовый конструктор
            this.X = new List<double>(X); // задача листов X
            this.Y = new List<double>(Y); // задача листов Y
            for (int i = 0; i < 51; i++) // считаем вектор 1х51
            {
                Vector[0, i] = Math.Sqrt(Math.Pow((X[i+1] - X[i]),2)+Math.Pow((Y[i + 1] - Y[i]), 2));
            }

            MLApp.MLApp matlab = new MLApp.MLApp(); // подключаем библиотеку матлаб
            string path ="cd " + Directory.GetCurrentDirectory(); // получаем директорию в которой находися программа
            matlab.Execute(path); // находим в папке функции
            matlab.Feval("myfunc", 1, out result, Vector); // запускает функцию матлаб
            GetVevlet(result); // получаем вивлет
        }
        public void GetVevlet(object result) { // функция получения вивлета
            var res = (result as object[]).Select(x => (double[,])x).ToArray(); // хз
            object im = res.GetValue(0); // хз
            Vivlet = (double[,])im; // хз
        }
    }
}

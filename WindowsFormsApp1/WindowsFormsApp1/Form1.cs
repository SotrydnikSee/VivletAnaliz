using System;
using System.Collections.Generic;
/*using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        List<ObjectTracking> ListObject = new List<ObjectTracking>(); // лист объектов получаемых из файла
        List<double> X = new List<double>(); // временный лист X
        List<double> Y = new List<double>(); // временный лист Y
        string pathStoreData = "../../data";
        List<ObjectTracking>[] ArrayListObject;
        private void Form1_Load(object sender, EventArgs e)
        {

            DirectoryInfo storeData = new DirectoryInfo(pathStoreData);
            int countFiles = storeData.GetFiles().Length; // количество подключаемых файлов
            ArrayListObject = new List<ObjectTracking>[countFiles]; // массив листов объектов

            if (File.Exists("myfunc.m")) { // если файл существует
                File.Delete("myfunc.m"); // то удаляем его 
            }
                StreamWriter myfunc = new StreamWriter("myfunc.m",true); // берем файл функции для записи
                myfunc.WriteLine("function[W] = myfunc(vector)"); // записываем строчки 
                myfunc.WriteLine("W=cwt(vector,1:64,'sym2');");// записываем строчки 
                myfunc.Close();// закрываем файл
            int countObj = 0;
            for (int i = 0; i < countFiles; i++)
            {
                string nameFile = storeData.GetFiles().GetValue(i).ToString();
                StreamReader fileStoreData = new StreamReader(pathStoreData + "/" + nameFile,true);
                comboBox_obj1.Items.Add(nameFile);
                comboBox_obj2.Items.Add(nameFile);
                countObj = -1;
                ArrayListObject[i] = new List<ObjectTracking>();
                while (!fileStoreData.EndOfStream)
                {
                    string line = fileStoreData.ReadLine(); // читаем строку
                    if (line != "") // Если строчка не пуста
                    {
                        if (line[0] == '#') // если строка начинается с шарпа создаем объект
                        {
                            countObj++; //добавляем
                        }
                        else // если находимся на координатах
                        {
                            string[] XY = line.Split(' '); // делим строку на X и Y
                            X.Add(Convert.ToDouble(XY[0])); // Создаем временный лист всех X
                            Y.Add(Convert.ToDouble(XY[1])); // Создаем временный лист всех Y
                        }
                    }
                    else
                    { // если строчка пуста, пора закончить работать с объектом
                        ObjectTracking objectTracking = new ObjectTracking(X, Y); // Создаем экземпляр объекта из временных X,Y
                        
                        ArrayListObject[i].Add(objectTracking);
                        // ListObject.Add(objectTracking);// добавляем объект в лист
                        objectTracking = null;
                        X.Clear(); // Обнуление X
                        Y.Clear(); // Обнулиние Y
                    }
                }

                fileStoreData.Close();
            }
            comboBox_obj1.SelectedIndex = 0;
            comboBox_obj2.SelectedIndex = 0;
            countObj = 0;
            foreach (var List in ArrayListObject) {
                countObj += List.Count;
            }
            labelTest.Text = "Количество объектов: " + countObj; // Вывод количества объектов

            /*
            StreamReader f1 = new StreamReader("../../date/Машина.txt",true); // подключение файлов с объектами
            int count = -1; // счетчик объектов, счет с нуля, их нет, поэтому -1
            while (!f1.EndOfStream)
            { // пока файл не закончится читаться
                string line = f1.ReadLine(); // читаем строку
                if (line != "") // Если строчка не пуста
                {
                    if (line[0] == '#') // если строка начинается с шарпа создаем объект
                    {
                        count++; //добавляем
                    }
                    else // если находимся на координатах
                    {
                        string[] XY = line.Split(' '); // делим строку на X и Y
                        X.Add(Convert.ToDouble(XY[0])); // Создаем временный лист всех X
                        Y.Add(Convert.ToDouble(XY[1])); // Создаем временный лист всех Y
                    }
                }
                else { // если строчка пуста, пора закончить работать с объектом
                    ObjectTracking objectTracking = new ObjectTracking(X,Y); // Создаем экземпляр объекта из временных X,Y
                    ListObject.Add(objectTracking);// добавляем объект в лист
                    X.Clear(); // Обнуление X
                    Y.Clear(); // Обнулиние Y
                }
            }
            labelTest.Text = "Количество объектов: "+ ++count; // Вывод количества объектов
            f1.Close(); // закрываем файл
            */




            //  ТЕСТОВЫЕ ДАННЫЕ


            /*
            object result = null;
            
            double[,] vector = { { 0.000699999999994816, 0.718991634165512, 2.24023204601666, 0.827847534271867, 0.960432038199458, 0.893987975310634, 1.75503766341351, 1.50283444530663, 0.000100000000003320, 0.725107061060612, 0.904036835532728, 0.536769457029737, 1.29643642343154, 0.718346023863153, 0.933313634315936, 0.623039725860238, 0.00318904374378455, 1.42744393935453, 0.585223717906231, 0.515929888647688, 0.605800775833107, 0.715809709350172, 1.45790495232030, 0.827865907016347, 0.905862020398250, 0.844827562287118, 1.15274979939273, 1.46710213686711, 0.593301146130685, 0.953149190840553, 0.874844740511155, 0.665121650527175, 0.546910193724696, 1.14467538193151, 0.620994049890962, 0.610883139397382, 0.686686551492032, 2.36584003051769, 0.783467421147803, 0.736839202268718, 0.00247386337539068, 0.820490786054283, 1.92080942573697, 0.676111618003994, 0.774127360322574, 0.884871928586290, 0.891909776827248, 0.693773983369218, 0.664354491216838, 0.903797543701028, 0.702351507437690 } };

            // НЕХВАТАЕТ ПОДКЛЮЧЕНИЯ МАТКАДА
            var res = (result as object[]).Select(x => (double[,])x).ToArray();
            object im = res.GetValue(0);
            var vivlet = new double[64,51];
            vivlet = (double[,])im;*/
        }
        private void comboBox_obj_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox; // получаем изменяемый комбобокс
            int SelectFileIndex = combo.SelectedIndex; // получаем индекс выбранного файла
            int MaxValue = ArrayListObject[SelectFileIndex].Count;
            foreach (object item in combo.Parent.Controls)
            {
                
                if (item.GetType().Name.ToString() == "NumericUpDown") {
                    NumericUpDown numericUpDown = item as NumericUpDown;
                    numericUpDown.Maximum = MaxValue;
                }
            }
            numericUpDown_obj1_start.Maximum = MaxValue;
            numericUpDown_obj1_end.Maximum = MaxValue;
        }

        private void numericUpDown_obj_start_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int MinValue = (int)numericUpDown.Value;
            foreach (object item in numericUpDown.Parent.Controls)
            {
                
                if (item.GetType().Name.ToString() == "NumericUpDown")
                {
                    
                    if (item != sender) {
                        NumericUpDown numericUpDownChange = item as NumericUpDown;
                        numericUpDownChange.Minimum = MinValue;
                    }
                }
            }
        }

        private void numericUpDown_obj_end_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int MaxValue = (int)numericUpDown.Value;
            foreach (object item in numericUpDown.Parent.Controls)
            {

                if (item.GetType().Name.ToString() == "NumericUpDown")
                {

                    if (item != sender)
                    {
                        NumericUpDown numericUpDownChange = item as NumericUpDown;
                        numericUpDownChange.Maximum = MaxValue;
                    }
                }
            }
        }
    }
}

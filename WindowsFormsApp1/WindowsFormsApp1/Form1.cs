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
using Excel = Microsoft.Office.Interop.Excel;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            workbook = excelApp.Workbooks.Add();
            worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            /*for (int i = 0; i < 51; i++) {
                for (int j = 0; j < 64; j++){
                    worksheet.Cells[j + 1, i + 1] = ArrayListObject[1][1].GetVevlet - ArrayListObject[0][1];
                }
            }*/
        }
    }
}

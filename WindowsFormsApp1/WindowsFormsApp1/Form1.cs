using System;
using System.Collections.Generic;
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
        string pathStoreData = "../../data"; // получение пути файлов
        List<ObjectTracking>[] ArrayListObject; // создание массива листов объектов
        private void Form1_Load(object sender, EventArgs e)
        {

            DirectoryInfo storeData = new DirectoryInfo(pathStoreData); // узнаем где лежит программа
            int countFiles = storeData.GetFiles().Length; // количество подключаемых файлов
            ArrayListObject = new List<ObjectTracking>[countFiles]; // массив листов объектов

            if (File.Exists("myfunc.m")) { // если файл существует
                File.Delete("myfunc.m"); // то удаляем его 
            }
                StreamWriter myfunc = new StreamWriter("myfunc.m",true); // берем файл функции для записи
                myfunc.WriteLine("function[W] = myfunc(vector)"); // записываем строчки 
                myfunc.WriteLine("W=cwt(vector,1:64,'sym2');");// записываем строчки 
                myfunc.Close();// закрываем файл
            int countObj = 0; // изначально то файлов нет
            for (int i = 0; i < countFiles; i++) // цикл по парсингу каждого файла
            {
                string nameFile = storeData.GetFiles().GetValue(i).ToString(); // название файла для вывода в комбоБокс
                StreamReader fileStoreData = new StreamReader(pathStoreData + "/" + nameFile,true); // читаем файл комбинацией путь+названиефайла
                comboBox_obj1.Items.Add(nameFile); // добавляем в комбоБокс
                comboBox_obj2.Items.Add(nameFile); // добавляем в комбоБокс
                countObj = -1; // из за наличие нулевого индеккса
                ArrayListObject[i] = new List<ObjectTracking>(); // создаем экземпляр объекта
                while (!fileStoreData.EndOfStream) // пока файл не закончится
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

                        ArrayListObject[i].Add(objectTracking); // добавляем объект
                        objectTracking = null; // обнуляем временную переменную
                        X.Clear(); // Обнуление X
                        Y.Clear(); // Обнулиние Y
                    }
                }

                fileStoreData.Close(); // закрываем файл
            }
            comboBox_obj1.SelectedIndex = 0; // после парсинга выбираем первый объект из списка
            comboBox_obj2.SelectedIndex = 0; // после парсинга выбираем первый объект из списка
            countObj = 0; // переменная для подсчета всех объектов
            foreach (var List in ArrayListObject) { // подсчет всех объектов
                countObj += List.Count;
            }
            labelTest.Text = "Количество объектов: " + countObj; // Вывод количества объектов
        }
        private void comboBox_obj_SelectedIndexChanged(object sender, EventArgs e) // когда выбираем что то из комбобокса
        {
            ComboBox combo = sender as ComboBox; // получаем изменяемый комбобокс
            int SelectFileIndex = combo.SelectedIndex; // получаем индекс выбранного файла
            int MaxValue = ArrayListObject[SelectFileIndex].Count; // максимальное значение из выбранного объекта
            foreach (object item in combo.Parent.Controls) //шагаем по всем контролам 
            {
                
                if (item.GetType().Name.ToString() == "NumericUpDown") { // если это нужный котролер
                    NumericUpDown numericUpDown = item as NumericUpDown;
                    numericUpDown.Maximum = MaxValue; // задаем ему максимальное значение
                }
            }
        }

        private void numericUpDown_obj_start_ValueChanged(object sender, EventArgs e) // при изменении контрола начала
        {
            NumericUpDown numericUpDown = sender as NumericUpDown; 
            int MinValue = (int)numericUpDown.Value;
            foreach (object item in numericUpDown.Parent.Controls) // изменяем минимальное значение контрола конца
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

        private void numericUpDown_obj_end_ValueChanged(object sender, EventArgs e) // при изменении контрола конца
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int MaxValue = (int)numericUpDown.Value;
            foreach (object item in numericUpDown.Parent.Controls) // изменяем максимальное значение контрола начала
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

        private void buttonExcel_Click(object sender, EventArgs e) // кнопка вывода в эксель
        {
            Excel.Application excelApp = new Excel.Application(); // открывает приложение эексель
            Excel.Workbook workbook; // создаем книгу
            Excel.Worksheet worksheet; //  создаем переменную листа
            workbook = excelApp.Workbooks.Add(); // добавляем лист в книгу
            int maxValueObj1 = (int)numericUpDown_obj1_end.Value; // получаем максимальное значение количества первого объекта
            int maxValueObj2 = (int)numericUpDown_obj2_end.Value; // получаем максимальное значение количества второго объекта
            excelApp.Visible = true; // показываем весь процесс
            for (int ValueObj1 = (int)numericUpDown_obj1_start.Value - 1; ValueObj1 < maxValueObj1; ValueObj1++) // относительно всех первых объектов
            {
                for (int ValueObj2 = (int)numericUpDown_obj2_start.Value - 1; ValueObj2 < maxValueObj2; ValueObj2++) // вычитаем вторые объекты
                {
                    
                    workbook.Worksheets.Add(); // добавляем лист
                    worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1); // обращаемся к созданному листу
                    int CountObj1 = ValueObj1 + 1; //определяем номер объекта из первого списка
                    int CountObj2 = ValueObj2 + 1; //определяем номер объекта из второго списка
                    worksheet.Name = "obj1_№" + CountObj1 + " vs obj2_№" + CountObj2; // формируем название листа
                    for (int i = 0; i < 51; i++) // цикл формирование листа
                    {
                        for (int j = 0; j < 64; j++)
                        {
                            double result = Math.Abs(ArrayListObject[comboBox_obj1.SelectedIndex][ValueObj1].vivlet[j, i] - ArrayListObject[comboBox_obj2.SelectedIndex][ValueObj2].vivlet[j, i]);
                            worksheet.Cells[j + 1, i + 1] = result;
                            (worksheet.Cells[j + 1, i + 1] as Excel.Range).Interior.Color = Excel.XlRgbColor.rgbGreen;
                            if (result > 0.1)
                                (worksheet.Cells[j + 1, i + 1] as Excel.Range).Interior.Color = Excel.XlRgbColor.rgbGreen;
                            if (result > 0.3)
                                (worksheet.Cells[j + 1, i + 1] as Excel.Range).Interior.Color = Excel.XlRgbColor.rgbYellow;
                            if (result > 0.5)
                                (worksheet.Cells[j + 1, i + 1] as Excel.Range).Interior.Color = Excel.XlRgbColor.rgbRed;

                        }
                    }
                }
            }
            excelApp.UserControl = true;
        }
    }
}

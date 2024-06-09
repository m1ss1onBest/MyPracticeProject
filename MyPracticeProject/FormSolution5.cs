using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace MyPracticeProject
{
    public partial class FormSolution5 : Form
    {
        private struct Student
        {
            public string FullName { set; get; }
            public UInt16 Age { set; get; }
            public UInt16 Height { set; get; } 
            public UInt16 Weight { set; get; }

            public Student(string fullName, UInt16 age, UInt16 height, UInt16 weight)
            {
                FullName = fullName;
                Age = age;
                Height = height;
                Weight = weight;
            }
        }
        private List<Student> Students { set; get; }

        private enum Operations { none, edit, find, delete };
        private Operations CurrentOperation = Operations.none;
        
        //
        // REGION form initialization
        //
        public FormSolution5()
        {
            InitializeComponent();
        }
        public static void Start()
        {
            var formSolution5 = new FormSolution5();
            formSolution5.Show();
        }
        private void toolStrip_FILE_exit_Click(object sender, EventArgs e) => Close();
        private void FormSolution5_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();
        private void FormSolution5_Load(object sender, EventArgs e)
        {
            // setting variables
            Students = new List<Student>();
            // setting label text
            labelFullName.Text = @"ПIБ";
            labelAge.Text = @"Вiк";
            labelHeight.Text = @"Зрiст";
            labelWeight.Text = @"Вага";


            labelVariantDescription.Text =
                "Створити і вивести на екран  масив з довільною кількістю записів (не меньше 10) по індивідуальному завданню. Записати в файл, визначити структуру файла. Знайти в файлі і вивести на екран результати обробки запитів. " +
                "Програма має виводити на екран меню з командами: 1 - створення файлу 2 - перегляд файлу 3 - додавання до файлу 4 - обробка файлу( додавання, редагування, вилучення записів, пошук, обчислення) 5 – вихід ВАРІАНТИ ЗАВДАНЬ \n\u211627 Список студентів групи містить наступну інформацію: П.І.Б.,вік, ріст і вага. Вивести П.І.Б. студентів, ріст і вага яких є в списку унікальними(тобто не повторюються). До завдання 5 оформити звіт про технологію виконання завдання за зразком";
            // setting text boxes
            textBoxFullName.Text = textBoxAge.Text = textBoxHeight.Text = textBoxWeight.Text = textboxHelp.Text = "";
            textboxHelp.Enabled = false;
            // setting buttons
            toolStrip_FILE.Text = @"Файл";
            toolStrip_FILE_new.Text = @"Створити файл";
            toolStrip_FILE_add.Text = @"Додати у файл";
            toolStrip_FILE_load.Text = @"Завантажити файл";

            toolStrip_FILE_STUD.Text = @"Опрацювання";
            toolStrip_FILE_STUD_add.Text = @"Додати студента";
            toolStrip_FILE_STUD_edit.Text = @"Редагувати студента";
            toolStrip_FILE_STUD_delete.Text = @"Видалити студента";
            toolStrip_FILE_STUD_find.Text = @"Знайти за унiкальним зростом та вагою";
            toolStrip_FILE_exit.Text = @"Вихiд";
            
            // setting data grid
            dataGridViewStudents.Columns.Add("LastName", "LastName");
            dataGridViewStudents.Columns.Add("Age", "Age");
            dataGridViewStudents.Columns.Add("Height", "Height");
            dataGridViewStudents.Columns.Add("Weight", "Weight");
        }
        
        //
        // REGION Data
        //
        
        private void AddToDataGrid(DataGridView dataGridView, Student student)
        {
            dataGridView.Rows.Add(student.FullName, student.Age, student.Height, student.Weight);
        }

        private void AddToFile(string filePath, Student student)
        {
            XElement studentElement = new XElement("Student",
                new XElement("FullName", student.FullName),
                new XElement("Age", student.Age),
                new XElement("Height", student.Height),
                new XElement("Weight", student.Weight));

            XDocument doc;
            if (File.Exists(filePath))
            {
                doc = XDocument.Load(filePath);
                doc.Root?.Add(studentElement);
            }
            else
            {
                doc = new XDocument(new XElement("Student", studentElement));
            }
            doc.Save(filePath);
        }

        //
        // REGION File
        private void CreateFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = @"XML файл (*.xml)|*.xml";
            dialog.Title = @"Зберегти файл як";

            if (Students.Count == 0)
            {
                MessageBox.Show(@"Немає даних для збереження", @"Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XDocument doc = new XDocument(new XDeclaration("1.0", "windows-1251", "yes"));
                XElement root = new XElement("Students");
                foreach (Student student in Students)
                {
                    XElement studentElement = new XElement("Student",
                        new XElement("FullName", student.FullName),
                        new XElement("Age", student.Age),
                        new XElement("Height", student.Height),
                        new XElement("Weight", student.Weight));
                    root.Add(studentElement);
                }
                doc.Add(root);
                doc.Save(dialog.FileName);
            }
        }

        private void LoadFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"XML файл (*.xml)|*.xml";
            dialog.Title = @"Відкрити файл";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Students.Clear();
                dataGridViewStudents.Rows.Clear();
                
                XDocument doc = XDocument.Load(dialog.FileName);
                foreach (XElement studentElement in doc.Descendants("Student"))
                {
                    string fullName = studentElement.Element("FullName")?.Value;
                    if (!UInt16.TryParse(studentElement.Element("Age")?.Value, out var age) ||
                        !UInt16.TryParse(studentElement.Element("Height")?.Value, out var height) ||
                        !UInt16.TryParse(studentElement.Element("Weight")?.Value, out var weight))
                    {
                        MessageBox.Show(@"Помилка пiд час читання файлу", @"Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Student student = new Student(fullName, age, height, weight); 
                    Students.Add(student);
                    AddToDataGrid(dataGridViewStudents, student);
                }
            }
        }
        
        private void toolStrip_FILE_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"XML файл (*.xml)|*.xml";
            dialog.Title = @"Додати у файл записи";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Student student in Students)
                {
                    AddToFile(dialog.FileName, student);
                }

                Students = new List<Student>();
                dataGridViewStudents.Rows.Clear();
                MessageBox.Show(@"Данi успiшно доданi у файл", @"Успiх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //
        // REGION Student
        //

        private void NewStudent_StripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxHeight.Text) ||
                string.IsNullOrWhiteSpace(textBoxAge.Text) ||
                string.IsNullOrWhiteSpace(textBoxWeight.Text))
            {
                MessageBox.Show(@"Поля не заповненi!", @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!UInt16.TryParse(textBoxAge.Text, out UInt16 age) ||
                !UInt16.TryParse(textBoxHeight.Text, out UInt16 height) ||
                !UInt16.TryParse(textBoxWeight.Text, out UInt16 weight))
            {
                MessageBox.Show(@"Некорректно введенi числовi значення.", @"Помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Student student = new Student
            {
                FullName = textBoxFullName.Text,
                Age = age,
                Height = height,
                Weight = weight
            };
            Students.Add(student);
            AddToDataGrid(dataGridViewStudents, student);
        }

        private void FindStudentsByParams()
        {
            
        }

        private void SetTextBoxHelp()
        {
            CurrentOperation = Operations.find;
            textboxHelp.Enabled = true;
            textboxHelp.ForeColor = Color.Red;
            textboxHelp.Text = @"Ось тут";
            MessageBox.Show("Введiть у текстове поле зверху ПIБ студента та натиснiть enter", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void toolStrip_FILE_STUD_edit_Click(object sender, EventArgs e)
        {
            SetTextBoxHelp();
            CurrentOperation = Operations.edit;
            
        }

        private void textboxHelp_MouseEnter(object sender, EventArgs e)
        {
            textboxHelp.ForeColor = Color.Black;
            textboxHelp.Text = "";
        }

        private void textboxHelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                if (string.IsNullOrEmpty(textboxHelp.Text) || textboxHelp.Text.Length < 5)
                {
                    MessageBox.Show("Помилка введення даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Student stud;
                
                UInt16 age, height, weight;

         

                
                
                switch (CurrentOperation)
                {
                    case Operations.edit:
                        
                        if ((string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                             string.IsNullOrWhiteSpace(textBoxHeight.Text) ||
                             string.IsNullOrWhiteSpace(textBoxAge.Text) ||
                             string.IsNullOrWhiteSpace(textBoxWeight.Text)) && CurrentOperation == Operations.delete)
                        {
                            MessageBox.Show(@"Поля не заповненi!", @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                
                        if ((!UInt16.TryParse(textBoxAge.Text, out age) ||
                             !UInt16.TryParse(textBoxHeight.Text, out height) ||
                             !UInt16.TryParse(textBoxWeight.Text, out weight)))
                        {
                            MessageBox.Show(@"Некорректно введенi числовi значення.", @"Помилка", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }

                        stud = new Student
                        {
                            FullName = textBoxFullName.Text,
                            Age = age,
                            Height = height,
                            Weight = weight
                        };
                        
                        for (int i = 0; i < Students.Count; i++)
                        {
                            if (Students[i].FullName == textboxHelp.Text)
                            {
                                Students[i] = stud;
                                dataGridViewStudents.Rows.Clear();
                                // return;
                                textboxHelp.Text = "";
                            }
                        }

                        foreach (Student student in Students)
                        {
                            AddToDataGrid(dataGridViewStudents, student);
                        }
                        textboxHelp.Enabled = false; 
                        break;
                    
                    case Operations.delete:
                        for (int i = 0; i < Students.Count; i++)
                        {
                            if (Students[i].FullName == textboxHelp.Text)
                            {
                                Students.RemoveAt(i);
                                dataGridViewStudents.Rows.Clear();
                                textboxHelp.Text = "";
                            }
                        }

                        foreach (Student student in Students)
                        {
                            AddToDataGrid(dataGridViewStudents, student);
                        }
                        break;
                }
            }
        }

        private void toolStrip_FILE_STUD_delete_Click(object sender, EventArgs e)
        {
            SetTextBoxHelp();
            CurrentOperation = Operations.delete;
        }

        private void toolStrip_FILE_STUD_find_Click(object sender, EventArgs e)
        {
            int height = Students[0].Height, weight = Students[0].Weight;
            for (int i = 1; i < Students.Count; i++)
            {
                height ^= Students[i].Height;
                weight ^= Students[i].Weight;
            }

            List<Student> sorted = new List<Student>();
            foreach (Student student in Students)
            {
                if (student.Height == height && student.Weight == weight)
                {
                    sorted.Add(student);
                }
            }

            if (sorted.Count == 0)
            {
                MessageBox.Show("Немає студентiв що задовiльняють запиту", "Увага!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            
            dataGridViewStudents.Rows.Clear();
            foreach (Student student in sorted)
            {
                AddToDataGrid(dataGridViewStudents, student);
            }
        }
    }
}

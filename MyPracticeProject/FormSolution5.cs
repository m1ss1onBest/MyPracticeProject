﻿using System;
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
        // student data type
        private struct Student
        {
            // used as student's full name (Lastname N. F.)
            public string FullName { set; get; }
            // student's age
            public UInt16 Age { set; get; }
            // student's height
            public UInt16 Height { set; get; } 
            // student's weight
            public UInt16 Weight { set; get; }
            
            // default constructor
            public Student(string fullName, UInt16 age, UInt16 height, UInt16 weight)
            {
                FullName = fullName;
                Age = age;
                Height = height;
                Weight = weight;
            }
        }
        
        // list of student's used to contain student data type
        private List<Student> Students { set; get; }

        // enumeration of poss
        private enum Operations { none, edit, find, delete }
        // current operation, none by default
        private Operations CurrentOperation = Operations.none;
        
        //
        // REGION form initialization
        //
        
        // Tab Control init
        public FormSolution5() => InitializeComponent();
        
        // used to start form from another form
        public static void Start()
        {
            var formSolution5 = new FormSolution5();
            formSolution5.Show();
        }
        
        // exit form
        private void toolStrip_FILE_exit_Click(object sender, EventArgs e) => Close();
        
        // exit the application when form closed
        private void FormSolution5_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.Start();
        }
        
        // default form components initialization
        private void FormSolution5_Load(object sender, EventArgs e)
        {
            // setting variables
            Students = new List<Student>();
            
            // setting label text
            labelFullName.Text = @"ПIБ";
            labelAge.Text = @"Вiк";
            labelHeight.Text = @"Зрiст";
            labelWeight.Text = @"Вага";

            Text = "База даних студентiв";
            labelVariantDescription.Text =
                "Створити і вивести на екран список з довільною кількістю записів (не меньше 10) по індивідуальному завданню. Записати в файл, визначити структуру файла. Знайти в файлі і вивести на екран результати обробки запитів. " +
                "Програма має виводити на екран меню з командами: 1 - створення, перегляд, додавання до файлу 4 - обробка файлу( додавання, редагування, вилучення записів, пошук, обчислення). Вивести на екран студентiв зрiст i вага яких є унiкальними";
     
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
        
        // adding student to data grid view
        private void AddToDataGrid(DataGridView dataGridView, Student student)
        {
            dataGridView.Rows.Add(student.FullName, student.Age, student.Height, student.Weight);
        }

        // adding student to file
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
        //
        
        // creates file
        private void CreateFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Students.Count < 10)
            {
                MessageBox.Show("Кiлькiсть записiв менша 10", "неможливо записати файл", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
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

        // reading data from file
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
        
        // add data from array to file
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

        // add new student to data
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

        // setting text box visible
        private void SetTextBoxHelp()
        {
            CurrentOperation = Operations.find;
            textboxHelp.Enabled = true;
            textboxHelp.ForeColor = Color.Red;
            textboxHelp.Text = @"Ось тут";
            MessageBox.Show("Введiть у текстове поле зверху ПIБ студента та натиснiть enter", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        // setting tool strip text box default when mouse enter
        private void textboxHelp_MouseEnter(object sender, EventArgs e)
        {
            textboxHelp.ForeColor = Color.Black;
            textboxHelp.Text = "";
        }

        // analyzing input key values
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
        
        // setting operation edit
        private void toolStrip_FILE_STUD_edit_Click(object sender, EventArgs e)
        {
            SetTextBoxHelp();
            CurrentOperation = Operations.edit;
        }
        
        // selecting operation delete
        private void toolStrip_FILE_STUD_delete_Click(object sender, EventArgs e)
        {
            SetTextBoxHelp();
            CurrentOperation = Operations.delete;
        }

        // selecting operation find
        private void toolStrip_FILE_STUD_find_Click(object sender, EventArgs e)
        {   var heightCounts = new int[Students.Count];
            for (int i = 0; i < Students.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < Students.Count; j++)
                {
                    if (Students[i].Height == Students[j].Height)
                    {
                        count++;
                    }
                }
                heightCounts[i] = count;
            }

            var weightCounts = new int[Students.Count];
            for (int i = 0; i < Students.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < Students.Count; j++)
                {
                    if (Students[i].Weight == Students[j].Weight)
                    {
                        count++;
                    }
                }
                weightCounts[i] = count;
            }

            var uniqueStudents = new List<Student>();
            for (int i = 0; i < Students.Count; i++)
            {
                if (heightCounts[i] == 1 && weightCounts[i] == 1)
                {
                    uniqueStudents.Add(Students[i]);
                }
            }

            if (uniqueStudents.Count == 0)
            {
                MessageBox.Show("Немає студентiв, що задовiльняють запиту", "Не знайдено", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            
            dataGridViewStudents.Rows.Clear();
            foreach (Student student in uniqueStudents)
            {
                AddToDataGrid(dataGridViewStudents, student);
            }
        }

        private void новийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFile_ToolStripMenuItem_Click(sender, e);
        }

        private void прочитатиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile_ToolStripMenuItem_Click(sender, e);
        }
        
        private void додатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip_FILE_add_Click(sender, e);
        }

        private void додатиНовогоСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudent_StripMenuItem_Click(sender, e);
        }

        private void редагуватиСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip_FILE_STUD_edit_Click(sender, e);
        }

        private void видалитиСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip_FILE_STUD_delete_Click(sender, e);
        }

        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip_FILE_STUD_find_Click(sender, e);
        }

        private void вихiдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSolution5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void labelVariantDescription_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }
        
    }
}

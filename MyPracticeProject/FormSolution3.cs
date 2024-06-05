using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyPracticeProject
{
    public partial class FormSolution3 : Form
    {
        private FormSolution3() => InitializeComponent();

        public struct Student
        {
            public string LastName;
            public string FirstName;
            public int Height;
            public DateTime BirthDate;
        }
        
        private void FormSolution3_Load(object sender, EventArgs e)
        {
            записатиУМасивToolStripMenuItem.Enabled = false;
            зберегтиФайлToolStripMenuItem.Enabled = false;

            dataGridView1.Columns.Add("Last name", "Last name");
            dataGridView1.Columns.Add("First name", "First name");
            dataGridView1.Columns.Add("Height", "Height");
            dataGridView1.Columns.Add("Date", "Date");
            
            dataGridViewSorted.Columns.Add("Last name", "Last name");
            dataGridViewSorted.Columns.Add("First name", "First name");
            dataGridViewSorted.Columns.Add("Height", "Height");
            dataGridViewSorted.Columns.Add("Date", "Date");
        }

        private Student? GenerateStudent()
        {
            Student student = new Student()
            {
                LastName = textBoxLastName.Text,
                FirstName = textBoxFirstName.Text,
                BirthDate = dateTimePicker1.Value
            };
            if (!int.TryParse(textBoxHeight.Text, out student.Height) && student.Height != 0) return null;
            return student;
        }
        private void AddToDataGrid(Student? student)
        {
            if (student == null) return;
            dataGridView1.Rows.Add(student.Value.LastName, student.Value.FirstName, student.Value.Height, student.Value.BirthDate);
        }

        private const string Filepath = "solution3_students.xml";

        private void AddToFile(Student? student)
        {
            if (student == null) return;
                XElement studentElement = new XElement("Student",
                    new XElement("LastName", student.Value.LastName),
                    new XElement("FirstName", student.Value.FirstName),
                    new XElement("Height", student.Value.Height),
                    new XElement("BirthDate"), student.Value.BirthDate.ToString("yy.MM.dd"));
                
                XDocument doc;
                if (File.Exists(Filepath))
                {
                    doc = XDocument.Load(Filepath);
                    doc.Root.Add(studentElement);
                }
                else
                {
                    doc = new XDocument(new XElement("Students", studentElement));
                }
                
                doc.Save(Filepath);
        }

        private void ReadFromFile()
        {
            if (File.Exists(Filepath))
            {
                XDocument doc = new XDocument(Filepath);
                XElement root = doc.Root;
                int index = 0;

                foreach (XElement studentELement in root.Elements("Student"))
                {
                    if (index >= maxIndex) break;
                    Student student = new Student
                    {
                        LastName = studentELement.Element("LastName")?.Value,
                        FirstName = studentELement.Element("FirstName")?.Value,
                        Height = int.Parse(studentELement.Element("Height")?.Value),
                        BirthDate = DateTime.Parse(studentELement.Element("BirthDate")?.Value)
                    };

                    studentArray[index] = student;
                    index++;
                }
            }
        }
        
        
        public static void Start()
        {
            FormSolution3 formSolution3 = new FormSolution3();
            formSolution3.Show();
        }

        private void FormSolution3_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e) => Close();

        // REGION text box input handler
        private void textBoxArraySize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            if (e.KeyChar == (int)Keys.Enter)   
            {
                if (!int.TryParse(textBoxArraySize.Text, out maxIndex))
                {
                    return;
                }

                if (maxIndex == 0)
                {
                    return;
                }
                e.Handled = false;
                textBoxArraySize.Enabled = false;
                записатиУМасивToolStripMenuItem.Enabled = true;
                studentArray = new Student[maxIndex];
                return;
            }

            if (char.IsDigit(e.KeyChar) && textBoxArraySize.Text.Length <= 2) return;
            if (e.KeyChar != (int)Keys.Enter)
            {
                e.Handled = true; 
            }
        } 

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            if (textBoxLastName.Text.Length > 16 || char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            if (textBoxFirstName.Text.Length > 12 || char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (textBoxHeight.Text.Length > 2)
            {
                e.Handled = true;
            }
        }
        
        // REGION working with array
        private int currentIndex = 0;
        private int maxIndex;
        private Student[] studentArray;
        
        // adding student to the array
        private void записатиУМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentIndex >= maxIndex)
            {
                MessageBox.Show(
                    @"Перевищено розмiр масиву!",
                    @"Помилка додавання студентiв",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Student? student = GenerateStudent();
            if (student != null)
            {
                studentArray[currentIndex] = (Student)student;
                MessageBox.Show(
                    @"Студент успiшно доданий до масиву",
                    @"Додавання у масив",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    @"Неможливо додати студента!",
                    @"Помилкка введення вхiдних даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            currentIndex++;
        }

        private void зберегтиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Student? student in studentArray)
            {
                if (student == null) return;
                AddToDataGrid(student);
                AddToFile(student);
            }
        }
        
        private void прочитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            foreach (Student? student in studentArray)
            {
                if (student != null)
                {
                    AddToFile(student);
                    AddToDataGrid(student);
                }
            }
        }
    }
}
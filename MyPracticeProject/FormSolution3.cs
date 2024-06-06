using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyPracticeProject {
    public partial class FormSolution3 : Form {
        private FormSolution3() => InitializeComponent();
        
        /** Path to database.xml file. */
        private const string FilePath = "solution3_students.xml";
        /** Student array used in saving data. */
        private Student[] _studentArray;
        /** Current index of student array. Used in iterating over students array. */
        private int _currentIndex = 0;
        /** Max size of students array. */
        private int _maxIndex;
        /** Student data type */
        public struct Student
        {
            public string LastName;
            public string FirstName;
            public int Height;
            public DateTime BirthDate;
        }
        
        /** function used to create new student. TextBox correct text value check is required */
        private Student GenerateStudent() => new Student() 
        {
            LastName = textBoxLastName.Text, 
            FirstName = textBoxFirstName.Text,
            Height = int.Parse(textBoxHeight.Text),
            BirthDate = dateTimePicker1.Value
        };
        
        
        ///
        /// REGION form
        /// 
        
        /** start form function */
        public static void Start()
        {
            FormSolution3 formSolution3 = new FormSolution3();
            formSolution3.Show();
        }
        
        private void FormSolution3_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();
        
        /** form load function */
        private void FormSolution3_Load(object sender, EventArgs e)
        {
            // setting form text
            Text = @"Облiк студентiв";
            labelTotalInfo.Text = @"Заданий одновимiрний масив з довiльною к-стью елементiв не менше 10, значення елементiв вводяться з клавiатури та записуються в файл. Виконати опрацювання масиву у вiдповiдностi з заданим варiантом завдання.\n27. Вiдомо про студентiв: прiзвище, iм'я, зрiст, дата народження: знайти студентiв по вiку студентiв з найбiльшим та найменшим ростом, середнiй зрiст по групi.";
            writeInArray_ToolStripMenuItem.Enabled = false;
            зберегтиФайлToolStripMenuItem.Enabled = false;
            // setting database fields
            dataGridView1.Columns.Add("Last name", "Last name");
            dataGridView1.Columns.Add("First name", "First name");
            dataGridView1.Columns.Add("Height", "Height");
            dataGridView1.Columns.Add("Date", "Date");
            // setting dataGridViewSorted fields
            dataGridViewSorted.Columns.Add("Last name", "Last name");
            dataGridViewSorted.Columns.Add("First name", "First name");
            dataGridViewSorted.Columns.Add("Height", "Height");
            dataGridViewSorted.Columns.Add("Date", "Date");
        }

        /** add student to DataGrid */
        private void AddToDataGrid(Student student) =>
            dataGridView1.Rows.Add(student.LastName, student.FirstName, student.Height, student.BirthDate.ToString("yy.MM.dd"));
        
        /** add student to file */
        private void AddToFile(Student student)
        {
            XElement studentElement = new XElement("Student", 
                new XElement("LastName", student.LastName),
                new XElement("FirstName", student.FirstName),
                new XElement("Height", student.Height),
                new XElement("BirthDate", student.BirthDate.ToString("yy.MM.dd")));

            //checking if the file exists and saving students
            XDocument doc;
            if (File.Exists(FilePath))
            {
                doc = XDocument.Load(FilePath);
                doc.Root?.Add(studentElement);
            }
            else
            {
                doc = new XDocument(new XElement("Students", studentElement));
            }
            doc.Save(FilePath);
        }
        
        ///
        /// REGION Analyzing text boxes
        ///
        
        private void textBoxArraySize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back) return;
            if (e.KeyChar == (int)Keys.Enter)
            {
                if (!int.TryParse(textBoxArraySize.Text, out _maxIndex)) return;
                if (_maxIndex == 0) return;
                
                e.Handled = false;
                textBoxArraySize.Enabled = false;
                writeInArray_ToolStripMenuItem.Enabled = true;
                _studentArray = new Student[_maxIndex];
                return;
            }
            if (char.IsDigit(e.KeyChar) && textBoxArraySize.Text.Length <= 2) return;
            if (e.KeyChar != (int)Keys.Enter) e.Handled = true;
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
        
        ///
        /// REGION Tool strip buttons
        ///
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e) => Close();
        
        // adding student to the array
        private void writeInArray_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_currentIndex >= _maxIndex)
            {
                MessageBox.Show(@"Перевищено розмiр масиву!", @"Помилка додавання даних у масив", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string message = "";
            if (textBoxLastName.Text.Length < 3) message += @"- Довжина прiзвища не повина бути менша нiж 3 символи." + '\n';
            if (textBoxFirstName.Text.Length < 3) message += @"- Довжина iменi не повина бути менша нiж 3 символи." + '\n';
            if (!int.TryParse(textBoxHeight.Text, out var height) || height < 90) message += @"- Невiрно введенi данi про зрiст." + '\n';
            if (message != "")
            {
                MessageBox.Show("Невiрно введенi данi про студента, а саме:" + '\n' + message);
                return;
            }

            Student student = GenerateStudent();
            _studentArray[_currentIndex] = student;
            _currentIndex++;
            зберегтиФайлToolStripMenuItem.Enabled = true;
            MessageBox.Show(@"Студент успiшно до масиву", @"Додавання студентiв", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxLastName.Text = textBoxFirstName.Text = textBoxHeight.Text = "";
        }

        private void зберегтиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearXmlFile();
            ClearDataGridView();
            foreach (var student in _studentArray)
            {
                if (string.IsNullOrEmpty(student.LastName)) continue;
                AddToDataGrid(student);
                AddToFile(student);
            }
            прочитатиЗФайлуToolStripMenuItem.Enabled = false;
            зберегтиФайлToolStripMenuItem.Enabled = false;
            MessageBox.Show(@"Данi успiшно збереженi", @"Збереження даних", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void прочитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show(@"Файл не знайдено", @"Помилка завантаження файлу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ReadFromFile();
            for (int i = 0; i < _currentIndex; i++)
            {
                Student student = _studentArray[i];
                _studentArray[i] = student;
            }
            прочитатиЗФайлуToolStripMenuItem.Enabled = false;
        }

        ///
        /// REGION working with files
        ///
        
        private void ClearXmlFile()
        {
            XElement rootElement = new XElement("Students");
            XDocument doc = new XDocument(rootElement);
            doc.Save(FilePath);
        }
        private void ClearDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridViewSorted.Rows.Clear(); // Если у вас есть второй DataGridView, также очистите его
            MessageBox.Show(
                @"Дані в DataGridView було успішно очищено",
                @"Очищення DataGridView",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void ReadFromFile()
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show(@"Файл не найден", @"Ошибка загрузки файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            XDocument doc = XDocument.Load(FilePath);
            XElement root = doc.Root;
            
            if (_studentArray == null || _studentArray.Length < _maxIndex)
            {
                _studentArray = new Student[_maxIndex];
            }
            _currentIndex = 0;

            foreach (XElement studentElement in root.Elements("Student"))
            {
                if (_currentIndex >= _maxIndex)
                {
                    MessageBox.Show(@"Перевищено розмiр масиву!", @"Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                try
                {
                    Student student = new Student
                    {
                        LastName = studentElement.Element("LastName")?.Value ?? string.Empty,
                        FirstName = studentElement.Element("FirstName")?.Value ?? string.Empty,
                        Height = int.Parse(studentElement.Element("Height")?.Value ?? "0"),
                        BirthDate = DateTime.Parse(studentElement.Element("BirthDate")?.Value ?? DateTime.MinValue.ToString())
                    };
                    _studentArray[_currentIndex] = student;
                    AddToDataGrid(student);
                    _currentIndex++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Помилка зчитування файлу: {ex.Message}", @"Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            прочитатиЗФайлуToolStripMenuItem.Enabled = false;
            зберегтиФайлToolStripMenuItem.Enabled = false;
        }

    }
}

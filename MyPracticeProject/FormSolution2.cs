using System;
using System.Data;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormSolution2 : Form
    {
        private FormSolution2()
        {
            InitializeComponent();
        }

        public static void Start()
        {
            FormSolution2 formSolution1 = new FormSolution2();
            formSolution1.Show();
        }

        // index of digits after comma
        private static int commaIndex = 4;

        // epsilon used for accuracy
        private static double E = 0.0001;

        private void FormSolution2_Load(object sender, EventArgs e)
        {
            // setting values by default
            textBoxE.Text = @"0,0001";
            textBoxDigits.Text = @"4";
            textBoxSumma.Text = "";

            // setting text info
            // LabelSolutionInfo.Text = @"Табулювання функцiї";
            // labelSolutionDescription.Text =
            // "1. Скласти алгоритм програми.\n2. Виконати обчислення згiдно варiанту\n3. Результат обчислень вивести на екран i у текстовий файл\n4. Данi ввести та перевiрити на коректнiсть";
            labelVariantDescription.Text = "Обчислити суму ряду з заданою точністю ε = 0.0001";
            labelVariantDescription2.Text = "Елементи ряду та їх порядкові номери вивести на екран і у текстовий файл";

            textBoxDigits.BorderStyle = textBoxE.BorderStyle = textBoxSumma.BorderStyle = BorderStyle.None;
            LabelSolutionInfo.ForeColor = Data.Pal.Green;
        }

        // allows you to input number values only in the textBox
        private static bool InputNumbers(TextBox tbx, KeyPressEventArgs e, int commaIndex)
        {
            if (e.KeyChar == (int)Keys.Back) return false;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',')) return true;
            var text = tbx.Text;
            switch (e.KeyChar)
            {
                case ',' when text.Length == 0:
                case ',' when text.Contains(","):
                case '-' when text.Length != 0:
                case '-' when text.Contains("-"):
                    return true;
            }

            var i = text.IndexOf(',');
            return i != -1 && text.Length - i > commaIndex;
        }

        private void textBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (textBoxDigits.Text == "") return;

            char first = textBoxDigits.Text[0];
            int key = int.Parse(e.KeyChar.ToString());
            if (first != '1' ||
                key > 5 ||
                textBoxDigits.Text.Length >= 2)
            {
                e.Handled = true;
            }
        }

        private void textBoxE_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = InputNumbers(textBoxE, e, commaIndex);


        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking for data input error
            if (!double.TryParse(textBoxE.Text, out E) ||
                !int.TryParse(textBoxDigits.Text, out commaIndex) ||
                E == 0)
    {
                MessageBox.Show(
                    @"Missing function parameters" + '\n' + @"Setting e as 0,0001 by default",
                    @"Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                E = 0.0001;
                textBoxE.Text = @"0,0001";
                if (textBoxDigits.Text == "")
                {
                    textBoxDigits.Text = @"4";
                    commaIndex = 4;
                }
    }

            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("i");
            dataTable.Columns.Add("Value");

            //save menu
            bool saveOption = false;
            if (Data.hasAcess == true)
            {
                var saveDialog = MessageBox.Show("Ви бажаєте зберегти данi у файл?", "Збереження даних",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                saveOption = saveDialog == DialogResult.Yes;
            }
   
            // calculating series values
            int i = 1;
            double summa = 0;
            double element = Series(i);
            while (Abs(element) >= E)
            {
                summa += element;

                // pushing y(i) result
                if (saveOption)
                {
                    dataTable.Rows.Add(i, element);
                }

                listBoxValues.Items.Add($@"y({i}) = {Math.Round(element, commaIndex)}");
                i++;
                element = Series(i);
            }

            // setting sum result
            textBoxSumma.Text = $@"{Math.Round(summa, commaIndex)}";
            dataSet.Tables.Add(dataTable);
            dataSet.WriteXml("solution2_series.xml");
        }

        private static double Abs(double x) => /* returns: */ x > 0 ? x : -x;
        private static double Series(double i) => /* returns: */ 1 / (i * (i + 2));


        private void прочитатиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double summa = 0;
            listBoxValues.Items.Clear();
            DataSet dataSet = new DataSet();
            try
            {
                dataSet.ReadXml("solution2_series.xml");
                if (dataSet.Tables.Count > 0)
                {
                    DataTable dataTable = dataSet.Tables[0];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int i = Convert.ToInt32(row["i"]);
                        double value = Convert.ToDouble(row["Value"]);
                        listBoxValues.Items.Add($@"y({i}) = {Math.Round(value, commaIndex)}");
                        summa += value;
                    }
                }
                else
                {
                    MessageBox.Show(
                        @"No data found in the file.",
                        @"Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show(
                    @"An error occurred while loading data",
                    @"Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            textBoxSumma.Text = $@"{summa}";
        }

        private void вихiдToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        private void FormSolution2_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();

        private void очищенняЕкрануToolStripMenuItem_Click(object sender, EventArgs e) 
        { 
            listBoxValues.Items.Clear();
            textBoxSumma.Text = "";
        }

        private void textBoxSumma_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;
    }
}
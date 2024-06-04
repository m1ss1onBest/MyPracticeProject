using System;
using System.Data;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormSolution2 : Form
    {
        public FormSolution2()
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
        }
        
        // allows you to input number values only in the textBox
        private static bool InputNumbers(TextBox tbx, KeyPressEventArgs e, int commaIndex) {
            if (e.KeyChar == (int)Keys.Back) return false;
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',')) return true;
            var text = tbx.Text;
            switch (e.KeyChar) {
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
        
        private void textBoxE_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = InputNumbers(textBoxE, e, commaIndex);


        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checking for data input error
            if (!double.TryParse(textBoxE.Text, out E))
            {
                MessageBox.Show(
                    @"Missing function parameters" + '\n' + @"Setting e as 0,0001 by default", 
                    @"Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                E = 0.0001;
                textBoxE.Text = @"0,0001";
                if (textBoxDigits.Text == "") textBoxDigits.Text = @"4";
            }

            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("i");
            dataTable.Columns.Add("Value");
            
            // calculating series values
            int i = 1;
            double summa = 0;
            double element = 1;
            while (Abs(element) > E)
            {
                element = Series(i);
                summa += element;
                
                // pushing y(i) result
                if (checkBoxSaveFile.Enabled)
                {
                    dataTable.Rows.Add(i, element);
                }
                listBoxValues.Items.Add($@"y({i}) = {Math.Round(element, commaIndex)}");
                i++;
            }
            // setting sum result
        }
        
        private static double Abs(double x) => /* returns: */ x > 0 ? x : -x;
        private static double Series(double i) => /* returns: */ 1 / (i * (i + 1));


        private void прочитатиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double summa = 0;
            listBoxValues.Items.Clear();
            DataSet dataSet = new DataSet();
            try
            {
                dataSet.ReadXml("series_calculate.xml");
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
    }
}
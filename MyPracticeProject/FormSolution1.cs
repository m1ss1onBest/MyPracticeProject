using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormSolution1 : Form
    {
        //max value of x
        private double maxValue;
        //the number of pi
        private const double pi = 3.141592653589793;
        //converting 1 degree to rads
        private const double step = pi / 180;
        //digits after comma
        private int digits_AFTER_COMMA = 2;
        private FormSolution1() => InitializeComponent();
        
        public static void Start()
        {
            FormSolution1 formSolution1 = new FormSolution1();
            formSolution1.Show();
        }

        private void FormSolution1_Load(object sender, EventArgs e)
        {
            Text = @"Задача 1";
            labelAngle.Text = @"Кут " + "\u03B7" + "\u00b0";
            labelAngle.ForeColor = Data.Pal.OrangeDark;
            LabelSolutionInfo.ForeColor = Data.Pal.OrangeDark;
            textBoxAngle.BorderStyle = BorderStyle.None;
            textBoxAngle.Text = "";
            labelValue.Text = @"Значення";
            labelGraph.Text = @"Графік f(x) = sin(x)";
            labelDigits.Text = @"Точність";
            labelDigits.ForeColor = Data.Pal.OrangeDark;
            textBoxDigits.BorderStyle = BorderStyle.None;
            textBoxDigits.Text = @"2";
            
            //setting solution info
            // LabelSolutionInfo.ForeColor = Data.Pal.OrangeDark;
            LabelSolutionInfo.Text = @"Табулювання Функцiї";
            labelSolutionDescription.Text = @"Обчислити та вивести на екран всі значення sin(a) на проміжку від 0 до " + "\u03B7" + @" з інтервалом 1" + "\u00b0.";
            // \u03B7
        }

        private void textBoxAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar) || textBoxAngle.Text.Length > 2)
            {
                e.Handled = true;
            }
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
        
        static double Abs(double x) => x > 0 ? x : -x;
        private static double Sin(double x, double e = 0.00000001) {
            // Setting x to [-π, π] interval
            x %= 2 * pi;
            if (x > pi) x -= 2 * pi;
            if (x < -pi) x += 2 * pi;   
    
            // Taylor series
            double val = x;
            double result = val;
            int n = 1;
            while (Abs(val) >= e) {
                // Calculate the next term in the series
                val *= -x * x / (2 * n * (2 * n + 1));
                result += val;
                n++;
            }
            return result;
        }
        
        //setting all sin(x) for [0; μ] with the step of 1°
        private void Calculations() {
            chartGraph.Series[0].Points.Clear();
            if (!double.TryParse(textBoxAngle.Text, out maxValue) ||
                !int.TryParse(textBoxDigits.Text, out digits_AFTER_COMMA)) {
                return;
            }
            listBoxValues.Items.Clear();

            double a = 0;
            double b = 0;
            // Convert maxValue from degrees to radians
            double maxValueInRadians = maxValue * step;
            for (double i = 0; i <= maxValueInRadians; i += step) {
                a = Math.Round(i * 180 / pi, digits_AFTER_COMMA);
                b = Math.Round(Sin(i), digits_AFTER_COMMA);
                chartGraph.Series[0].Points.AddXY(a, b);
                listBoxValues.Items.Add($@"f({Math.Round(a, 0)}°) = {b}");
            }
        }

        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            очищенняЕкрануToolStripMenuItem_Click_1(sender, e);
            Calculations();
            pictureBoxKostyl.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\orange-kostyl1.png");
        }

        private void очищенняЕкрануToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chartGraph.Series[0].Points.Clear();
            listBoxValues.Items.Clear();
            pictureBoxKostyl.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\orange-kostyl2.png");
        }
        
        private void FormSolution1_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();
        private void вихiдToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        
        private void FormSolution1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.Location);
            }
        }

        private void обчислитиToolStripMenuItem1_Click(object sender, EventArgs e) =>
            обчислитиToolStripMenuItem_Click(sender, e);
        


        private void вихiдToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            вихiдToolStripMenuItem_Click(sender, e);
        }
        
    }
}
using System;
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
            Text = @"Задача1";
            // ReSharper disable once LocalizableElement
            labelAngle.Text = @"Кут μ" + "\u00b0";
            labelAngle.ForeColor = Data.Pal.OrangeDark;
            textBoxAngle.BorderStyle = BorderStyle.None;
            textBoxAngle.Text = "";

            labelDigits.Text = @"Знак. після ','";
            labelDigits.ForeColor = Data.Pal.OrangeDark;
            textBoxDigits.BorderStyle = BorderStyle.None;
            textBoxDigits.Text = "2";
            
            //setting error labels
            labelInfoDigits.ForeColor = lableInfoAngle.ForeColor = Data.Pal.ErrorColor;
            labelInfoDigits.Visible = lableInfoAngle.Visible = false;
        }

        private void textBoxAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back) return;
            if (!char.IsDigit(e.KeyChar) || textBoxDigits.Text.Length >= 15)
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
                val *= -x * x / ((2 * n) * (2 * n + 1));
                result += val;
                n++;
            }
            return result;
        }

    }
}
using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormPasswordGenerator : Form
    {
        public static FormPasswordGenerator formPasswordGenerator;
        public FormPasswordGenerator() => InitializeComponent();

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "";
                return;
            }
            textBox2.Text = Data.HashPassword(textBox1.Text);
        }

        public static void Start()
        {
            if (formPasswordGenerator == null)
            {
                formPasswordGenerator = new FormPasswordGenerator();
                formPasswordGenerator.Show();   
            }
        }

        private void FormPasswordGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPasswordGenerator = null;
        }
    }
}
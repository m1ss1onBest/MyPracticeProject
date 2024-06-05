using System;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormSolution3 : Form
    {
        public FormSolution3()
        {
            InitializeComponent();
        }
        
        public static void Start()
        {
            FormSolution3 formSolution3 = new FormSolution3();
            formSolution3.Show();
        }

        private void FormSolution3_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();
        private void вихiдToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        
    }
}
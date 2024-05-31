using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormManager : Form
    {
        private FormManager() => InitializeComponent();

        private void FormManager_Load(object sender, EventArgs e)
        {
            Text = @"Диспечер";
        }
        public static void Start()
        {
            FormManager formManager = new FormManager();
            formManager.Show();
        }
        private void FormManager_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

    }
}
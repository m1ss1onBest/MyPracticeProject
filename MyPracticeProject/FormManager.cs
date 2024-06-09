using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyPracticeProject
{
    public partial class FormManager : Form
    {
        public FormManager() => InitializeComponent();

        private void FormManager_Load(object sender, EventArgs e)
        {
            Text = @"Диспечер";
            labelName1.ForeColor = Data.Pal.OrangeDark;
        }
        public static void Start()
        {
            FormManager formManager = new FormManager();
            formManager.Show();
        }
        private void FormManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void згенеруватиПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Data.hasAcess)
            {
                Data.ShowAccessRequired();
                return;
            }
            FormPasswordGenerator.Start();
        }

        private void вихiдToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Ви бажаєте вийти?", @"Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        
        // solutions
        private void задача1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormSolution1.Start();
        }
        
        private void задача2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormSolution2.Start();
        }

        private void задача3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormSolution3.Start();
        }
        
        private void задача4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormSolution4.Start();
        }

        private void задача5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormSolution5.Start();
        }
    }
}
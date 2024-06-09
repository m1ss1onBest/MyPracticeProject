using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormSolution5 : Form
    {
        private struct Student
        {
            public string FullName { set; get; }
            public UInt16 Age { set; get; }
            public UInt16 Height { set; get; } 
            public UInt16 Weight { set; get; }

            public Student(string fullName, UInt16 age, UInt16 height, UInt16 weight)
            {
                FullName = fullName;
                Age = age;
                Height = height;
                Weight = weight;
            }
        }

        private List<Student> Students { set; get; }
        
        //
        // REGION form initialization
        //
        public FormSolution5()
        {
            InitializeComponent();
        }

        public static void Start()
        {
            var formSolution5 = new FormSolution5();
            formSolution5.Show();
        }

        private void FormSolution5_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();

        private void FormSolution5_Load(object sender, EventArgs e)
        {
            
        }
        
        //
        // REGION File
        //

        
        private void CreateFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LoadFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        //
        // REGION Student
        //
        
        private void NewStudent_StripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

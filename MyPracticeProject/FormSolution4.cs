using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormSolution4 : Form
    {
        private int[,] Matrix;
        private FormSolution4() => InitializeComponent();
        private void вихiдToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        public static void Start()
        {
            FormSolution4 formSolution4 = new FormSolution4();
            formSolution4.Show();
        }
        
        private void FormSolution4_FormClosing(object sender, FormClosingEventArgs e) => FormManager.Start();

        private void обчислитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Введiть у текстове поле розмiр матрицi вiд 1 до 16 та натиснiть enter",
                @"створення матрицi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            toolStripTextBox1.Enabled = true;
        }

        private void FormSolution4_Load(object sender, EventArgs e)
        {
            toolStripTextBox1.Enabled = false;
            dataGridView1.AllowUserToAddRows = dataGridView1.AllowUserToDeleteRows = false;
        }

        private void обчислитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataGridView1.RowCount;
                double sumMainDiagonal = 0;
                double sumSecondatyDiagonal = 0;

                for (int i = 0; i < n; i++)
                {
                    var mainValue = dataGridView1.Rows[i].Cells[i].Value;
                    double mainDiagonalValue = Convert.ToDouble(mainValue);
                    sumMainDiagonal += Math.Pow(mainDiagonalValue, 2);

                    var secondValue = dataGridView1.Rows[i].Cells[n - i - 1].Value;
                    double secondatyDiagonalValue = Convert.ToDouble(secondValue);
                    sumSecondatyDiagonal += Math.Pow(secondatyDiagonalValue, 2);
                }

                MessageBox.Show($"Сума квадратiв дiагоналей матрицi {sumMainDiagonal + sumSecondatyDiagonal}",
                    "Обчислення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Невiрно введенi данi", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                return;
            }

            if (e.KeyChar == (int)Keys.Enter)
            {
                if (!int.TryParse(toolStripTextBox1.Text, out var len))
                {
                    return;
                }

                if (len < 2 || len > 16)
                {
                    MessageBox.Show("Heвiрно введенi данi");
                    return;
                }

                Matrix = new int[len, len];
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.ColumnCount = len;
                dataGridView1.RowCount = len;
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
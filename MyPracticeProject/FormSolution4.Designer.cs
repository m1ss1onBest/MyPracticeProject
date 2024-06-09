using System.ComponentModel;

namespace MyPracticeProject
{
    partial class FormSolution4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolution4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.програмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обчислитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обчислитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихiдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.labelTotalInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(516, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.програмаToolStripMenuItem, this.toolStripTextBox1 });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // програмаToolStripMenuItem
            // 
            this.програмаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.обчислитиToolStripMenuItem, this.обчислитиToolStripMenuItem1, this.вихiдToolStripMenuItem });
            this.програмаToolStripMenuItem.Name = "програмаToolStripMenuItem";
            this.програмаToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.програмаToolStripMenuItem.Text = "Програма";
            // 
            // обчислитиToolStripMenuItem
            // 
            this.обчислитиToolStripMenuItem.Name = "обчислитиToolStripMenuItem";
            this.обчислитиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.обчислитиToolStripMenuItem.Text = "Створити нову матрицю";
            this.обчислитиToolStripMenuItem.Click += new System.EventHandler(this.обчислитиToolStripMenuItem_Click);
            // 
            // обчислитиToolStripMenuItem1
            // 
            this.обчислитиToolStripMenuItem1.Name = "обчислитиToolStripMenuItem1";
            this.обчислитиToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.обчислитиToolStripMenuItem1.Text = "Обчислити";
            this.обчислитиToolStripMenuItem1.Click += new System.EventHandler(this.обчислитиToolStripMenuItem1_Click);
            // 
            // вихiдToolStripMenuItem
            // 
            this.вихiдToolStripMenuItem.Name = "вихiдToolStripMenuItem";
            this.вихiдToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вихiдToolStripMenuItem.Text = "Вихiд";
            this.вихiдToolStripMenuItem.Click += new System.EventHandler(this.вихiдToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // labelTotalInfo
            // 
            this.labelTotalInfo.Font = new System.Drawing.Font("e-Ukraine Head", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalInfo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelTotalInfo.Location = new System.Drawing.Point(83, 59);
            this.labelTotalInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTotalInfo.Name = "labelTotalInfo";
            this.labelTotalInfo.Size = new System.Drawing.Size(516, 108);
            this.labelTotalInfo.TabIndex = 57;
            this.labelTotalInfo.Text = "Сформувати двовимiрний масив та виконати обчислення згiдно варiанту:\r\n- обчислити" + " суму квадратiв дiагональних елементiв матрицi.\r\n";
            // 
            // FormSolution4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(707, 677);
            this.Controls.Add(this.labelTotalInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSolution4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завдання 5 - Матриця";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSolution4_FormClosing);
            this.Load += new System.EventHandler(this.FormSolution4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTotalInfo;

        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem програмаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обчислитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обчислитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вихiдToolStripMenuItem;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}
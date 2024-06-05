using System.ComponentModel;

namespace MyPracticeProject
{
    partial class FormSolution1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolution1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцiїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обчислитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очищенняЕкрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихiдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxDigits = new System.Windows.Forms.TextBox();
            this.labelDigits = new System.Windows.Forms.Label();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelGraph = new System.Windows.Forms.Label();
            this.LabelSolutionInfo = new System.Windows.Forms.Label();
            this.labelSolutionDescription = new System.Windows.Forms.Label();
            this.pictureBoxKostyl = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вВАААААУКПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обчислитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиЕкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихiдToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKostyl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.операцiїToolStripMenuItem, this.вихiдToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // операцiїToolStripMenuItem
            // 
            this.операцiїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.обчислитиToolStripMenuItem, this.очищенняЕкрануToolStripMenuItem });
            this.операцiїToolStripMenuItem.Name = "операцiїToolStripMenuItem";
            this.операцiїToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.операцiїToolStripMenuItem.Text = "Операцiї";
            // 
            // обчислитиToolStripMenuItem
            // 
            this.обчислитиToolStripMenuItem.Name = "обчислитиToolStripMenuItem";
            this.обчислитиToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.обчислитиToolStripMenuItem.Text = "Обчислити";
            this.обчислитиToolStripMenuItem.Click += new System.EventHandler(this.обчислитиToolStripMenuItem_Click);
            // 
            // очищенняЕкрануToolStripMenuItem
            // 
            this.очищенняЕкрануToolStripMenuItem.Name = "очищенняЕкрануToolStripMenuItem";
            this.очищенняЕкрануToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.очищенняЕкрануToolStripMenuItem.Text = "Очищення екрану";
            this.очищенняЕкрануToolStripMenuItem.Click += new System.EventHandler(this.очищенняЕкрануToolStripMenuItem_Click_1);
            // 
            // вихiдToolStripMenuItem
            // 
            this.вихiдToolStripMenuItem.Name = "вихiдToolStripMenuItem";
            this.вихiдToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вихiдToolStripMenuItem.Text = "Вихiд";
            this.вихiдToolStripMenuItem.Click += new System.EventHandler(this.вихiдToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 212);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 42);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAngle.Font = new System.Drawing.Font("e-Ukraine Head", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAngle.Location = new System.Drawing.Point(112, 181);
            this.textBoxAngle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(400, 33);
            this.textBoxAngle.TabIndex = 29;
            this.textBoxAngle.Text = "textBoxAngle";
            this.textBoxAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAngle_KeyPress);
            // 
            // labelAngle
            // 
            this.labelAngle.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAngle.Location = new System.Drawing.Point(112, 146);
            this.labelAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(401, 32);
            this.labelAngle.TabIndex = 27;
            this.labelAngle.Text = "labelAngle";
            this.labelAngle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(112, 288);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 21);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxDigits
            // 
            this.textBoxDigits.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDigits.Font = new System.Drawing.Font("e-Ukraine Head", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDigits.Location = new System.Drawing.Point(112, 257);
            this.textBoxDigits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDigits.Name = "textBoxDigits";
            this.textBoxDigits.Size = new System.Drawing.Size(400, 33);
            this.textBoxDigits.TabIndex = 33;
            this.textBoxDigits.Text = "textBoxDigits";
            this.textBoxDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDigits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigits_KeyPress);
            // 
            // labelDigits
            // 
            this.labelDigits.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDigits.Location = new System.Drawing.Point(112, 222);
            this.labelDigits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDigits.Name = "labelDigits";
            this.labelDigits.Size = new System.Drawing.Size(401, 32);
            this.labelDigits.TabIndex = 31;
            this.labelDigits.Text = "labelDigits";
            this.labelDigits.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // listBoxValues
            // 
            this.listBoxValues.BackColor = System.Drawing.Color.LightGray;
            this.listBoxValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxValues.Font = new System.Drawing.Font("e-Ukraine Head", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 23;
            this.listBoxValues.Location = new System.Drawing.Point(111, 347);
            this.listBoxValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(401, 184);
            this.listBoxValues.TabIndex = 35;
            // 
            // labelValue
            // 
            this.labelValue.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.Location = new System.Drawing.Point(112, 312);
            this.labelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(389, 32);
            this.labelValue.TabIndex = 36;
            this.labelValue.Text = "labelValue";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chartGraph
            // 
            this.chartGraph.BackColor = System.Drawing.Color.LightGray;
            this.chartGraph.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartGraph.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartGraph.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea1);
            this.chartGraph.Location = new System.Drawing.Point(559, 252);
            this.chartGraph.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartGraph.Name = "chartGraph";
            this.chartGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Name = "Series1";
            this.chartGraph.Series.Add(series1);
            this.chartGraph.Size = new System.Drawing.Size(390, 273);
            this.chartGraph.TabIndex = 37;
            // 
            // labelGraph
            // 
            this.labelGraph.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraph.Location = new System.Drawing.Point(559, 208);
            this.labelGraph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGraph.Name = "labelGraph";
            this.labelGraph.Size = new System.Drawing.Size(389, 41);
            this.labelGraph.TabIndex = 38;
            this.labelGraph.Text = "labelGraph";
            this.labelGraph.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LabelSolutionInfo
            // 
            this.LabelSolutionInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabelSolutionInfo.Font = new System.Drawing.Font("e-Ukraine Head", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSolutionInfo.Location = new System.Drawing.Point(85, 53);
            this.LabelSolutionInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSolutionInfo.Name = "LabelSolutionInfo";
            this.LabelSolutionInfo.Size = new System.Drawing.Size(467, 78);
            this.LabelSolutionInfo.TabIndex = 39;
            this.LabelSolutionInfo.Text = "LabelSolutionInfo";
            this.LabelSolutionInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSolutionDescription
            // 
            this.labelSolutionDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelSolutionDescription.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSolutionDescription.Location = new System.Drawing.Point(560, 33);
            this.labelSolutionDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSolutionDescription.Name = "labelSolutionDescription";
            this.labelSolutionDescription.Size = new System.Drawing.Size(389, 175);
            this.labelSolutionDescription.TabIndex = 40;
            this.labelSolutionDescription.Text = "labelSolutionDescription";
            this.labelSolutionDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxKostyl
            // 
            this.pictureBoxKostyl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxKostyl.BackgroundImage")));
            this.pictureBoxKostyl.Location = new System.Drawing.Point(649, 513);
            this.pictureBoxKostyl.Name = "pictureBoxKostyl";
            this.pictureBoxKostyl.Size = new System.Drawing.Size(274, 41);
            this.pictureBoxKostyl.TabIndex = 41;
            this.pictureBoxKostyl.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.вВАААААУКПToolStripMenuItem, this.вихiдToolStripMenuItem1 });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // вВАААААУКПToolStripMenuItem
            // 
            this.вВАААААУКПToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.обчислитиToolStripMenuItem1, this.очиститиЕкранToolStripMenuItem });
            this.вВАААААУКПToolStripMenuItem.Name = "вВАААААУКПToolStripMenuItem";
            this.вВАААААУКПToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.вВАААААУКПToolStripMenuItem.Text = "Операцiї";
            // 
            // обчислитиToolStripMenuItem1
            // 
            this.обчислитиToolStripMenuItem1.Name = "обчислитиToolStripMenuItem1";
            this.обчислитиToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.обчислитиToolStripMenuItem1.Text = "Обчислити";
            this.обчислитиToolStripMenuItem1.Click += new System.EventHandler(this.обчислитиToolStripMenuItem1_Click);
            // 
            // очиститиЕкранToolStripMenuItem
            // 
            this.очиститиЕкранToolStripMenuItem.Name = "очиститиЕкранToolStripMenuItem";
            this.очиститиЕкранToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.очиститиЕкранToolStripMenuItem.Text = "Очистити екран";
            this.очиститиЕкранToolStripMenuItem.Click += new System.EventHandler(this.очиститиЕкранToolStripMenuItem_Click);
            // 
            // вихiдToolStripMenuItem1
            // 
            this.вихiдToolStripMenuItem1.Name = "вихiдToolStripMenuItem1";
            this.вихiдToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.вихiдToolStripMenuItem1.Text = "Вихiд";
            this.вихiдToolStripMenuItem1.Click += new System.EventHandler(this.вихiдToolStripMenuItem1_Click);
            // 
            // FormSolution1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 593);
            this.Controls.Add(this.pictureBoxKostyl);
            this.Controls.Add(this.labelSolutionDescription);
            this.Controls.Add(this.LabelSolutionInfo);
            this.Controls.Add(this.labelGraph);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.listBoxValues);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxDigits);
            this.Controls.Add(this.labelDigits);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.labelAngle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("e-Ukraine Head", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormSolution1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSolution1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSolution1_FormClosing);
            this.Load += new System.EventHandler(this.FormSolution1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSolution1_MouseDown_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKostyl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem вихiдToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem вВАААААУКПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обчислитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem очиститиЕкранToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.PictureBox pictureBoxKostyl;

        private System.Windows.Forms.Label LabelSolutionInfo;

        private System.Windows.Forms.Label labelSolutionDescription;

        private System.Windows.Forms.Label labelGraph;

        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxDigits;
        private System.Windows.Forms.Label labelDigits;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label labelAngle;

        private System.Windows.Forms.ToolStripMenuItem вихiдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцiїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обчислитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очищенняЕкрануToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}
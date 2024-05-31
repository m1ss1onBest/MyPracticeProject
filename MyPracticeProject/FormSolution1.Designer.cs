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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolution1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихiдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцiїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обчислитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очищенняЕкрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lableInfoAngle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.labelInfoDigits = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxDigits = new System.Windows.Forms.TextBox();
            this.labelDigits = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelGraph = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.файлToolStripMenuItem, this.операцiїToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.прочитатиToolStripMenuItem, this.зберегтиToolStripMenuItem, this.вихiдToolStripMenuItem });
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // прочитатиToolStripMenuItem
            // 
            this.прочитатиToolStripMenuItem.Name = "прочитатиToolStripMenuItem";
            this.прочитатиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.прочитатиToolStripMenuItem.Text = "Прочитати";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // вихiдToolStripMenuItem
            // 
            this.вихiдToolStripMenuItem.Name = "вихiдToolStripMenuItem";
            this.вихiдToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.вихiдToolStripMenuItem.Text = "Вихiд";
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
            // 
            // очищенняЕкрануToolStripMenuItem
            // 
            this.очищенняЕкрануToolStripMenuItem.Name = "очищенняЕкрануToolStripMenuItem";
            this.очищенняЕкрануToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.очищенняЕкрануToolStripMenuItem.Text = "Очищення екрану";
            // 
            // lableInfoAngle
            // 
            this.lableInfoAngle.BackColor = System.Drawing.Color.Transparent;
            this.lableInfoAngle.Font = new System.Drawing.Font("e-Ukraine Head", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableInfoAngle.ForeColor = System.Drawing.Color.Gold;
            this.lableInfoAngle.Location = new System.Drawing.Point(216, 104);
            this.lableInfoAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableInfoAngle.Name = "lableInfoAngle";
            this.lableInfoAngle.Size = new System.Drawing.Size(344, 46);
            this.lableInfoAngle.TabIndex = 28;
            this.lableInfoAngle.Text = "lableInfoAngle";
            this.lableInfoAngle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 42);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Font = new System.Drawing.Font("e-Ukraine Head", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAngle.Location = new System.Drawing.Point(216, 68);
            this.textBoxAngle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(343, 33);
            this.textBoxAngle.TabIndex = 29;
            this.textBoxAngle.Text = "textBoxAngle";
            this.textBoxAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAngle_KeyPress);
            // 
            // labelAngle
            // 
            this.labelAngle.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAngle.Location = new System.Drawing.Point(216, 33);
            this.labelAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(344, 32);
            this.labelAngle.TabIndex = 27;
            this.labelAngle.Text = "labelAngle";
            this.labelAngle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelInfoDigits
            // 
            this.labelInfoDigits.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoDigits.Font = new System.Drawing.Font("e-Ukraine Head", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoDigits.ForeColor = System.Drawing.Color.Gold;
            this.labelInfoDigits.Location = new System.Drawing.Point(216, 202);
            this.labelInfoDigits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoDigits.Name = "labelInfoDigits";
            this.labelInfoDigits.Size = new System.Drawing.Size(344, 46);
            this.labelInfoDigits.TabIndex = 32;
            this.labelInfoDigits.Text = "labelInfoDigits";
            this.labelInfoDigits.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 197);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 42);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxDigits
            // 
            this.textBoxDigits.Font = new System.Drawing.Font("e-Ukraine Head", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDigits.Location = new System.Drawing.Point(216, 166);
            this.textBoxDigits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDigits.Name = "textBoxDigits";
            this.textBoxDigits.Size = new System.Drawing.Size(343, 33);
            this.textBoxDigits.TabIndex = 33;
            this.textBoxDigits.Text = "textBoxDigits";
            this.textBoxDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDigits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigits_KeyPress);
            // 
            // labelDigits
            // 
            this.labelDigits.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDigits.Location = new System.Drawing.Point(216, 131);
            this.labelDigits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDigits.Name = "labelDigits";
            this.labelDigits.Size = new System.Drawing.Size(344, 32);
            this.labelDigits.TabIndex = 31;
            this.labelDigits.Text = "labelDigits";
            this.labelDigits.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("e-Ukraine Head", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(568, 68);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 138);
            this.listBox1.TabIndex = 35;
            // 
            // labelValue
            // 
            this.labelValue.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.Location = new System.Drawing.Point(568, 33);
            this.labelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(389, 32);
            this.labelValue.TabIndex = 36;
            this.labelValue.Text = "labelValue";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(568, 258);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(390, 273);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // labelGraph
            // 
            this.labelGraph.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGraph.Location = new System.Drawing.Point(568, 223);
            this.labelGraph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGraph.Name = "labelGraph";
            this.labelGraph.Size = new System.Drawing.Size(389, 32);
            this.labelGraph.TabIndex = 38;
            this.labelGraph.Text = "labelGraph";
            this.labelGraph.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormSolution1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 571);
            this.Controls.Add(this.labelGraph);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelInfoDigits);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxDigits);
            this.Controls.Add(this.labelDigits);
            this.Controls.Add(this.lableInfoAngle);
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
            this.Text = "FormSolution1";
            this.Load += new System.EventHandler(this.FormSolution1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelGraph;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private System.Windows.Forms.Label labelInfoDigits;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxDigits;
        private System.Windows.Forms.Label labelDigits;

        private System.Windows.Forms.Label lableInfoAngle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label labelAngle;

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихiдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцiїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обчислитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очищенняЕкрануToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}
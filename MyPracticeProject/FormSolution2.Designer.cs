using System.ComponentModel;

namespace MyPracticeProject
{
    partial class FormSolution2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSolution2));
            this.LabelSolutionInfo = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxDigits = new System.Windows.Forms.TextBox();
            this.labelDigits = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцiїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обчислитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очищенняЕкрануToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихiдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVariantDescription = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBoxSumma = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelVariantDescription2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSolutionInfo
            // 
            this.LabelSolutionInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabelSolutionInfo.Font = new System.Drawing.Font("e-Ukraine Head", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSolutionInfo.Location = new System.Drawing.Point(38, 42);
            this.LabelSolutionInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSolutionInfo.Name = "LabelSolutionInfo";
            this.LabelSolutionInfo.Size = new System.Drawing.Size(467, 45);
            this.LabelSolutionInfo.TabIndex = 53;
            this.LabelSolutionInfo.Text = "Обчислення суми ряду";
            this.LabelSolutionInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValue
            // 
            this.labelValue.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.Location = new System.Drawing.Point(80, 240);
            this.labelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(400, 32);
            this.labelValue.TabIndex = 50;
            this.labelValue.Text = "Елементи ряду";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // listBoxValues
            // 
            this.listBoxValues.BackColor = System.Drawing.Color.LightGray;
            this.listBoxValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxValues.Font = new System.Drawing.Font("e-Ukraine Head", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 23;
            this.listBoxValues.Location = new System.Drawing.Point(80, 275);
            this.listBoxValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(401, 230);
            this.listBoxValues.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 21);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxDigits
            // 
            this.textBoxDigits.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDigits.Font = new System.Drawing.Font("e-Ukraine Head", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDigits.Location = new System.Drawing.Point(82, 170);
            this.textBoxDigits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDigits.Name = "textBoxDigits";
            this.textBoxDigits.Size = new System.Drawing.Size(341, 33);
            this.textBoxDigits.TabIndex = 47;
            this.textBoxDigits.Text = "textBoxDigits";
            this.textBoxDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDigits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDigits_KeyPress);
            // 
            // labelDigits
            // 
            this.labelDigits.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDigits.Location = new System.Drawing.Point(81, 135);
            this.labelDigits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDigits.Name = "labelDigits";
            this.labelDigits.Size = new System.Drawing.Size(342, 32);
            this.labelDigits.TabIndex = 46;
            this.labelDigits.Text = "Точнiсть виведення\r\n";
            this.labelDigits.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(153, 117);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 15);
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxE
            // 
            this.textBoxE.BackColor = System.Drawing.Color.LightGray;
            this.textBoxE.Font = new System.Drawing.Font("e-Ukraine Head", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxE.Location = new System.Drawing.Point(153, 86);
            this.textBoxE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(154, 33);
            this.textBoxE.TabIndex = 44;
            this.textBoxE.Text = "textBoxE";
            this.textBoxE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxE_KeyPress);
            // 
            // labelE
            // 
            this.labelE.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelE.Location = new System.Drawing.Point(153, 84);
            this.labelE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(155, 32);
            this.labelE.TabIndex = 43;
            this.labelE.Text = "labelE";
            this.labelE.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.операцiїToolStripMenuItem, this.вихiдToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip1.TabIndex = 42;
            // 
            // операцiїToolStripMenuItem
            // 
            this.операцiїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.обчислитиToolStripMenuItem, this.очищенняЕкрануToolStripMenuItem, this.прочитатиФайлToolStripMenuItem });
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
            this.очищенняЕкрануToolStripMenuItem.Click += new System.EventHandler(this.очищенняЕкрануToolStripMenuItem_Click);
            // 
            // прочитатиФайлToolStripMenuItem
            // 
            this.прочитатиФайлToolStripMenuItem.Name = "прочитатиФайлToolStripMenuItem";
            this.прочитатиФайлToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.прочитатиФайлToolStripMenuItem.Text = "Прочитати файл";
            this.прочитатиФайлToolStripMenuItem.Click += new System.EventHandler(this.прочитатиФайлToolStripMenuItem_Click);
            // 
            // вихiдToolStripMenuItem
            // 
            this.вихiдToolStripMenuItem.Name = "вихiдToolStripMenuItem";
            this.вихiдToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.вихiдToolStripMenuItem.Text = "Вихiд";
            this.вихiдToolStripMenuItem.Click += new System.EventHandler(this.вихiдToolStripMenuItem_Click);
            // 
            // labelVariantDescription
            // 
            this.labelVariantDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelVariantDescription.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariantDescription.Location = new System.Drawing.Point(810, 24);
            this.labelVariantDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVariantDescription.Name = "labelVariantDescription";
            this.labelVariantDescription.Size = new System.Drawing.Size(309, 115);
            this.labelVariantDescription.TabIndex = 55;
            this.labelVariantDescription.Text = "labelVariantDescription";
            this.labelVariantDescription.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(573, 341);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(298, 21);
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // textBoxSumma
            // 
            this.textBoxSumma.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSumma.Font = new System.Drawing.Font("e-Ukraine Head", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumma.Location = new System.Drawing.Point(573, 310);
            this.textBoxSumma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSumma.Name = "textBoxSumma";
            this.textBoxSumma.Size = new System.Drawing.Size(298, 33);
            this.textBoxSumma.TabIndex = 58;
            this.textBoxSumma.Text = "textBoxSumma";
            this.textBoxSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSumma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSumma_KeyPress);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(573, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(230, 115);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 60;
            this.pictureBox5.TabStop = false;
            // 
            // labelVariantDescription2
            // 
            this.labelVariantDescription2.BackColor = System.Drawing.Color.Transparent;
            this.labelVariantDescription2.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVariantDescription2.Location = new System.Drawing.Point(573, 139);
            this.labelVariantDescription2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVariantDescription2.Name = "labelVariantDescription2";
            this.labelVariantDescription2.Size = new System.Drawing.Size(546, 118);
            this.labelVariantDescription2.TabIndex = 61;
            this.labelVariantDescription2.Text = "labelVariantDescription2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "ε =";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("e-Ukraine Head", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(573, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 32);
            this.label2.TabIndex = 63;
            this.label2.Text = "Сума ряду";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(878, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 232);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // FormSolution2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1187, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVariantDescription2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxSumma);
            this.Controls.Add(this.labelVariantDescription);
            this.Controls.Add(this.LabelSolutionInfo);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.listBoxValues);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxDigits);
            this.Controls.Add(this.labelDigits);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSolution2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSolution2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSolution2_FormClosing);
            this.Load += new System.EventHandler(this.FormSolution2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelVariantDescription2;

        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxSumma;
        private System.Windows.Forms.Label labelSumma;

        private System.Windows.Forms.ToolStripMenuItem прочитатиФайлToolStripMenuItem;

        private System.Windows.Forms.Label labelVariantDescription;

        private System.Windows.Forms.Label LabelSolutionInfo;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxDigits;
        private System.Windows.Forms.Label labelDigits;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцiїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обчислитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очищенняЕкрануToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихiдToolStripMenuItem;

        #endregion
    }
}
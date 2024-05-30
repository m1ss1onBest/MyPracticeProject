using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Text = text;
        }

        private int borderSize = 3;
        public bool underlined = true;
        private Color borderColor = Color.Black;
        private string text = "";
        
        public Color BorderColor
        {
            set
            {
                borderColor = value;
                Invalidate();
            }
            get => borderColor;
        }
        public int BorderSize
        {
            set
            {
                borderSize = value;
                Invalidate();
            }
            get => borderSize;
        }
        public bool Underlined
        {
            set
            {
                underlined = value; 
                Invalidate();
            }
            get => underlined;
        }

        public char PasswordChar
        {
            set
            {
                textBox.PasswordChar = value;
                Invalidate();
            }
            get => textBox.PasswordChar;
        }
        
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            using (var pen = new Pen(borderColor, borderSize))
            {
                pen.Alignment = PenAlignment.Inset;
                if (underlined)
                {
                    g.DrawLine(pen, 0, Height-0.5f, Width, Height-0.5f);
                }
                else
                {
                    g.DrawRectangle(pen, 0, 0, Width-0.5f, Height-0.5f);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode) 
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        
        private void UpdateControlHeight()
        {
            int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
            textBox.Multiline = true;
            textBox.MinimumSize = new Size(0, txtHeight);
            textBox.Multiline = false;
            Height = textBox.Height + Padding.Top + Padding.Bottom;
        }
    }
}
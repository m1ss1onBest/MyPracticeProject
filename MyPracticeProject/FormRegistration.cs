using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPracticeProject
{
    public partial class FormRegistration : Form
    {
        // TabControl init
        public FormRegistration() => InitializeComponent();

        // default form components initialization
        private void Form1_Load(object sender, EventArgs e)
        {
            //setting colours
            labelInfo.Text = @"Проєкт";
            panel1.BackColor = Data.Pal.RegisterFormColor;
            
            //left part 
            labelMain.Text = @"Вхід у систему";
            labelMainInfo.Text = @"Для авторизації необхідно ввести персональні дані";
            labelLogoInfo.Text = @"Чабанюк Владислав | ПІ-222";
            labelProjectInformation.Text = @"Виконання індивідуальних практичних завдань по C# з використанням";
            labelTextWindowsForms.Text = @"Windows forms";
            
            labelEmail.Text = @"Е-пошта";
            labelPassword.Text = @"Пароль";
            
            //right part
            labelPasswordWarning.Text = labelEmailWarning.Text = "";
            
            //button design
            buttonLogIn.Text = @"Увійти";
            buttonAsGuest.Text = @"Увійти як гість";
            buttonAsGuest.FlatAppearance.BorderSize = 0;
            buttonLogIn.BackColor = Data.Pal.SuccessColor;
            buttonAsGuest.ForeColor = Data.Pal.SuccessColor;

            //textBox design
            textBoxPassword.PasswordChar = '•';
            textBoxEmail.Text = textBoxPassword.Text = "";
        }
        
        // setting text box by default (black color)
        private void SetDefault(TextBox textBox, PictureBox pictureBox, Label textEdit = null)
        {
            pictureBox.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\saved-line.png");
            textBox.ForeColor = Color.Black;
            if (textEdit != null)
            {
                textEdit.Text = "";
            }
        }
        
        // setting textbox this password cannot be used
        private void SetWarning(TextBox textBox, PictureBox pictureBox, Label textEdit = null)
        {
            textBox.ForeColor = Data.Pal.WarningColor;
            pictureBox.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\saved-line-warning.png");
            if (textEdit != null)
            {
                textEdit.ForeColor = Data.Pal.WarningColor;
                textEdit.Text = @"Розмір пароля має бути в діапазоні від 8 до 20 символів, та не повинен містити заборонених символів.";
            }
        }
        
        // setting textbox this password can be used
        private void SetAcceptable(TextBox textBox, PictureBox pictureBox, Label textEdit = null)
        {
            pictureBox.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\saved-line-success.png");
            textBox.ForeColor = Data.Pal.SuccessColor;
            if (textEdit != null)
            {
                textEdit.ForeColor = Data.Pal.SuccessColor;
                textEdit.Text = @"Пароль підходить";
            }
        }
        
        // displays error to a text box
        public static void SetError(TextBox textBox, PictureBox pictureBox, string message, Label textEdit = null)
        {
            pictureBox.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\saved-line-error.png");
            textBox.ForeColor = Data.Pal.ErrorColor;
            if (textEdit != null)
            {
                textEdit.ForeColor = Data.Pal.ErrorColor;
                textEdit.Text = message;
            }
        }

        // analyzing password input
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back)
            {
                if (textBoxPassword.Text.Length < 2)
                {
                    SetDefault(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                    return;
                }

                if (textBoxPassword.Text.Length < 9)
                {
                    SetWarning(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                    Data.isPasswordAcceptable = false;
                    e.Handled = false;
                    return;
                }
                SetAcceptable(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                Data.isPasswordAcceptable = true;
                e.Handled = false;
                return;
            }

            if (textBoxPassword.Text.Length >= 20 ||
                !Data.AllowedPassword.Contains(e.KeyChar))
            {
                e.Handled = true;
                SetWarning(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                Data.isPasswordAcceptable = false;
                return;
            }
            if (textBoxPassword.Text.Length < 7) 
            { 
                SetWarning(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                Data.isPasswordAcceptable = false;
                return;
            }
            SetAcceptable(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
            Data.isPasswordAcceptable = true;
            e.Handled = false;
        }

        // setting log in button
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            bool acceptable = true;
            if (!Data.MatchPassword(textBoxPassword.Text) || !Data.isPasswordAcceptable)
            {
                SetError(textBoxPassword, pictureBoxPasswordLabel, "Пароль невірний", labelPasswordWarning);
                acceptable = false;
            }
            if (Data.Email != textBoxEmail.Text)
            {
                SetError(textBoxEmail, pictureBoxEmailLabel, "Пошта не знайдена", labelEmailWarning);
                acceptable = false;
            }
            else
            {
                SetDefault(textBoxEmail, pictureBoxEmailLabel, labelEmailWarning);
            }

            if (acceptable)
            {
                Visible = false;
                FormManager.Start();
                Data.hasAcess = true;
            }
        }

        // log in as guest, then user has no access to edit files
        private void buttonAsGuest_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormManager.Start();
        }
    }
}

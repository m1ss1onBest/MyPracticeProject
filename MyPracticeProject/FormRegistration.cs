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
        public FormRegistration() => InitializeComponent();

        private const string AllowedPassword = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!~@#$;^&%*(){}[];?-_";
        private bool isPasswordAcceptable = false;
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
            checkBoxAgree.Text = @"Зберегти мене";
            buttonLogIn.BackColor = Data.Pal.SuccessColor;
            buttonAsGuest.ForeColor = Data.Pal.SuccessColor;

            //textBox design
            textBoxPassword.PasswordChar = '•';
            textBoxEmail.Text = textBoxPassword.Text = "";
            
            
            //TEST REGION
            // FormSolution1.Start();
        }
        
        private void SetDefault(TextBox textBox, PictureBox pictureBox, Label textEdit = null)
        {
            pictureBox.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\saved-line.png");
            textBox.ForeColor = Color.Black;
            if (textEdit != null)
            {
                textEdit.Text = "";
            }
        }
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
                    isPasswordAcceptable = false;
                    e.Handled = false;
                    return;
                }
                SetAcceptable(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                isPasswordAcceptable = true;
                e.Handled = false;
                return;
            }

            if (textBoxPassword.Text.Length >= 20 ||
                !AllowedPassword.Contains(e.KeyChar))
            {
                e.Handled = true;
                SetWarning(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                isPasswordAcceptable = false;
                return;
            }
            if (textBoxPassword.Text.Length < 7) 
            { 
                SetWarning(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
                isPasswordAcceptable = false;
                return;
            }
            SetAcceptable(textBoxPassword, pictureBoxPasswordLabel, labelPasswordWarning);
            isPasswordAcceptable = true;
            e.Handled = false;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            bool acceptable = true;
            if (!Data.MatchPassword(textBoxPassword.Text) || !isPasswordAcceptable)
            {
                Data.SetError(textBoxPassword, pictureBoxPasswordLabel, "Пароль невірний", labelPasswordWarning);
                acceptable = false;
            }
            if (Data.Email != textBoxEmail.Text)
            {
                Data.SetError(textBoxEmail, pictureBoxEmailLabel, "Пошта не знайдена", labelEmailWarning);
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

        private void buttonAsGuest_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormManager.Start();
        }
    }
}

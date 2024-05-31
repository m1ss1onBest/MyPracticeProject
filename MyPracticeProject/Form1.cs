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
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

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
            labelLogoInfo.Text = @"Моё ФИО, палить не хочу :D"; //Чабанюк Владислав ПІ-222
            labelProjectInformation.Text = @"Виконання індивідуальних практичних завдань по C# з використанням";
            labelTextWindowsForms.Text = @"Windows forms";
            
            labelUserName.Text = @"Ім'я Користувача";
            labelEmail.Text = @"Е-пошта";
            labelPassword.Text = @"Пароль";
            
            //right part
            labelPasswordWarning.Text = "";
            
            //button design
            buttonLogIn.Text = @"Увійти";
            buttonAsGuest.Text = @"Увійти як гість";
            buttonAsGuest.FlatAppearance.BorderSize = 0;
            checkBoxAgree.Text = @"Зберегти мене";
            buttonLogIn.BackColor = Data.Pal.SuccessColor;
            buttonAsGuest.ForeColor = Data.Pal.SuccessColor;

            //textBox design
            textBoxUserName.BorderStyle = textBoxEmail.BorderStyle = textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.PasswordChar = '•';
            textBoxUserName.Text = textBoxEmail.Text = textBoxPassword.Text = "";
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (int)Keys.Back && textBoxUserName.Text.Length >= 23)
            {
                e.Handled = true;
            }
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
        private void SetError(TextBox textBox, PictureBox pictureBox, string message, Label textEdit = null)
        {
            pictureBox.Image = Image.FromFile(@"D:\mwp\cs-practice\MyPracticeProject\MyPracticeProject\assets\saved-line-error.png");
            textBox.ForeColor = Data.Pal.ErrorColor;
            if (textEdit != null)
            {
                textEdit.ForeColor = Data.Pal.ErrorColor;
                textEdit.Text = message;
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
            if (!Data.MatchPassword(textBoxPassword.Text) || !isPasswordAcceptable)
            {
                SetError(textBoxPassword, pictureBoxPasswordLabel, "Пароль невірний", labelPasswordWarning);
                return;
            }
            Visible = false;
        }
    }
}

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
        private static readonly Color RegisterFormColor = Color.FromArgb(255, 65, 135, 192);
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = RegisterFormColor;
            
            labelMain.Text = @"Вхід у систему";
            labelMainInfo.Text = @"Для авторизації необхідно ввести персональні дані";
            label_INFO.Text = @"Інформація";
            labelLogoInfo.Text = @"Проєкт розробив студент групи ПІ-222 Чабанюк Владислав";
            labelProjectInformation.Text =
                @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
      
            labelUserName.Text = @"Ім'я Користувача";
            labelEmail.Text = @"Е-пошта Користувача";
            labelPassword.Text = @"Пароль Користувача";
            checkBoxAgree.Text = @"Зберегти мене";
            customTextBoxUserPassword.PasswordChar = '*';
            
            buttonAsGuest.Text = @"Увійти як гість";
            buttonAsGuest.FlatAppearance.BorderSize = 0;
            buttonLogIn.Text = @"Увійти";
        }
        
    }
}

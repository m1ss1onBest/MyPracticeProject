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
        private static readonly Color RegisterFormColor = Color.FromArgb(255, 30, 30, 30);
        private static readonly Color OtherFormColor= Color.FromArgb(255, 65, 135, 192);
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //setting colours
            labelInfo.Text = @"Інформація";
            panel1.BackColor = RegisterFormColor;
            labelProjectInformation.Text = @"Виконання індивідуальних практичних завдань по C#" + '\n' + @"з використанням " + @"Windows forms";
            
            //left part
            labelMain.Text = @"Вхід у систему";
            labelMainInfo.Text = @"Для авторизації необхідно ввести персональні дані";
            labelLogoInfo.Text = @"Моё ФИО, палить не хочу :D"; //Чабанюк Владислав ПІ-222
            
            labelUserName.Text = @"Ім'я Користувача";
            labelEmail.Text = @"Е-пошта";
            labelPassword.Text = @"Пароль";
            
            //button design
            buttonLogIn.Text = @"Увійти";
            buttonAsGuest.Text = @"Увійти як гість";
            buttonAsGuest.FlatAppearance.BorderSize = 0;
            checkBoxAgree.Text = @"Зберегти мене";

            //textBox desisgn
            textBoxUserName.BorderStyle = textBoxEmail.BorderStyle = textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.PasswordChar = '*';
            
        } 
        
    }
}

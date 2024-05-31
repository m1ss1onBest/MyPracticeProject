using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MyPracticeProject
{
   public class Data
   {
      public struct Pal
      {
         //monochrome
         public static readonly Color RegisterFormColor = Color.FromArgb(255, 30, 30, 30); 
         //textBox
         public static readonly Color WarningColor = Color.Gold;
         public static readonly Color SuccessColor = Color.MediumAquamarine;
         public static readonly Color ErrorColor = Color.Crimson;
         //orange
         public static readonly Color OrangeLight = Color.FromArgb(255, 255, 196, 96);
         public static readonly Color OrangeMedium = Color.FromArgb(255, 247, 174, 102);
         public static readonly Color OrangeDark = Color.FromArgb(255, 238, 145, 84);
      }
      
      
      private const String Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8";
      public static bool hasAcess = false;
      public static string Email = "susamogus@gmail.com";

      public static void ShowAccessRequired()
      {
         MessageBox.Show(@"У вас немає доступу до даного функцiоналу.", "Недостатнiй рiвень доступу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
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
      public static string HashPassword(string inputPassword)
      {
         using (SHA256 sha256 = SHA256.Create())
         {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
               builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString(); 
         }
      }

      public static bool MatchPassword(string password)
      {
         return Password == HashPassword(password);
      }
   }
}
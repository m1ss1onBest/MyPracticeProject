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
         // dark form color & default form  underline color
         public static readonly Color RegisterFormColor = Color.FromArgb(255, 30, 30, 30); 
         // text box underline warning color
         public static readonly Color WarningColor = Color.Gold;
         // text box underline success color
         public static readonly Color SuccessColor = Color.MediumAquamarine;
         // text box underline error color
         public static readonly Color ErrorColor = Color.Crimson;
         // orange form color
         public static readonly Color OrangeDark = Color.FromArgb(255, 238, 145, 84);
         public static readonly Color Green = Color.FromArgb(255, 130, 164, 103);
      }
      
      // user email
      public static string Email = "susamogus@gmail.com";
      // encoded password
      private const String Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8";
      // does the user have access to functions such as editing files, etc.
      public static bool hasAcess = false;
      // symbols allowed as password
      public const string AllowedPassword = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!~@#$;^&%*(){}[];?-_";
      // used to check if the user can log in
      public static bool isPasswordAcceptable = false;

      // shows that user has no acess to use this function
      public static void ShowAccessRequired()
      {
         MessageBox.Show(@"У вас немає доступу до даного функцiоналу.", "Недостатнiй рiвень доступу", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
      
      // encoding password using SHA256 method
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

      // checking if the password is correct
      public static bool MatchPassword(string password)
      {
         return Password == HashPassword(password);
      }
   }
}
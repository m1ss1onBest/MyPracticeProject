using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace MyPracticeProject
{
   public class Data
   {
      public struct Pal
      {
         public static readonly Color RegisterFormColor = Color.FromArgb(255, 30, 30, 30);
         public static readonly Color OtherFormColor = Color.FromArgb(255, 65, 135, 192);
         public static readonly Color WarningColor = Color.Gold;
         public static readonly Color SuccessColor = Color.MediumAquamarine;
         public static readonly Color ErrorColor = Color.Crimson;
      }

      private const String Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8";
      
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
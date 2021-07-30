using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApiService.Helpers
{
    public class CommonFunctions
    {
        public static string CreatePasswordHash(string password, string salt)
        {
            return HashPasswordForStoringInConfigFile(password + salt);
        }
        public static string HashPasswordForStoringInConfigFile(string password)
        {
            HashAlgorithm algorithm;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            algorithm = MD5.Create();
            return HexStringFromBytes(algorithm.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
        private static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
        public static string RandomString(int length = 5)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RemoveSpecialCharacters(string str)
        {
            if (str != null && !IsEmptyField(str))
                return str.Replace("\t", "");
            else
                return "";
        }

        public static bool IsEmptyField(string value)
        {
            return (string.IsNullOrEmpty(value) || value.Trim() == string.Empty || value == "");
        }

        public static int GetMonths(DateTime startDate, DateTime endDate)
        {
            int months = ((endDate.Year * 12) + endDate.Month) - ((startDate.Year * 12) + startDate.Month);

            if (endDate.Day > startDate.Day)
            {
                months++;
            }

            return months;
        }
    }
}

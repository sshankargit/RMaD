using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace RMaD.Classes
{
    /// <summary>
    /// Password encryption class
    /// Bcrypt password encryption is used
    /// </summary>
    public static class PasswordEncryption
    {        
        /// <summary>
        /// Generate random salt for password encryption
        /// </summary>
        /// <returns>random string</returns>
        private static string GetRandomSalt()
          {
             return BCrypt.Net.BCrypt.GenerateSalt(12);
          }

        /// <summary>
        /// Generate password hash        
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string HashPassword(string password)
         {
             return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
         }

        /// <summary>
        /// Validate password login
        /// </summary>
        /// <param name="password"></param>
        /// <param name="correctHash"></param>
        /// <returns></returns>
        public static bool ValidatePassword(string password, string correctHash)
         {
             return BCrypt.Net.BCrypt.Verify(password, correctHash);
         }
        
    }
}

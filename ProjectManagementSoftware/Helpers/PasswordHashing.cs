using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ProjectManagementSoftware.Helpers
{
    public static class PasswordHashing
    {
        public static string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        public static bool ValidateHash(string password, string correctHash)
        {
            string passwordHash = Hash(password);
            return passwordHash.Equals(correctHash);
        }
    }
}
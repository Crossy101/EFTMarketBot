using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using EFTBot.Shared.Classes;

namespace EFTBot.Data.Models.Configuration
{
    public class HardwareConfiguration
    {
        public string HardwareId { get; set; }

        public HardwareConfiguration()
        {
            this.HardwareId = CreateHWID().ToLower();
        }

        private string CreateHWID()
        {
            return $"#1-{RandomMD5Hash()}:{RandomMD5Hash()}:{RandomMD5Hash()}-{RandomMD5Hash()}-{RandomMD5Hash()}-{RandomMD5Hash()}-{RandomMD5Hash()}-{RandomShortMD5Hash()}";
        }

        #region MD5 Functions
        //Generate a random MD5 Hash 
        private static Random random = new Random();

        private static string RandomMD5Hash()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 40)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string RandomShortMD5Hash()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 32)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //MD5 Hashing for Login Process (/Login)
        private static string ComputeMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();

            byte[] hashBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            foreach (byte curByte in hashBytes)
            {
                sb.Append(curByte.ToString("X2"));
            }

            md5.Dispose();

            return sb.ToString();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAPD.db.models
{
    class Vam
    {
        public static bool loginAdmin;
        public static bool loginAngajat;
        public static string acces;
        public static bool apasareButon;
        public static int valID;
        public static int valIdAngajat;
        public static string rolAdmin="Administrator";
        public static string rolAngajat = "Angajat";
        public static bool logout;

        public static string Encode(string original)
        {
            byte[] encodedBytes;

            using (var md5 = new MD5CryptoServiceProvider())
            {
                var originalBytes = Encoding.Default.GetBytes(original);
                encodedBytes = md5.ComputeHash(originalBytes);
            }

            return Convert.ToBase64String(encodedBytes);
        }

    }

 
   
}

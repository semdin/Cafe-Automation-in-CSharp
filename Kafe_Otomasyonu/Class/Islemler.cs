using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semdin_Kafe_Otomasyonu
{
    class Islemler
    {
        public static string MD5eDonustur(string metin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] Girdi = Encoding.UTF8.GetBytes(metin);
            Girdi = md5.ComputeHash(Girdi);
            StringBuilder StringBuilderler = new StringBuilder();
            foreach (byte ba in Girdi)
            {
                StringBuilderler.Append(ba.ToString("x2").ToLower());
            }
            return StringBuilderler.ToString();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ODEV1
{
    public static class Yazdirma
    {
        public static void Yazdır(string cumle)
        {
            string dosya_yolu = @"C:\hamleler.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(cumle);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}

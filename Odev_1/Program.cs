using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1
{
    class Program
    {
        static void Main(string[] args)
        {//Melike Yılmaz ile birlikte çalıştık
            Random rng = new Random();
            Object[,] Saha = new Object[16, 16];
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 16; j++)
                    Saha[i, j] = new Bolge(i, j);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1
{
    class ErMeydani
    {
        Bolge[,] harita = new Bolge[16, 16];

        public Bolge[,] Harita { get { return harita; } set { harita = value; } }

        public ErMeydani(Takim t)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Harita[i, j] = new Bolge(i, j);
                }
            }
            
        }

    }
}

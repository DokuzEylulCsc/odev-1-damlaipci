using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1
{
    class Takim
    {
        Asker[] takim = new Asker[7];
        Asker[] takim2 = new Asker[7];
        public Asker[] TaKim { get { return takim; } set { takim = value; } }
        public Asker[] TaKiM2 { get { return takim2; } set { takim2 = value; } }


        public Takim() 
        {
           for (int i = 0; i < 4; i++) //takim1in 4 adet eri var
            {
                this.TaKim[i] = new Er();
            }
            this.TaKim[4] = new Tegmen();
            this.TaKim[5] = new Tegmen(); //2 adet tegmen 1 yuzbası
            this.TaKim[6] = new Yuzbasi();
            foreach (Asker item in TaKim)
            {
                item.takimBilgisi = 1;
            }
            for (int i = 0; i <= 4; i++) //takim2nin 5 adet eri var
            {
                this.TaKiM2[i] = new Er();
            }
            this.TaKiM2[5] = new Tegmen(); //takimin diğer iki elemanı Tegmen ve yüzbası
            this.TaKiM2[6] = new Yuzbasi();
            foreach (Asker item in TaKiM2)
            {
                item.takimBilgisi = 2;
            }
        }

        // ..... //
    }
}

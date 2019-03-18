using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } set { koordinat = value; } }
        public int Xkonum = 0, Ykonum = 0;//kordinatlar
        public int can = 100; // Askerin başlangıç canı
        public int takimBilgisi;
        public bool yasam= true; // Askerlerin yaşayıp yaşamadıklarını kontrol ediyoruz

        public abstract void Bekle();
        public abstract void Hareket_Et(Object[,] saha);
        public abstract void Ates_Et(Object[,] saha);

        // ..... //
    }
}

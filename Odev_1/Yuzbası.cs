using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1
{
    internal class Yuzbası : Asker
    {

        public Yuzbası(int takim, int x, int y)
        {
            takimBilgisi = takim;
            Xkonum = x;
            Ykonum = y;
        }
        public override void Bekle()
        {
            //Bırsey yapmıyor.
        }
        public override void Hareket_Et(Object[,] saha)
        {
            Random random = new Random();
            bool kontrol, kontrol2;
            int xSans, ySans, atesEtme;
            do
            {
                do
                {
                    kontrol = true;
                    xSans = random.Next(-1, 2);
                    ySans = random.Next(-1, 2);
                    if (xSans == 0 && ySans == 0)
                        kontrol = false;
                } while (!kontrol);

                if (saha[Xkonum + xSans, Ykonum + ySans] is Bolge b)
                {
                    Xkonum = +xSans;
                    Ykonum = +ySans;
                    kontrol2 = true;
                }
                else
                {
                    Bekle();
                    kontrol2 = true;
                }
            } while (!kontrol2);
            atesEtme = random.Next(0, 2);
            if (atesEtme == 1)
            {
                Ates_Et(saha);
            }
        }
        public override void Ates_Et(Object[,] saha)
        {
            Random random = new Random();
            int sans = random.Next(100);
            for (int i = -3; i < 4; i++)       //komşusu olan tüm askerlere vuruyo
                for (int j = -3; j < 4; j++)
                {
                    if (saha[i, j] is Asker a && a.takimBilgisi != this.takimBilgisi)
                    {
                        if (sans < 10)       //10
                        {
                            a.can = -40;
                            Yazdirma.Yazdır("Cani 10 azaldı");
                        }
                        else if (sans < 40)     //30
                        {
                            a.can = -25;
                            Yazdirma.Yazdır("Canı 30 azaldı");
                        }
                        else    //60
                        {
                            a.can = -15;
                            Yazdirma.Yazdır("Canı 60 azaldı");
                        }
                        if (a.can <= 0)
                        {
                            a.yasam = false;
                            Yazdirma.Yazdır("Öldü");
                            saha[Xkonum, Ykonum + 2] = new Bolge(Xkonum, Ykonum + 2);
                        }
                    }
                }
        }

    }
}

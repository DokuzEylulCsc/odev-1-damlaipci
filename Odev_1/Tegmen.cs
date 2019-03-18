using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1
{
    class Tegmen : Asker
    {
        

        public Tegmen(int takim, int x, int y)
        {
            takimBilgisi = takim;
            Xkonum = x;
            Ykonum = y;
        }

        public Tegmen()
        {
        }

        public override void Bekle()
        {
            //Birsey yapmıyor
        }

        public override void Hareket_Et(Object[,] saha)
        {
            Random random = new Random();
            bool kontrol, kontrol2;
            int yon = random.Next(2);
            int xSans = 0, ySans = 0, atesEtme = random.Next(0, 2);
            if (yon == 0)                       // sağa sola gitmesi
            {
                do
                {
                    do
                    {
                        kontrol = true;
                        xSans = random.Next(-1, 2);
                        if (xSans == 0 && ySans == 0)
                            kontrol = false;
                    } while (!kontrol);

                    if (saha[Xkonum + xSans, Ykonum] is Bolge b)
                    {
                        Xkonum = +xSans;
                        kontrol2 = true;
                    }
                    else
                    {
                        Bekle();
                        kontrol2 = true;
                    }
                } while (!kontrol2);
            }
            else                                    // yukarı ya da aşağı gitmesi
            {
                do
                {
                    do
                    {
                        kontrol = true;
                        ySans = random.Next(-1, 2);
                        if (xSans == 0 && ySans == 0)
                            kontrol = false;
                    } while (!kontrol);

                    if (saha[Xkonum, Ykonum + ySans] is Bolge b)
                    {
                        Ykonum = +ySans;
                        kontrol2 = true;
                    }
                    else
                    {
                        kontrol2 = false;
                    }
                } while (!kontrol2);
            }
            if (atesEtme == 1)
            {
                Ates_Et(saha);
            }
        }

        public override void Ates_Et(Object[,] saha)
        {
            Random random = new Random();
            int sans = random.Next(100);
            for (int i = -2; i < 3; i++)       //komşusu olan tüm askerlere vuruyo
                for (int j = -2; j < 3; j++)
                {
                    if (saha[i, j] is Asker a && a.takimBilgisi != this.takimBilgisi)
                    {
                        if (sans < 20)       //20
                        {
                            a.can = -25;
                            Yazdirma.Yazdır("Cani 20 azaldı");
                        }
                        else if (sans < 50)     //30
                        {
                            a.can = -20;
                            Yazdirma.Yazdır("Cani 30 azaldı");
                        }
                        else    //50
                        {
                            a.can = -10;
                            Yazdirma.Yazdır("Cani 50 azaldı");

                        }
                        if (a.can <= 0)
                        {
                            a.yasam = false;        // yazdırılıcak burada
                            saha[Xkonum, Ykonum + 2] = new Bolge(Xkonum, Ykonum + 2);
                        }
                    }
                }
        }
    }
}

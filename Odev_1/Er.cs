﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV1
{
    class Er : Asker
    {
        public Er(int takim, int x, int y)
        {
            takimBilgisi = takim;
            Xkonum = x;
            Ykonum = y;
        }

      

        public override void Bekle()
        {

        }
        public override void Hareket_Et(Object[,] saha)
        {
            Random random = new Random();
            bool kontrol, kontrol2;
            int ySans = 0;              // yukarı aşağı gitme kısmı
            do
            {
                do
                {
                    kontrol = true;
                    ySans = random.Next(-1, 2);
                    if (ySans == 0)
                        kontrol = false;
                } while (!kontrol);

                if (saha[Xkonum, Ykonum + ySans] is Bolge b)
                {
                    Ykonum = +ySans;
                    kontrol2 = true;
                }
                else
                {
                    Bekle();
                    kontrol2 = true;
                }
            } while (!kontrol2);


        }
        public override void Ates_Et(Object[,] saha)
        {
            Random random = new Random();
            int sans = random.Next(100);
            for (int i = -1; i < 2; i++)       //komşusu olan tüm askerlere vuruyo
                for (int j = -1; j < 2; j++)
                {
                    if (saha[i, j] is Asker a && a.takimBilgisi != this.takimBilgisi)
                    {
                        if (sans < 25)       //25
                        {
                            a.can = -15;
                            Yazdirma.Yazdır("Cani 25 azaldı");

                        }
                        else if (sans < 55)     //30
                        {
                            a.can = -10;
                            Yazdirma.Yazdır("Cani 30 azaldı");
                        }
                        else    //45
                        {
                            a.can = -5;
                            Yazdirma.Yazdır("Cani 45 azaldı");
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

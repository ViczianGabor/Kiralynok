﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kiralynok
{
    class tabla
    {
        private char[,] t;
        private char Urescella;
        private int uresOszlopSzam;
        private int UresSorokszama;
       





        public tabla(char ch)
        {
            t = new char[8, 8];
            Urescella = ch;
            for (int i = 0; i < 8; i++)
            {
                
                for (int j = 0; j < 8; j++)
                {
                    t[i, j] = Urescella;
                }
            }
        }


        public void elhelyez(int N)
        {
            //véletlen helyiérték létrehozása
            // - random osztály értékek halmaza: [0,7]
            // - véletlen sor és oszlop
            // - elhelyezzük a k-t
            // - HA!!!! ÜRES -> "#"

      
            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                bool igaz = true;
                while (igaz)
                {
                    int sor = rnd.Next(0, 8);
                    int oszlop = rnd.Next(0, 8);
                    if (t[sor, oszlop] == Urescella)
                    {
                        t[sor, oszlop] = 'K';
                        igaz = false;
                    }

                }

            }






        }


        public void fajlbair(StreamWriter fajl)
        {

            //fajl.WriteLine("Ez egy szöveg");
            for (int i = 0; i < 8; i++)
            {
                string sor = "";
                for (int j = 0; j < 8; j++)
                {
                    sor += t[i, j];
                }
                fajl.WriteLine(sor);
            }
            
            
            
            





        }
        public void megjelenit()
        {
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} ",t[i,j]);

                }
                Console.Write("\n");
            }
            Console.WriteLine();

        }



        public bool uresoszlop(int oszlop)
        {
            int i = 0;

            while (i < 8 && t[i, oszlop] != 'K')
            {
                i++;
            }

            if (i < 8)
            {
                return false;
            }
            else
            {

                return true;
            }

            /*
            int i = 0;
            bool van = true;
            while (van&& i<8)
            {
                if (t[i,oszlop] == 'K')
                {
                    van = false;
                    return false;
                }

                i++;
            }
            return true;
            */


        }

        public bool uresSor(int sor)
        {
            /* int i = 0;

              bool van = true;
              while (van && i < 8)
              {
                  if (t[sor,i] == 'K')
                  {
                      van = false;
                      return false;
                  }
                  i++;
              }

              return true;
              */
            int i = 0;
            
            while(i<8 && t[sor,i] != 'K')
            {
                i++;
            }

            if (i<8)
            {
                return false;
            }
            else
            {

                return true;
            }




           

        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            tabla t = new tabla('#');
            tabla[] tablak = new tabla[64];







            Console.WriteLine("Üres tábla:");
            t.megjelenit();
            t.elhelyez(1);
            Console.WriteLine("\n");
            t.megjelenit();

            if (t.uresSor(2))
            {
                Console.WriteLine("A sor üres");
            }
            else
            {
                Console.WriteLine("A sor NEM üres");
            }

            if (t.uresoszlop(2))
            {
                Console.WriteLine("Az oszlop üres");

            }
            else
            {
                Console.WriteLine("Az oszlop NEM üres");
            }

            Console.WriteLine("8. feladat: Az öresoszlopok ls sorok száma \n");

            int uressor = 0;
            int uresoszlop = 0;
            for (int j = 0; j < 8; j++)
            {
                if (t.uresoszlop(j) == true)
                {
                    uresoszlop++;
                }
                if (t.uresSor(j) == true)
                {
                    uressor++;
                }
            }

            Console.WriteLine("Üres sorok száma:"+ uressor);
            Console.WriteLine("Üres oszlopok száma: "+ uressor);


            StreamWriter ki = new StreamWriter("adatok.txt");

            for (int k = 0; k < 64; k++)
            {
                tablak[k] = new tabla('*');
            }

            for (int i = 0; i < 64; i++)
            {
                tablak[i].elhelyez(i + 1);
                tablak[i].fajlbair(ki);
                ki.WriteLine();
            }






            

            ki.Close();








            Console.ReadKey();
        }
    }
}

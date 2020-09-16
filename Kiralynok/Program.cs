using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int sor = rnd.Next(0,8);
            int oszlop = rnd.Next(0, 8);
            if (t[sor,oszlop]== '#')
            {
                t[sor, oszlop] = 'K';
            }
            

        }


        public void fajlbair()
        {



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



        public int uresoszlop()
        {
            return 0;
        }

        public int uresSor()
        {
            return 0;


        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            tabla t = new tabla('#');
            Console.WriteLine("Üres tábla:");
            t.megjelenit();
            t.elhelyez(1);
            Console.WriteLine("\n");
            t.megjelenit();


            Console.ReadKey();
        }
    }
}

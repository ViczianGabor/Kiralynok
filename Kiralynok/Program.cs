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


        public void elhelyez()
        {

        }


        public void fajlbair()
        {



        }
        public void megjelenit()
        {


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
            
            //tabla k = new tabla();
            



            Console.ReadKey();
        }
    }
}

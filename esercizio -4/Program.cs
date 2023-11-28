using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio__4
{
    class Quadrato
    {
        private int lato1;
        private int lato2;

        public Quadrato()
        {
            lato1 = 0;
            lato2 = 0;
        }

        //Costruttore con parametri
        public Quadrato(int lato1, int lato2)
        {
            this.lato1 = lato1;
            this.lato2 = lato2;

        }

        public int Lato1
        {
            get { return lato1; }
            set
            {
                if (value > 0)
                {
                    lato1 = value;
                }
                else
                {
                    Console.WriteLine("Lato deve essere > 0");
                }
            }
        }

        public int Lato2
        {
            get { return lato2; }
            set
            {
                if (value > 0)
                {
                    lato2 = value;
                }
                else
                {
                    Console.WriteLine("Lato deve essere > 0");
                }
            }
        }

        
        public void Calcquadrato()
        {
            Console.WriteLine("Area Quadrato: " + lato1 * lato2);
            Console.WriteLine("Perimetro Quadrato: " + lato1 * 4);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int latouno = 0;
            int latodue = 0;
            Console.WriteLine("Inserire lunghezza primo lato:");
            latouno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire lunghezza secondo lato:");
            latodue = Convert.ToInt32(Console.ReadLine());

            Quadrato quadrato = new Quadrato(latouno, latodue);
            quadrato.Calcquadrato();
            Console.ReadLine();
        }
    }
}

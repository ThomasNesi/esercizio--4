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

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

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

        public Quadrato()
        {
            lato1 = 0;
        }

        //Costruttore con parametri
        public Quadrato(int lato1)
        {
            this.lato1 = lato1;

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

        
        public void Calcquadrato()
        {
            Console.WriteLine("Area Quadrato: " + (lato1 * lato1));
            Console.WriteLine("Perimetro Quadrato: " + lato1 * 4);
        }

        public void Calccubo()
        {
            Console.WriteLine("Superficie totale del cubo: " + (6*(lato1*lato1)));
            Console.WriteLine("Volume del cubo: " + (lato1*lato1*lato1));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int latouno = 0;
            Console.WriteLine("Inserire lunghezza primo lato:");
            latouno = Convert.ToInt32(Console.ReadLine());

            Quadrato quadrato = new Quadrato(latouno);
            Quadrato cubo = new Quadrato(latouno);
            quadrato.Calcquadrato();
            cubo.Calccubo();
            Console.ReadLine();
        }
    }
}

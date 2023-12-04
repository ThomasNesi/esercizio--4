using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio__4
{
    public class Quadrato
    {
        public int lato1;

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
    }
    public class Cubo : Quadrato
    {
        public int lato2 { get; set; } 
        public Cubo()
        {
            lato2 = 0;
        }
        public Cubo(int lato2)
        {
            this.lato2 = lato2;
        }
        public void CalcCubo()
        {
            Console.WriteLine("Superficie totale cubo: " + 6 * (lato2 * lato2));
            Console.WriteLine("Volume cubo: " + lato2 * lato2 * lato2);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int latouno = 0;
            Console.WriteLine("Inserire lunghezza lato:");
            latouno = Convert.ToInt32(Console.ReadLine());

            Quadrato quadrato = new Quadrato(latouno);
            Cubo cubo = new Cubo(latouno);
            quadrato.Calcquadrato();
            cubo.CalcCubo();
            Console.ReadLine();
        }
    }
}

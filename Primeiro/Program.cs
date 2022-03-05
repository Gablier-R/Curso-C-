using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(String[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();
            
            Inserir(x.A, x.B, x.C, y.A, y.B, y.C);

            int areaX = x.CalcularArea();
            int areaY = y.CalcularArea();

            Comparar(areaX,areaY);
        }

        static int Inserir(int xa, int xb, int xc, int ya, int yb, int yc) 
        {
            Console.WriteLine("Medidas do triangulo x: ");
            xa = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb  = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Medidas do triangulo y: ");
            ya = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return 0;
        }


        static int Comparar(int areax, int areay) 
        {
            if (areax > areay) 
            {
                Console.WriteLine("Triangulo X tem area maior que Y.");
            }
            else if (areay > areax) 
            {
                Console.WriteLine("Triangulo Y tem area maior que X.");
            }
            else 
            {
                Console.WriteLine("Areas iguais.");
            }
            return 0;
        }
    }
}



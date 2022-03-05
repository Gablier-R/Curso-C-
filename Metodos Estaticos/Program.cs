using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Metodos_Estaticos
{
    internal class Program
    {
        static void Main (String[] args) 
        {
            Console.Write("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Cincunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: "+ volume.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("Valor de PI: "+ Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

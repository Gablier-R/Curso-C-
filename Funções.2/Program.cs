using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Funções.NovaPasta
{
    internal class Program
    {
        static void Main(String[] args) 
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com os dados do Retangulo: ");

            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do retangulo: " + r);
        }
    }
}

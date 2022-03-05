using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Vetor;

namespace Funções.NovaPasta

{
    internal class Program
    {
        static void Main(String[] args)
        {
            string[] vet = new string[] {"Maria", "Alex", "Bob" };

            foreach (string v in vet) 
            {
                Console.WriteLine(v);
            }
        }
    }
}
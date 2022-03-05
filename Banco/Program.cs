using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Banco;

namespace Funções.NovaPasta
  
{
    internal class Program
    {
        static void Main(String[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial: ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S') 
            {
                Console.WriteLine(" Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da Conta: "+ conta);
            Console.WriteLine();

            Console.Write("Ente um valor para deposito: ");

            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta arualuzados: ");
            Console.WriteLine(conta);


            Console.Write("Ente um valor para saque: ");

            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta arualuzados: ");
            Console.WriteLine(conta);
        }




    }
}
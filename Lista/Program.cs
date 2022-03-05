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

            //Criando, inicializando e atribuindo valores a Lista
            /*
            List<string> lista = new List<string>();

            List<string> lista2 = new List<string> { "Maria"};
            */

            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Bob");
            lista.Add("Alex");
            lista.Add("Anna");

            lista.Insert(0, "Marco");

            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(lista.Count);


//Usando expressão lambda, Dados de quem começa com A

            string s1 = lista.Find(x => x[0] =='A');
            Console.WriteLine(s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

//Usando expressão lambda, para achar a Posição do dado
            int pos = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

//Filtrando lista com um predicado
            List<string> lista2 = lista.FindAll(x => x.Length == 5);

            foreach(string str in lista2) 
            {
                Console.WriteLine(str);
            }

            //Removendo da lista pelo dado
            lista.Remove("Alex");

           

            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }

            lista.RemoveAll( x => x[0] == 'M');

            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }

            //Removendo da Lista pela posição

            lista.RemoveAt(1);


            //Removendo de uma faixa especifica
            lista.RemoveRange(2,2);
        }
    }
}
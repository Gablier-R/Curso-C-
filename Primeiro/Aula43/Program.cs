using Aula43;
using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(String[] args)
        {


            Console.WriteLine("Entre ccom os dados do produto: ");

            Console.Write("nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco, quantidade);
            Produto p = new Produto {Nome=nome, Preco=preco, Quantidade=quantidade};


            Console.WriteLine();
            Console.WriteLine("Dados do produto: "+p);


            Console.Write("Digite numero de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine("Dados Atualizados: "+p);


            Console.WriteLine("Digite numero de produtos a ser removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutor(qte);

            Console.WriteLine("Dados atualizados: "+p);
        }
    }
}



using System;
using System.Globalization;


namespace Aula43
{
    internal class Produto
    {
        private string? _nome;
        public double Preco { get; private set; }
        private int _quantidade;




        public Produto() {}

        public string GetNome() 
        {
            return _nome; 
        }

        public void SetNome(string nome) 
        {
            if (nome != null && nome.Length >1)
            {
                _nome = nome;
            }
            
        }

        public double ValorTotal() 
        {
            return Preco * _quantidade;
        }

        public void AdicionarProduto(int quantidade) 
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutor(int quantidade) 
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                +" Unidades, Total: $" 
                + ValorTotal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

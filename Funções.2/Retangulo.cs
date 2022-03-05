using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções.NovaPasta
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Altura * Largura;
        }

        public double CalcularPerimetro() 
        {
            return 2* (Altura + Largura);
        }

        public double CalcularDiagonal() 
        {
            return Math.Sqrt( (Altura * 2) + (Largura * 2) );
        }

        public override string ToString()
        {
            return " Area: "+CalcularArea()
                  +"\n Perimetro: "+CalcularPerimetro()
                  +"\n Diagonal: "+CalcularDiagonal();
        }
    }

   
}

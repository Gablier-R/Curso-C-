using System;

namespace Primeiro
{
    internal class Triangulo
    {
        public int A;
        public int B;
        public int C;

        public int CalcularArea()
        {
            int p = (A + B + C) / 2;
            return (int)Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

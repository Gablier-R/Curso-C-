
namespace Metodos_Estaticos
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double raioP)
        {
            return 2.0 * Pi * raioP;
        }

        public static double Volume(double raioP)
        {
            return 4.0 / 3.00 * Pi * Math.Pow(raioP, 3.0);
        }
    }
}

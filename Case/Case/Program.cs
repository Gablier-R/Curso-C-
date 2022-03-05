using System;

namespace Case 
{
    public class Program
    {
        static void Mains(string[] args) 
        {
            int x = int.Parse(Console.ReadLine());
            string dia;

            switch (x) 
            {
                case 1:
                    dia = "Segunda";
                    break;

                case 2:
                    dia = "Terça";
                    break ;

                case 3:
                    dia = "Quarta";
                    break;

                    default:
                    dia = "Invalido";
                    break;
                    
            }
        }
    }
}



using System;
using System.Text;

namespace SerieParaMalharStart.Algoritmo23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*o que é media ponderada?*/
            /*
             * Operadores Aritméticos
             * 
             * float x, y, calculo;
             * calculo = x + y;
             * calculo = x*y;
             * calculo =x / y; */
            /*
             * 
             * Frameworks
             * ASP.NET x Spring x JBOSS Seam x Entity Framework
             */

            double raiz = Math.Sqrt(25);
            Console.WriteLine($"A raiz é:{raiz}");
            double PI = Math.PI;
            Console.WriteLine($"Valor de PI{PI}");
            double quadrado = Math.Pow(5, 2);
            Console.WriteLine($"Vlaor ao quadrado:{quadrado}");
            double cubico = Math.Pow(3, 3);
            Console.WriteLine($"Valor ao cubo:{cubico}");
            Console.ReadKey();
        }
    }

}     

using System;
using System.Text;

namespace SerieParaMalharStart.Algoritmo28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, total;

            Console.WriteLine("Digite o número 1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número 2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            total = numero1 * numero2;

            Console.WriteLine("O produto dos números é: " + total);
            Console.ReadKey();
            
        }
    }
}

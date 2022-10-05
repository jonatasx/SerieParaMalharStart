using System;
using System.Text;

namespace SerieParaMalharStart.Algoritmo28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3, total;
            

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            total = ( numero1 + numero2 + numero3) / 3;

            Console.WriteLine("A média aritmética dos números é: " + total);
            Console.ReadKey();

        }
    }
}

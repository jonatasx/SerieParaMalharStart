using System;
using System.Text;

namespace SerieParaMalharStart.Algoritmo28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;


            Console.WriteLine("Digite o seu número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("O número antecessor é : " + (numero1 - 1));


            Console.WriteLine("O número  sucessor é : " + (numero1 + 1));
            Console.ReadKey();

        }
    }
}


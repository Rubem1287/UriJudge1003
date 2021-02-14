using System;

namespace Uri_1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine();
            Console.Write("Digite o primeiro número : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Digite o Segundo número : ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine();
            Console.WriteLine("SOMA = "+soma);
        }
    }
}

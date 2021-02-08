using System;

namespace exercicio_04GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a palavra 1: ");
            var A = Console.ReadLine();
            Console.Write("Entre com a palavra 2: ");
            var B = Console.ReadLine();

            var transitoria = A;
            A = B;
            B = transitoria;

            Console.WriteLine($"{A} {B}");
        }
    }
}

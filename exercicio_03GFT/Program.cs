using System;

namespace exercicio_03GFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var numeroDigitado = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDigitado; i++)
            {
                Console.Write("Incomoda ");
            }

            Console.Write("muito mais");
        }
    }
}


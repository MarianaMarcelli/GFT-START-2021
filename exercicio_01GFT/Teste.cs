using System;

namespace exercicio_01GFT
{
    public class Teste

    
    {static void Main(string[] args)
    {

    
        
        Quadrado quadrado = new Quadrado(2.0);

        Retangulo retangulo = new Retangulo(2.0 , 2.0);

        Circulo circulo = new Circulo(1.0);

        Console.WriteLine(" A área do quadrado é: " + quadrado.CalcularArea());
        Console.WriteLine(" A área do retangulo é: " + retangulo.CalcularArea());
        Console.WriteLine(" A área do circulo é: " + circulo.CalcularArea());

    }
}
}

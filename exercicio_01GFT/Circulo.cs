using System;

namespace exercicio_01GFT
{
    public class Circulo: IAreaCalculavel
    {
        private const double PI = Math.PI;
        public double Raio { get; set; }

        public double Area { get; set; }


        public Circulo (double raio)
        {
           this.Raio = raio;
        }

        public double CalcularArea()
        {
            return PI *Math.Pow(this.Raio, 2);
        }
    }
}
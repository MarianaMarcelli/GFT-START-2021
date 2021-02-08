namespace exercicio_01GFT
{
    public class Quadrado : IAreaCalculavel
    {
        public double Lado { get; set; }

        public double Area { get; set; }

    
    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public double CalcularArea()
    {
        return this.Lado * this.Lado;
    }

    }
}


namespace exercicio_01GFT
{
    public class Retangulo: IAreaCalculavel
    {
        public double Largura { get; set; }   
        public double Altura { get; set; }

        public Retangulo(double largura , double altura)
         {
             this.Largura = largura;
             this.Altura = altura;
         }

         public double CalcularArea()
        {
            return this.Largura * this.Altura;
        }


}

    }

   
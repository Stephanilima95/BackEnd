namespace ExerciciosConstrutores
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public Retangulo()
        {
            Largura = 1;
            Altura = 1;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}

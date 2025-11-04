namespace ExerciciosConstrutores
{
    public class AlunoMedia
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public AlunoMedia(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public AlunoMedia(string nome)
        {
            Nome = nome;
            Nota1 = Nota2 = Nota3 = 0;
        }

        public double CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public void ExibirMedia()
        {
            Console.WriteLine($"Aluno: {Nome} | Média: {CalcularMedia():F2}");
        }
    }
}

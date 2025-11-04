namespace ExerciciosConstrutores
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public Aluno()
        {
            Nome = "Desconhecido";
            Nota = 0.0;
        }

        public Aluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome} | Nota: {Nota}");
        }
    }
}

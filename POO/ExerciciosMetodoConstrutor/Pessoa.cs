namespace ExerciciosConstrutores
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            Nome = "Sem nome";
            Idade = 0;
        }

        public Pessoa(string nome)
        {
            Nome = nome;
            Idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade}");
        }
    }
}

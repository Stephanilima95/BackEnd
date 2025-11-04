namespace ExerciciosConstrutores
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome)
        {
            Nome = nome;
            Cargo = "Não definido";
            Salario = 0;
        }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = 0;
        }

        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Funcionário: {Nome} | Cargo: {Cargo} | Salário: R${Salario:F2}");
        }
    }
}

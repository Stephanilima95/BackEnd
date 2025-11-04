using ExerciciosMetodoConstrutor;
using ExerciciosConstrutores;

class Program
{
    static void Main()
    {
        Carro carro = new Carro("Toyota", "Corolla", 2022);
        carro.ExibirDados();

        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno("Maria", 9.5);
        aluno1.ExibirDados();
        aluno2.ExibirDados();

        Produto produto = new Produto("Notebook", 3500.00, 5);
        produto.ExibirDados();

        ContaBancaria conta1 = new ContaBancaria("João", 1000);
        ContaBancaria conta2 = new ContaBancaria("Ana");
        conta1.ExibirDados();
        conta2.ExibirDados();

        Retangulo ret = new Retangulo(5, 3);
        Console.WriteLine($"Área: {ret.CalcularArea()}");

        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa("Lucas");
        Pessoa p3 = new Pessoa("Lara", 25);
        p1.ExibirDados();
        p2.ExibirDados();
        p3.ExibirDados();
    }
}
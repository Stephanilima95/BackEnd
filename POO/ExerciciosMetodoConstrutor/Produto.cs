namespace ExerciciosConstrutores
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome} | Preço: R${Preco:F2} | Estoque: {Estoque}");
        }
    }
}

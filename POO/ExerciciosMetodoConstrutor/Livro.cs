namespace ExerciciosConstrutores
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public double Preco { get; set; }

        public Livro(string titulo, string autor, double preco)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = preco;
        }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Preco = 0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Livro: {Titulo} | Autor: {Autor} | Preço: R${Preco:F2}");
        }
    }
}

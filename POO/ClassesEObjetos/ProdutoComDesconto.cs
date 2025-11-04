  void Produto()
    {
        int menu = 0;
        do
        {
            Console.Clear();
            Produto p1 = new Produto();
            Console.WriteLine("Qual o nome do produto?");
            Console.WriteLine($"");
            Console.WriteLine($"");
            p1.Nome = Console.ReadLine();

            Console.WriteLine($"Qual o preço de {p1.Nome}");
            Console.WriteLine($"");
            Console.WriteLine($"");
            p1.Preco = int.Parse(Console.ReadLine());
            double percentual = 0;
            p1.AplicarDesconto(percentual);

            Console.WriteLine($"Deseja voltar ao menu ou continuar no sistema?");
            Console.WriteLine($"1 - Sistema");
            Console.WriteLine($"0 - Menu");
            Console.WriteLine($"");
            Console.WriteLine($"");
            menu = int.Parse(Console.ReadLine());
        } while (menu != 0);
    }
} while (op != 0);
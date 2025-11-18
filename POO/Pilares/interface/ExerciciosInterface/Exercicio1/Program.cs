using Exercicios1;
Console.Clear();
Console.WriteLine($"Bem vindo ao programa Calculos de Geometria :) =====");
Console.WriteLine();
Console.WriteLine($"Vamos calcular o Retangulo ");
Console.WriteLine();
Console.WriteLine($"Digite a largura do Retangulo:");
float l = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a altura do Retangulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Agora vamos calcular a area do Circulo ");
Console.WriteLine();
Console.WriteLine($"Informe o raio do Circulo:");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Fim do programa ");
Console.WriteLine();
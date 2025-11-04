using MetodoConstrutor;
Pessoa3Sobrecargas fontes = new Pessoa3Sobrecargas("joao, 17");

// fontes.Nome = "Felipe Fontes";
// fontes.Idade = 17;

// Console.WriteLine($"O objeto pessoa que criei è o {fontes.Nome} com a idade {fontes.Idade}");

// // fontes.Nome = "Gustavo Oliveira";
// // fontes.Nome = "Henrique";
// fontes.ExibirDados();

// Console.WriteLine($"{fontes.Nome}");

Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva, 16");

Console.WriteLine(@$"Primeira Pessoa Cadastrada:
                    Nome: {PrimeiraPessoa.Nome}
                    Idade: {PrimeiraPessoa.Idade}

");
Console.WriteLine(@$"Segunda Pessoa Cadastrada:
                    Nome: {SegundaPessoa.Nome}
                    Idade: {SegundaPessoa.Idade}

");

Console.WriteLine($"Qual o nome da terceira pessoa");
string.nome3 = Console.ReadLine();
Console.WriteLine($"Qual o idade da terceira pessoa");
int.idade3 = int.Parse(Console.ReadLine());
Console.WriteLine(@$"Terceira Pessoa Cadastrada:
                    Nome: {TerceiraPessoa.Nome}
                    Idade: {TerceiraPessoa.Idade}

");
// using System.Security.Cryptography;

// // string nome = "Stephani Dandara";


// // Hello cumprimento = new Hello();

// // cumprimento.TextoHello = "Ola usuario";

// // cumprimento.SaudarUsuario();
// // cumprimento.SaudarComNome("Stephani Dandara");

// using PrimeiraClasse;


// Carro c1 = new Carro();
// c1.marca = "Lamborghini";
// c1.marca = "Urus";
// c1.qtdPortas = 2;
// c1.qtdRodas = 4;
// c1.Ligar();
// c1.Acelerar();
// c1.Frear();
// c1.Desligar();

// Carro c2 = new Carro();
// c2.marca = "Chervrolet";
// c2.marca = "Camaro";
// c2.cor = "Amarelo";
// c2.qtdPortas = 2;
// c1.qtdRodas = 4;

// Console.WriteLine($"Ligando o {c2.modelo}");
// Console.WriteLine($"Acelerando o {c2.modelo}");
// Console.WriteLine($"Freando o {c2.modelo}");
// Console.WriteLine($"Desligando o {c2.modelo}");

// Console.WriteLine();
// Console.WriteLine($"Caracteristica");
// Console.WriteLine();


// Console.WriteLine($"------ {c1.marca} ------");
// Console.WriteLine($"Carro: {c1.marca}");
// Console.WriteLine($"Modelo: {c1.modelo}");
// Console.WriteLine($"Cor: {c1.cor}");
// Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
// Console.WriteLine();
// Console.WriteLine($"--");
// Console.WriteLine();

// Console.WriteLine($"------ {c2.marca} ------");
// Console.WriteLine($"Carro: {c2.marca}");
// Console.WriteLine($"Modelo: {c2.modelo}");
// Console.WriteLine($"Cor: {c2.cor}");
// Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
// Console.WriteLine();


// //Criar uma classe que representa uma moto 
// //pelo menos 4 propriedades
// //pelo menos 3 metodos

// Moto m1 = new Moto();
// m1.modelo = "Pop100";
// m1.marca = "Ronda";
// m1.qtdRodas = 2;
// m1.Ligar();
// m1.Acelerar();
// m1.Frear();
// m1.Desligar();

// Moto m2 = new Moto();
// m2.modelo = "Yamaha Niken GT";
// m2.marca = "Yamaha";
// m2.cor = "Azul";
// m2.qtdRodas = 3;

// Console.WriteLine($"Ligando o {m2.modelo}");
// Console.WriteLine($"Acelerando o {m2 .modelo}");
// Console.WriteLine($"Freando o {m2.modelo}");
// Console.WriteLine($"Desligando o {m2.modelo}");

// Console.WriteLine();
// Console.WriteLine($"Caracteristica");
// Console.WriteLine();


// Console.WriteLine($"------ {m1.marca} ------");
// Console.WriteLine($"Carro: {m1.marca}");
// Console.WriteLine($"Modelo: {m1.modelo}");
// Console.WriteLine($"Cor: {m1.cor}");
// Console.WriteLine();
// Console.WriteLine($"--");
// Console.WriteLine();

// Console.WriteLine($"------ {m2.marca} ------");
// Console.WriteLine($"Carro: {m2.marca}");
// Console.WriteLine($"Modelo: {m2.modelo}");
// Console.WriteLine($"Cor: {m2.cor}");
// Console.WriteLine();

//Criar uma classe para representar uma garrafa, propriedades, metodos...
using System;
    
            Garrafa g1 = new Garrafa();

            Console.WriteLine("Olá usuário! Aqui você irá personalizar sua garrafa.\n");

            Console.Write("Qual será a marca da sua garrafa? ");
            g1.marca = Console.ReadLine();

            Console.Write("Qual será o modelo da sua garrafa? ");
            g1.modelo = Console.ReadLine();

            Console.Write("Qual será a capacidade da sua garrafa (em ml)? ");
            g1.capacidade = int.Parse(Console.ReadLine());

            Console.Write("Qual será a cor da sua garrafa? ");
            g1.cor = Console.ReadLine();


            Console.WriteLine($"Marca: {g1.marca}");
            Console.WriteLine($"Modelo: {g1.modelo}");
            Console.WriteLine($"Capacidade: {g1.capacidade} ml");
            Console.WriteLine($"Cor: {g1.cor}");
            Console.WriteLine();

            g1.Abrir();
            g1.Encher();
            g1.Esvaziar();
            g1.Fechar();

            Console.WriteLine("\nProcesso concluído!");
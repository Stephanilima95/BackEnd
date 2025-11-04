// using System;
// using ClassesEObjetos;

// class Program
// {
//     static void Main()
//     {
//         ContaBancaria conta = new ContaBancaria();

//         Console.WriteLine("=== SISTEMA BANCÁRIO ===");
//         Console.Write("Digite o nome do titular da conta: ");
//         conta.Titular = Console.ReadLine();

//         Console.Write("Digite o saldo inicial: R$");
//         conta.Saldo = double.Parse(Console.ReadLine());

//         int opcao = -1;
//         do
//         {
//             Console.WriteLine("\n--- MENU ---");
//             Console.WriteLine("1 - Depositar");
//             Console.WriteLine("2 - Sacar");
//             Console.WriteLine("3 - Ver saldo");
//             Console.WriteLine("0 - Sair");
//             Console.Write("Escolha uma opção: ");
//             opcao = int.Parse(Console.ReadLine());

//             Console.WriteLine();

//             switch (opcao)
//             {
//                 case 1:
//                     conta.Depositar();
//                     break;

//                 case 2:
//                     conta.Sacar();
//                     break;

//                 case 3:
//                     Console.WriteLine($"Titular: {conta.Titular}");
//                     Console.WriteLine($"Saldo atual: R${conta.Saldo}");
//                     break;

//                 case 0:
//                     Console.WriteLine("Encerrando o sistema... Obrigado por usar nosso banco!");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida! Tente novamente.");
//                     break;
//             }

//         } while (opcao != 0);
//     }
// }


// using ClassesEObjetos;
// Console.Clear();
// Pessoa Joao = new Pessoa();

// Joao.Nome = "Joao Silva";
// Console.WriteLine($"{Joao.Nome} tem {Joao.Idade} anos");

// Joao.Envelhecer(17);
// Console.WriteLine($"{Joao.Nome} tem {Joao.Idade} anos");

// Joao.Envelhecer(-50);
// Console.WriteLine($"{Joao.Nome} tem {Joao.Idade} anos");


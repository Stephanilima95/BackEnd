// using Abstracao;
//         Animal cachorro = new Cachorro();
//         Animal gato = new Gato();
//         Animal pessoa = new Pessoa();

//         cachorro.FazerSom();
//         cachorro.Mover();

//         Console.WriteLine();

//         gato.FazerSom();
//         gato.Mover();

//     Console.WriteLine();

//         pessoa.FazerSom();
//         pessoa.Mover();

        //Classe ContaBancaria
        //Crie uma classe abstrata ContaBancaria com os métodos Depositar(double valor) e Sacar(double valor).
        //Crie duas classes: ContaBancaria e ContaPoupanca, cada uma com sua própria forma de calcular o saldo após saque (por exemplo, taxa diferente)

  using Abstracao;

// Cachorro c1 = new Cachorro();
// c1.FazerSom();
// c1.Mover();
// Gato g1 = new Gato();
// g1.FazerSom();
// g1.Mover();

ContaCorrente c1 = new ContaCorrente();
c1.Depositar(30);
c1.Sacar(15);
c1.CalcularSaldo();
ContaPoupanca p1 = new ContaPoupanca();
p1.Depositar(100);
p1.Sacar(55);
p1.CalcularSaldo();
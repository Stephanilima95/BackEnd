using System;

namespace Heranca
{
    public class Conta
    {
        public int Numero;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado com sucesso!");
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
                Console.WriteLine("Saldo insuficiente!");
            else
            {
                Saldo = valor;
                Console.WriteLine($"Saque de {valor} realizado!");
            }
        }
    }

    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            double rendimento = Saldo * 0.02;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de 2% aplicado: +{rendimento}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca conta = new ContaPoupanca() { Numero = 123 };
            conta.Depositar(1000);
            Console.WriteLine($"Saldo antes do rendimento: {conta.Saldo}");

            conta.CalcularRendimento();
            Console.WriteLine($"Saldo após rendimento: {conta.Saldo}");
        }
    }
}

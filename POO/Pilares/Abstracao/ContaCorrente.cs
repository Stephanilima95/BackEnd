namespace Abstracao
{
    public class ContaCorrente : ContaBancaria
    {
        public override void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que 0.");
                return;
            }

            Saldo += valor;
            Console.WriteLine($"Depósito realizado com sucesso! Saldo atual: {Saldo}");
        }

        public override void Sacar(float valor)
        {
            if (valor <= 0 || valor > Saldo)
            {
                Console.WriteLine("O valor do saque deve ser positivo e o saldo deve ser suficiente.");
                return;
            }

            Saldo -= valor;
            Console.WriteLine($"Saque realizado com sucesso! Saldo atual: {Saldo}");
        }

        public void CalcularSaldo()
        {
            Saldo -= 0.01f * Saldo; // 1% de rendimento
            Console.WriteLine($"Saldo atualizado com rendimento: {Saldo}");
        }
    }
}

namespace ExerciciosConstrutores
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public ContaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {Titular} | Saldo: R${Saldo:F2}");
        }
    }
}

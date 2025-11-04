namespace PrimeiraClasse
{
    public class Moto
    {

        public int qtdRodas;

        public string marca = "";

        public string modelo = "";

        public string cor = "";

        //metodos
        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando");
        }

        public void Frear()
        {
            Console.WriteLine($"Moto freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Moto Ligando");
        }

        public void Desligar()
        {
            Console.WriteLine($"Moto Desligando");
        }
    }
}

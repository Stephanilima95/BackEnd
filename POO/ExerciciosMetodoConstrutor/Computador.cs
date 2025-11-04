namespace ExerciciosConstrutores
{
    public class Computador
    {
        public string Marca { get; set; }
        public int MemoriaRam { get; set; }
        public int Armazenamento { get; set; }

        public Computador()
        {
            Marca = "Genérico";
            MemoriaRam = 8;
            Armazenamento = 256;
        }

        public Computador(string marca, int memoriaRam, int armazenamento)
        {
            Marca = marca;
            MemoriaRam = memoriaRam;
            Armazenamento = armazenamento;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Computador: {Marca} | RAM: {MemoriaRam}GB | SSD: {Armazenamento}GB");
        }
    }
}

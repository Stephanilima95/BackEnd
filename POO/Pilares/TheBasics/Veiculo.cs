using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QtdRodas;
        public virtual void Ligar()
        {
            Console.WriteLine($"Ligando Veiculo");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desigando Veiculo");
        }
    }
}
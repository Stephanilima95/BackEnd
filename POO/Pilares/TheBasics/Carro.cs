using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Carro : Veiculo
    {
        
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
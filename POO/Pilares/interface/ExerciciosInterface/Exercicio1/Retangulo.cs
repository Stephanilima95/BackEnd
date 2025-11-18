using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios1
{
    public class Retangulo : IForma
    {
        public float Altura;
        public float Largura;
        public void CalcularArea()
        {
            Console.WriteLine($"O raio do retangulo é {Largura * Altura}");
        }
    }
}
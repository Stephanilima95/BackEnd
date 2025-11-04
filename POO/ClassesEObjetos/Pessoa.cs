using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";
        public int idade = 0;

        public void Falar()
        {
            Console.WriteLine($"ola, meu nome e {Nome}");
        }

        public int Envelhecer(int _anos)
        {
        if (_anos <= 0)
        {
            Console.WriteLine($"Idade tem que ser positiva");
            return idade;
        }
    
            idade += _anos;

            return idade;
        }
    }
}
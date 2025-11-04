using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Garrafa
    {
        public string marca = "";
        public string modelo = "";
        public int capacidade = 0;
        public string cor = "";

        // Métodos
        public void Abrir()
        {
            Console.WriteLine($"A garrafa {marca} está abrindo...");
        }

        public void Encher()
        {
            Console.WriteLine($"A garrafa {marca} está enchendo...");
        }

        public void Esvaziar()
        {
            Console.WriteLine($"A garrafa {marca} está esvaziando...");
        }

        public void Fechar()
        {
            Console.WriteLine($"A garrafa {marca} está fechando...");
        }
    }
}
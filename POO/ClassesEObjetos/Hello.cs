using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Hello
    {
        //Propriedades
    public string TextoHello = "";

        //Metodos/Comportamentos/Acoes - sao as funcoes internas dessa classe
        public void SaudarUsuario()
        {
            Console.WriteLine(TextoHello);
        }    //Prpriedades e metodos aqui
    
    public void SaudarComNome(string n)
        {
            Console.WriteLine($"Ola {n}");
        }
    }
}
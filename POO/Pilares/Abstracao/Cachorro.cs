using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
public class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro faz: Au au!");
    }

    public override void Mover()
    {
        Console.WriteLine("O cachorro está correndo atrás da bola!");
    }
}}
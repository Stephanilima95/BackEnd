using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
public class Pessoa : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("A pessoa faz: oi!");
    }

    public override void Mover()
    {
        Console.WriteLine("A pessoa esta andando!");
    }
}}
using System;
using RPG_com_Orientação_a_Objeto.src.Entities;

namespace RPG_com_Orientação_a_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 42, "Knight");
            Wizard Jenica = new Wizard("Jenica", 42, "White Wizard");
            BlackWizard Topapa = new BlackWizard("Topapa", 42, "Black Wizard");
            Ninja Wedge = new Ninja("Wedge", 42, "Ninja");


            Console.WriteLine("------------------------------");
            Console.WriteLine(Arus);
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Arus.KAttack(5));
            Console.WriteLine(Arus.KAttack(10));
            Console.WriteLine("------------------------------");

            Console.WriteLine(Jenica);
            Console.WriteLine(Jenica.Attack());
            Console.WriteLine(Jenica.WAttack(3));
            Console.WriteLine(Jenica.WAttack(9));
            Console.WriteLine("------------------------------");

            Console.WriteLine(Topapa);
            Console.WriteLine(Topapa.Attack());
            Console.WriteLine(Topapa.BWAttack(1));
            Console.WriteLine(Topapa.BWAttack(8));
            Console.WriteLine("------------------------------");

            Console.WriteLine(Wedge);
            Console.WriteLine(Wedge.Attack());
            Console.WriteLine(Wedge.NAttack(2));
            Console.WriteLine(Wedge.NAttack(11));
            Console.WriteLine("------------------------------");
        }
    }
}

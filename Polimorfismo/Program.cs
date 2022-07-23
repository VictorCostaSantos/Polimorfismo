using System;
using Polimorfismo.pets;

namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var luck = new cachorro("luck", 5, "cachorro", "caramelo");
            var Mel = new gato("Mel", 2, "Gato", "Laranja");
            var brayan = new Passarinho("brayan",2,"Passarinho","Azul");

            Console.WriteLine("Seja bem vindo ao pet");

            Console.WriteLine(luck.ToString());
            luck.Comer();
            luck.Som();
            Console.WriteLine();


            Console.WriteLine(Mel.ToString());
            Mel.Dormir();
            Console.WriteLine();


            Console.WriteLine(brayan.ToString());
            brayan.Dormir();
            Console.WriteLine();

        }
    }
}

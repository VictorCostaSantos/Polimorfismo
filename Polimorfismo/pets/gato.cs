using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.pets
{
    class gato : DadosSobrePet
    {
        public gato(string nome, int idade, string especie,string cor) :base(nome,idade,especie,cor)
        {

        }


        public override void Comer()
        {
            Console.WriteLine($"eu estou comendo");
        }

        public override void Dormir()
        {
            base.Dormir();
        }

        public void Som()
        {
            Console.WriteLine("Miau...Miau...");
        }
    }
}

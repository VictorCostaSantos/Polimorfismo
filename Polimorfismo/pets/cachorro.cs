using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.pets
{
    public class cachorro: DadosSobrePet
    {
        public cachorro(string nome, int idade, string especie, string cor) : base(nome, idade, especie, cor)
        {

        }


        public override void Comer()
        {
            Console.WriteLine($"eu estou mordendo um osso");
        }

        public override void Dormir()
        {
            base.Dormir();
        }

        public void Som()
        {
            Console.WriteLine("au...au...");
        }
    }
}

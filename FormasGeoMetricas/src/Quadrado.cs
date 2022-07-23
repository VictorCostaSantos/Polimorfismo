using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeoMetricas.src
{
    internal class Quadrado : Dimensao
    {
        public Quadrado(double abase, double altura) : base(abase, altura)
        {

        }

        public override double Areatotal()
        {
            double area = Base * Altura;
            return area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeoMetricas.src
{
    internal class Retangulo : Dimensao
    {
        public Retangulo(double abase, double altura) : base(abase, altura)
        {

        }

        public override double Areatotal()
        {
            double area = Base * Altura;
            return area;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeoMetricas.src
{
    
        public abstract class Dimensao
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public Dimensao(double abase, double altura)
            {

                Base = abase;
                Altura = altura;
            }
            public abstract double Areatotal();
        }
}

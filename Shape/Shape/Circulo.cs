using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circulo: Figura
    {
        public double radio;
        public Circulo(double Alto, double Ancho, double radio): base(Alto, Ancho)
        {

            radio = Alto + Ancho;
        }
    }
}

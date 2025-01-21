using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circulo: Figura
    {
        public Circulo(double Alto, double Ancho): base(Alto, Ancho)
        {

            _radio = Alto + Ancho;
        }
    }
}

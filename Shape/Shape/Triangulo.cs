using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Triangulo : Figura
    {
        public Triangulo(double Alto, double Ancho) : base(Alto, Ancho)
        {

            Ancho = ancho;
            Alto = alto;
        }
        public override double CalculateSurface()
        {
            return alto * ancho / 2;
        }
    }
}

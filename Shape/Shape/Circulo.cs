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
        public Circulo(double Alto, double Ancho, double Radio): base(Alto, Ancho)
        {

            radio = Radio;
        }
        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}

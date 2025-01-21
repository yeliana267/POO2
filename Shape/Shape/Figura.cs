using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Figura
    {
        public double ancho;
        public double alto;
        public Figura(double Ancho, double Alto)
        {
            this.ancho = Ancho;
            this.alto = Alto;
        }

        public abstract double CalculateSurface();

    }
}


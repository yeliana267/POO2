using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela2._0
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly Fecha { get; set; }

        public Persona(string nombre, string apellido, DateOnly fecha)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha = fecha;
        }

    }
}

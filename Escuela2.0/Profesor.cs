using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela2._0
{
    internal class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; }
        public Profesor(string nombre, string apellido, DateOnly fecha)
            : base(nombre, apellido, fecha)
        {

            Cursos = new List<Curso>();

        }
    }
}

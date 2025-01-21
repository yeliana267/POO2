using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela2._0
{
    internal class Clase
    {
        public string Id { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }

        public Clase()
        {
            Estudiantes = new List<Estudiante>();
            Profesores = new List<Profesor>();
        }
    }
}

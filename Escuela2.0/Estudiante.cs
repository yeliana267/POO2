using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela2._0
{
    internal class Estudiante: Persona
    {
        private int Id { get; set; }
        public Estudiante(string nombre, string apellido, DateOnly fecha, int id)
           : base(nombre, apellido, fecha)
        { Id = id; }
        public int id
        {
            get
            {
                return Id;
            }
            set { Id = value; }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    abstract class Empleado
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        private string seguroSocial { get; set; }

        public Empleado(string Nombre, string Apellidos, string SeguroSocial)
        {

            this.nombre = Nombre;
            this.apellidos = Apellidos;
            this.seguroSocial = SeguroSocial;
        }
        public string SeguroSocial
        {
            get
            {
                return seguroSocial;
            }
            set
            { SeguroSocial = value; }
        }
        public abstract decimal CalcularSueldo();
    }



}


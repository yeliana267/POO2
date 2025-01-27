using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class Empleado_Admin : Empleado
    {
        public decimal sueldoBase = 35000;
        public bool metas { get; set; }
        public Empleado_Admin(string Nombre, string Apellidos, string SeguroSocial, bool Metas) : base(Nombre, Apellidos, SeguroSocial)
        {
            this.metas = Metas;
        }
        public override decimal CalcularSueldo()
        {
            if (metas)
            {

                decimal bono = sueldoBase * 5 / 100;
                decimal Sueldo = sueldoBase + bono;
                return Sueldo;
            }
            else { return sueldoBase / 2; }
        }
    }
}


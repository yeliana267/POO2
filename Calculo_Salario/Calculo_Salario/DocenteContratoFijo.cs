using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class DocenteContratoFijo : Empleado
    {
        public decimal sueldoBase { get; set; }
        public bool metas { get; set; }
        public DocenteContratoFijo(string Nombre, string Apellidos, string SeguroSocial,decimal SueldoBase, bool Metas) : base(Nombre, Apellidos, SeguroSocial)
        {
            this.sueldoBase = SueldoBase;
            this.metas = Metas;
        }
        public override decimal CalcularSueldo()
        {
            if (metas == true)
            {

                decimal bono = sueldoBase * 10 / 100;
                decimal Sueldo = sueldoBase + bono;
                return Sueldo;
            }
            else { return sueldoBase / 2; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class DocenteContratoFijo : Empleado
    {
        public decimal SueldoBase = 45000;

        public DocenteContratoFijo(string Nombre, string Apellidos, string SeguroSocial) : base(Nombre, Apellidos, SeguroSocial)
        {
        }
        public override decimal CalcularSueldo(bool metas)
        {
            if (metas == true) {

                decimal bono = SueldoBase * 10/100;
                decimal Sueldo = SueldoBase + bono;
                return Sueldo;
            }
            else { return SueldoBase / 2; }
        }
    }
}

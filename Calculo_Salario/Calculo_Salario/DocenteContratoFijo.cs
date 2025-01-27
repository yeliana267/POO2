using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class DocenteContratoFijo : Empleado
    {
        public bool metas { get; set; }
        public DocenteContratoFijo(string Nombre, string Apellidos, string SeguroSocial, bool Metas) : base(Nombre, Apellidos, SeguroSocial)
        {
            this.metas = Metas;
        }
        public override decimal CalcularSueldo(decimal SueldoBase)
        {
            if (metas == true)
            {

                decimal bono = SueldoBase * 10 / 100;
                decimal Sueldo = SueldoBase + bono;
                return Sueldo;
            }
            else { return SueldoBase / 2; }
        }
    }
}

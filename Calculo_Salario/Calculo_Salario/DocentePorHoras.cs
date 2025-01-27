using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class DocentePorHoras : Empleado

    { private decimal sueldoPorHoras = 800;

        public int HorasTrabajadas { get; set; }
        public DocentePorHoras(string Nombre, string Apellidos, string SeguroSocial):base(Nombre,Apellidos,SeguroSocial) { 
        }
        public override decimal CalcularSueldo(bool metas)
        {
            decimal Sueldo =  sueldoPorHoras * HorasTrabajadas;
            return Sueldo;
            
        }

    }

}

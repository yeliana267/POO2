using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class DocentePorHoras : Empleado

    {
        public int horasTrabajadas { get; set; }
        public decimal tarifaHoras = 800;
        public DocentePorHoras(string Nombre, string Apellidos, string SeguroSocial, int HorasTrabajadas) : base(Nombre, Apellidos, SeguroSocial)
        {
            this.horasTrabajadas = HorasTrabajadas;
        }
        public override decimal CalcularSueldo()
        {

            decimal Sueldo = tarifaHoras * horasTrabajadas;
            return Sueldo;

        }

    }

}

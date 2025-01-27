﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Salario
{
    internal class Empleado_Admin : Empleado    
    {
        public decimal SueldoBase = 30000;
        public Empleado_Admin(string Nombre, string Apellidos, string SeguroSocial) : base(Nombre, Apellidos, SeguroSocial)
        {
        }
        public override decimal CalcularSueldo(bool metas)
        {
            if (metas == true)
            {

                decimal bono = SueldoBase * 5 / 100;
                decimal Sueldo = SueldoBase + bono;
                return Sueldo;
            }
            else { return SueldoBase / 2; }
        }
    }
    }


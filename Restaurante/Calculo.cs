using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
       public class Calculo
    {
        private decimal[] Precios;
        private decimal Propina;
        public Calculo(decimal[] Precios, decimal? Propina = null)
        {
            this.Precios = Precios;
            this.Propina = Propina ?? 0.10m;
        }
        
        public decimal Factura()
        {
            decimal subtotal = Precios.Sum();
            decimal totalConPropina = subtotal + (subtotal * Propina);
            return totalConPropina;
        }
       
        

    }
}

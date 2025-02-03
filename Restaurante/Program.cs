using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese los precios de los platos (separados por comas): ");
            string entradaPrecios = Console.ReadLine();

            decimal[] precios = entradaPrecios
                .Split(',')
                .Select(p => decimal.TryParse(p, out decimal valor) ? valor : 0)
                .ToArray();

            Console.Write("¿Desea agregar una propina personalizada? (s/n): ");
            string respuestaPropina = Console.ReadLine();

            decimal? propina = null;
            if (respuestaPropina?.ToLower() == "s")
            {
                Console.Write("Ingrese el porcentaje de propina: ");
                propina = decimal.TryParse(Console.ReadLine(), out decimal porcentaje) ? porcentaje / 100 : (decimal?)null;
            }

            Calculo calculo = new Calculo(precios, propina);


            decimal total = calculo.Factura();

            Console.WriteLine($"Total a pagar: {total}");
        }
    }
}

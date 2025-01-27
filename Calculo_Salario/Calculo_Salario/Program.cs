using System;
using System.Runtime.CompilerServices;
namespace Calculo_Salario
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            DocenteContratoFijo Alvely = new DocenteContratoFijo("Alvely", "Perez", "SS12345",false);
            Console.WriteLine($"{Alvely.nombre} {Alvely.apellidos} de seguro social: {Alvely.SeguroSocial} a ganado {Alvely.CalcularSueldo(30000)}");

            DocentePorHoras yeliana = new DocentePorHoras("Yeliana", "Diaz", "SS67890", 60);
            Console.WriteLine($"{yeliana.nombre} {yeliana.apellidos} de seguro social: {yeliana.SeguroSocial} a ganado {yeliana.CalcularSueldo()}");

            Empleado_Admin juana = new  Empleado_Admin("Juana", "Paredes", "SS12567", true);
            Console.WriteLine($"{juana.nombre} {juana.apellidos} de seguro social: {juana.SeguroSocial} a ganado {juana.CalcularSueldo(50000)}");

            Console.ReadLine();
        }
    }
}
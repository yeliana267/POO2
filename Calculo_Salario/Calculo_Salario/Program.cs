using System;
using System.Runtime.CompilerServices;
namespace Calculo_Salario
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            DocenteContratoFijo docenteFijo = new DocenteContratoFijo("Juan", "Perez", "SS12345");
            DocentePorHoras docentePorHoras = new DocentePorHoras("Maria", "Gomez", "SS67890") { HorasTrabajadas = 40 };
            DocentePorHoras yeliana = new DocentePorHoras("Yeliana", "Bencosme", "SS678934") { HorasTrabajadas = 80 };

            Empleado_Admin administrativo = new Empleado_Admin("Carlos", "Lopez", "SS11223");

            Console.WriteLine("Salario Docente Fijo con metas alcanzadas: " + docenteFijo.nombre + " " + docenteFijo.apellidos + " " + docenteFijo.SeguroSocial + " " + docenteFijo.CalcularSueldo(true));
            Console.WriteLine($"{yeliana.nombre} { yeliana.apellidos} de seguro social: {yeliana.SeguroSocial} a ganado {yeliana.CalcularSueldo(true)}");


            Console.ReadLine();
        }
    }
}
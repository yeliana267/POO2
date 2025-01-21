using System;
using System.Net.Security;

namespace Escuela2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            DateOnly fecha = new DateOnly(2025, 01, 12);

            Estudiante estudiante1 = new Estudiante("Juan", "Ramirez", fecha, 1);
            Estudiante estudiante2 = new Estudiante("Juan", "Pedro", fecha, 2);

            Curso cursoM = new Curso { Nombre = "Matemáticas", Recuento = 10, Ejercicio = 50 };

            Profesor pro1 = new Profesor("MARIA", "Pedro", fecha);

            Clase claseA = new Clase { Id = "Clase A" };

            pro1.Cursos.Add(cursoM);
            claseA.Estudiantes.Add(estudiante1);
            claseA.Estudiantes.Add(estudiante2);
            claseA.Profesores.Add(pro1);

            Console.WriteLine($"Información de la {claseA.Id}:");
            Console.WriteLine("Estudiantes:");

            foreach (var estudiante in claseA.Estudiantes)
            {
                Console.WriteLine($"- {estudiante.Nombre} (N° {estudiante.id})");
            }

            Console.WriteLine("\nProfesores:");
            foreach (var profesor in claseA.Profesores)
            {
                Console.WriteLine($"- {profesor.Nombre}");
                foreach (var curso in profesor.Cursos)
                {
                    Console.WriteLine($"  Imparte: {curso.Nombre} ({curso.Recuento} clases, {curso.Ejercicio} ejercicios)");
                }
            }
        }
    }
}

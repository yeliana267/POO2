using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();

            Console.WriteLine("Seleccione el tipo de empleado (1: Tiempo completo, 2: Medio tiempo): ");
            string employeeType = Console.ReadLine();

            if (employeeType == "1")
            {
                Console.Write("Ingrese el salario base: ");
                decimal baseSalary = decimal.Parse(Console.ReadLine());
                decimal netSalary = payroll.CalculateSalaryForFullTime(baseSalary);
                Console.WriteLine($"Salario neto después de impuestos y bono: {netSalary}");
            }
            else if (employeeType == "2")
            {
                Console.Write("Ingrese el sueldo por hora: ");
                decimal hourlyRate = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese las horas trabajadas: ");
                int hoursWorked = int.Parse(Console.ReadLine());

                decimal netSalary = payroll.CalculateSalaryForPartTime(hourlyRate, hoursWorked);
                Console.WriteLine($"Salario neto después de impuestos y bono: {netSalary}");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
    }
    }

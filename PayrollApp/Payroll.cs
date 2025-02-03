using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    public class Payroll
    {
        private const decimal TaxRate = 0.18m;
        private const decimal BonusRate = 0.05m;

        private decimal CalculateNetSalary(decimal grossSalary)
        {
            decimal tax = grossSalary * TaxRate;
            decimal bonus = grossSalary * BonusRate;
            return grossSalary - tax + bonus;
        }

        public decimal CalculateSalaryForFullTime(decimal baseSalary)
        {
            return CalculateNetSalary(baseSalary);
        }

        public decimal CalculateSalaryForPartTime(decimal hourlyRate, int hoursWorked)
        {
            decimal grossSalary = hourlyRate * hoursWorked;
            return CalculateNetSalary(grossSalary);
        }
    }
}

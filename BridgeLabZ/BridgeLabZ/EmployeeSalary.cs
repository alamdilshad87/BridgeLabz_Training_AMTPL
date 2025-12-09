using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    public class EmployeeSalary
    {
        public decimal CalcMonthlySalary(decimal dailyWage, int working)
        {
            if (dailyWage <= 0 || working <= 0)
                throw new ArgumentException("Salary inputs cannot be zero nor Working Days");
            return dailyWage * working;
        }

        public decimal CalcAnnualSalary(decimal monthlySalary)
        {
            if (monthlySalary <= 0)
                throw new ArgumentException("Monthly Salary > than 0");
            return monthlySalary * 12;
        }

        public decimal ApplyBonus(decimal salary, int bonus)
        {
            if (salary <= 0 || bonus < 0)
                throw new ArgumentException("Invalid Bonus");
            return salary + (salary * bonus / 100);
        }
    }
}
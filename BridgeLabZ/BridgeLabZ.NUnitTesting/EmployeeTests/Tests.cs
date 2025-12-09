using NUnit.Framework;
namespace BridgeLabZ.NUnitTesting.EmployeeTests
{
    public class Tests
    {
        private EmployeeSalary service;
        [SetUp]
        public void Setup()
        {
            service = new EmployeeSalary();
        }


        [TestCase(500,30,15000)]
        [TestCase(1000,22,22000)]
        [TestCase(750,26,19500)]
        public void CalcMonthlySalary_Valid(decimal wage, int days, decimal expected)
        {
            Assert.That(service.CalcMonthlySalary(wage, days), Is.EqualTo(expected));
        }


        [TestCase(-500,25)]
        [TestCase(500,-5)]
        public void CalcMonthlySalary_InValid(decimal wage, int days)
        {
            Assert.Throws<ArgumentException>(() => service.CalcMonthlySalary(wage, days));
        }


        [TestCase(30000,10,33000)]
        [TestCase(50000,20,60000)]
        [TestCase(45000,0,45000)]
        public void Bonus_Valid(decimal salary, int bonus, decimal expected)
        {
            Assert.That(service.ApplyBonus(salary, bonus), Is.EqualTo(expected));
        }


        [TestCase(0,10)]
        [TestCase(-30000,5)]
        [TestCase(30000,-10)]
        public void Bonus_InValid(decimal salary, int bonus)
        {
            Assert.Throws<ArgumentException>(() => service.ApplyBonus(salary, bonus));
        }




    }
}

using NUnit.Framework;

namespace BridgeLabZ.NUnitTesting.CalculatorTests
{
    public class AddTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_ReturnsCorrectSum()
        {
            int result = calc.Add(10, 20);

            Assert.That(result, Is.EqualTo(30));
        }
    }
}

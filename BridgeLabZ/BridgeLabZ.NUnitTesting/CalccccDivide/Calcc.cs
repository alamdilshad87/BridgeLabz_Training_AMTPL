using NUnit.Framework;

namespace BridgeLabZ.NUnitTesting.CalculatorTests
{
    [TestFixture]
    public class Calcc
    {
        private Calcccc calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calcccc();
        }

        [Test]
        public void Div()
        {
            int result = calc.Divide1(20, 10);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}

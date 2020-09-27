using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(calculator.Calculate("3 + 5"), 8);
            Assert.AreEqual(calculator.Calculate("3 - 5"), -2);
            Assert.AreEqual(calculator.Calculate("3 * 5"), 15);
            Assert.AreEqual(calculator.Calculate("4 / 2"), 2);

        }
    }
}
using System;
using NUnit.Framework;


namespace Calculator.Tests
{

    public class CalculatorTest
    {

        public void T()
        {
            double s = 1.0;
            Assert.AreEqual(calculator.Calculate("3 + 5"), 8);
            Assert.AreEqual(calculator.Calculate("3 - 5"), -2);
            Assert.AreEqual(calculator.Calculate("3 * 5"), 15);
            Assert.AreEqual(calculator.Calculate("4 / 2"), 2);
           

        }
    }
}
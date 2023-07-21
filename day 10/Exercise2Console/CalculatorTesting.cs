using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Console
{
    [TestFixture]
    internal class CalculatorTesting
    {

        [Test]
        public void AddTest()
        {
            Calculator calculator = new Calculator();



            Assert.AreEqual(7, calculator.Add(3, 4));
        }
        [Test]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(9, calculator.Subtract(13, 4));
        }

        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(12, calculator.Multiply(3, 4));
        }

        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(3, calculator.Divide(12, 4));
        }
    }
}

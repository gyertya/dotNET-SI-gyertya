using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        ICalculator cal;

        [SetUp]
        public void TestSetup()
        {
            cal = new Calculator();
        }

        [Test]
        public void ShouldAddTwoNumbers()
        {
            var expected = cal.Add(7, 8);
            Assert.That(expected, Is.EqualTo(15));
        }

        [Test]
        [Ignore("dd")]
        public void ShouldMulTwoNumbers()
        {
            var expected = cal.Mul(10, 2);
            Assert.That(expected, Is.EqualTo(8));
        }

        [TearDown]
        public void TestTearDown()
        {
            cal = null;
        }
    }
}

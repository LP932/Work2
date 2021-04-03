using Microsoft.VisualStudio.TestTools.UnitTesting;
using P_work_2;
using System;

namespace SecondMathArea
{
    [TestClass]
    public class Class2Test
    {
        [TestMethod]
        public void MultiplicationMath_8and12()
        {
            // Значення які будуть передані в метод
            int a = 8;
            int b = 12;
            //очікуваний результат
            int expected = 96;
            MultiplecationAndDivision g = new MultiplecationAndDivision();
            int actual = g.MultiplicationMath(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivisionMath_8and4()
        {
            // Значення які будуть передані в метод
            double a = 8;
            double b = 4;
            //очікуваний результат
            double expected = 2;
            MultiplecationAndDivision g = new MultiplecationAndDivision();
            double actual = g.DivisionMath(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}

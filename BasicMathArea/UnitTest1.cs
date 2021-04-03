using System;
using Xunit;
using System.IO;
using P_work_2;

namespace BasicMathArea
{
    public class UnitTest1
    {
        [Fact]
        public void PlusMath_3and5()
        {
            // Значення які будуть передані в метод
            int a = 3;
            int b = 5;
            //очікуваний результат
            int expected = 8;
            PlusAndDecuction g = new PlusAndDecuction();
            int actual = g.PlusMath(a, b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DeductionMath_3and5()
        {
            // Значення які будуть передані в метод
            int a = 3;
            int b = 5;
            //очікуваний результат
            int expected = -2;
            PlusAndDecuction g = new PlusAndDecuction();
            int actual = g.DeductionMath(a, b);
            Assert.Equal(expected, actual);
        }
    }
}

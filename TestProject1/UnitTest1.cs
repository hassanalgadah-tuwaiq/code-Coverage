using System;
using CodeCoverage;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Add()
        {
            Calculeter c = new Calculeter();
            Assert.Equal(3, c.add(1, 2));
        }

        // [Fact]
        // public void Test_Add_With_Zero()
        // {
        //     Calculeter c = new Calculeter();
        //     Assert.Equal(2, c.add(0, 2));
        // }
        //
        // [Fact]
        // public void Test_Div()
        // {
        //     Calculeter c = new Calculeter();
        //     Assert.Equal(1, c.division(2, 2));
        // }
        // //
        // [Fact]
        // public void Test_Div_With_Zero()
        // {
        //     Calculeter c = new Calculeter();
        //     Assert.Throws<DivideByZeroException>(() => c.division(5, 0));
        // }
    }
}
using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {   
        //Created an object of the RecursiveCalc class
        RecursiveCalc rc = new RecursiveCalc();

        //Testing FactorialRec (Fact)

        [Fact]
        public void FactTestingFactorialRec()
        {
            int input = 3;
            int ans = 3;

            Assert.Equal(18, rc.FactorialRec(input,ans));

        }

        //Testing FactorialRec (Theory)

        [Theory]
        [InlineData(18,3,3)]
        [InlineData(80640,8,2)]
        [InlineData(720,6,1)]

        public void TheoryTestingFactorialRec(int expected, int input, int ans)
        {
            Assert.Equal(expected, rc.FactorialRec(input,ans));
        }

        
        //Testing FibCheck (Fact)

        [Fact]
        public void FactTestingFibCheck()
        {
            int num = 3;

            Assert.True(rc.FibCheck(num));

            int num1 = 4;

            Assert.False(rc.FibCheck(num1));
        }

        //Testing FactorialRec (Theory) - TRUE

        [Theory]
        [InlineData(3)]
        [InlineData(8)]

        public void TheoryTestingFibCheckTrue(int num)
        {
            Assert.True(rc.FibCheck(num));
        }

        //Testing FactorialRec (Theory) - FALSE

        [Theory]
        [InlineData(false,4)]
        [InlineData(false,7)]

        public void TheoryTestingFibCheckFalse(bool expected, int num)
        {
            Assert.Equal(expected, rc.FibCheck(num));
        }

        //Testing FibonnacciRec (Fact)

        [Fact]
        public void FactTestFibonacciRec()
        {
            int num1 = 2;
            int num2 = 4;
            int numFibs = 2;

            Assert.Equal(34, rc.FibonacciRec(num1,num2,numFibs));
        }
        
        
        //Testing PrimeCheckRec (Fact)

        [Fact]

        public void FactTestPrimeCheckRec()
        {
            int num = 3;
            int devisor = 2;

            Assert.True(rc.PrimeCheckRec(num, devisor));
        }
        
        //Testing PrimeCheckRec (Theory)

        [Theory]
        [InlineData(false,4,1)]

         public void TheoryTestPrimeCheckRec(bool expected, int num, int devisor)
        {
            Assert.Equal(expected,rc.PrimeCheckRec(num, devisor));
        }


        //Testing PrimeCheckRec - DivideByZero Exception

        [Fact]

         public void DevideByZeroCheck()
        {
            Assert.Throws<DivideByZeroException>(() => rc.PrimeCheckRec(11,0)); 
        }

    }
}

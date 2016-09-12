using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[] { };
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers = new int[5];
            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            
                Assert.AreEqual(40, Calculator.Multiply(10, 4));
                Assert.AreEqual(-40, Calculator.Multiply(10, -4));
                Assert.AreEqual(0, Calculator.Multiply(0, 0));
                Assert.AreEqual(0, Calculator.Multiply(10, 0));
            //It multiplies two numbers
            //It multiplies several numbers
        }
        [TestMethod]
        public void Power()
        {
            //It raises one number to the power of another number
            
                Assert.AreEqual(10000, Calculator.Power(10,4));
                Assert.AreEqual(16807, Calculator.Power(7, 5));
                Assert.AreEqual(1, Calculator.Power(7, 0));
                Assert.AreEqual(0, Calculator.Power(0, 3));
                Assert.AreEqual(-8, Calculator.Power(-2, 3));

        }
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
            Assert.AreEqual(1, Calculator.Factorial(1));
            Assert.AreEqual(2, Calculator.Factorial(2));
            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(3628800, Calculator.Factorial(10));
            Assert.AreEqual(39916800, Calculator.Factorial(11));
            Assert.AreEqual(479001600, Calculator.Factorial(12));
            Assert.AreEqual(6227020800, Calculator.Factorial(13));

            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            //  it "computes the factorial of 1"
            //  it "computes the factorial of 2"
            //  it "computes the factorial of 5"
            //  it "computes the factorial of 10"
        }
}
}

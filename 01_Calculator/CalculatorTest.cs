﻿using System;
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
            int[] numbers = new int[2];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(4, Calculator.Multiply(2, 2));
        }
        [TestMethod]
        public void Power()
        {   
            Assert.AreEqual(16, Calculator.Power(2, 4));
        }
        [TestMethod]
        public void Factorial()
        {
            //# http://en.wikipedia.org/wiki/Factorial

            Assert.AreEqual(24, Calculator.Factorial(4));
            Assert.AreEqual(5040, Calculator.Factorial(7));
            Assert.AreEqual(3628800, Calculator.Factorial(10));
        }

        public void divide()

        {
            Assert.AreEqual(10, Calculator.Divide(70, 7));
            Assert.AreEqual(13, Calculator.Divide(169, 13));
            Assert.AreEqual(4, Calculator.Divide(28, 7));
        }
    }
}

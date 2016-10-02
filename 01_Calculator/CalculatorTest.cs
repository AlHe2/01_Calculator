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
            Assert.AreEqual(0, Calculator.Multiply(0, 0));
            Assert.AreEqual(0, Calculator.Multiply(2, 0));
            Assert.AreEqual(6, Calculator.Multiply(2, 3));
            Assert.AreEqual(-6, Calculator.Multiply(-2, 3));

            int[] numbers;
            numbers= new int[2];
            numbers[0] = 4;
            numbers[1] = 7;
            Assert.AreEqual(28, Calculator.Multiply(numbers));

            numbers = new int[3];
            numbers[0] = 4;
            numbers[1] = 7;
            numbers[2] = 11;
            Assert.AreEqual(308, Calculator.Multiply(numbers));
        }
        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(1, Calculator.Power(0, 0));
            Assert.AreEqual(1, Calculator.Power(1, 0));
            Assert.AreEqual(8, Calculator.Power(2, 3));
            Assert.AreEqual(256, Calculator.Power(4, 4));
        }
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
            Assert.AreEqual(1, Calculator.Factorial(1));
            Assert.AreEqual(2, Calculator.Factorial(2));
            Assert.AreEqual(120, Calculator.Factorial(5));
            Assert.AreEqual(3628800, Calculator.Factorial(10));
        }
    }
}

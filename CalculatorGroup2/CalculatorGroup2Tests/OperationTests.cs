﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorGroup2;

namespace Operation.Tests
{
    [TestClass()]
    public class OperationTests
    {
        [TestMethod()]
        public void TestAddition1()
        {
            float a = -10, b = 20;
            float result = BinaryOperation.addition.Perform(a, b);

            Assert.AreEqual(10, result);
        }

        [TestMethod()]
        public void TestAddition2()
        {
            float a = 0, b = 20;
            float result = BinaryOperation.addition.Perform(a, b);

            Assert.AreNotEqual(10, result);
        }

        [TestMethod]
        public void TestSubstraction1()
        {
            float a = 20, b = -10;
            float result = BinaryOperation.substraction.Perform(a, b);

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void TestSubstraction2()
        {
            float a = 20, b = 0;
            float result = BinaryOperation.substraction.Perform(a, b);

            Assert.AreNotEqual(10, result);
        }
        [TestMethod]
        public void TestMultiplication1()
        {
            float a = -2, b = -3;
            float result = BinaryOperation.multiplication.Perform(a, b);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiplication2()
        {
            float a = 2, b = 0;
            float result = BinaryOperation.multiplication.Perform(a, b);

            Assert.AreNotEqual(2, result);
        }

        [TestMethod]
        public void TestDivision1()
        {
            float a = 10, b = 2;
            float result = BinaryOperation.division.Perform(a, b);
     
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void TestDivision2()
        {
            float a = 1, b = 2;
            float result = BinaryOperation.division.Perform(a, b);

            Assert.AreNotEqual(0, result);
        }


    }
}

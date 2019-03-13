using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorGroup2;

namespace Operation.Tests
{
    [TestClass()]
    public class OperationTests
    {
        [TestMethod()]
        public void TestAddition()
        {
            float a = -10, b = 20;
            float result = Operation.OperationAddition.PerformAddition(a, b);

            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void TestSubstraction()
        {
            float a = 20, b = -10;
            float result = Operation.OperationSubstraction.PerformSubstraction(a, b);

            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            float a = -2, b = -3;
            float result = Operation.OperationMultiplication.PerformationMultiplication(a, b);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            float a = 10, b = 2;
            float result = Operation.OperationDivision.PerformationDivision(a, b);
     
            Assert.AreEqual(5, result);
        }
    }
}

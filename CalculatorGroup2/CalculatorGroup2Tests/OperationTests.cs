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
            // arrange
            float a = 5, b = 2;
            float expected = 7;
            // act 
            float actual = Operation.OperationAddition.PerformAddition(a, b);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

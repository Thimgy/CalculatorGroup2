using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorGroup2;

namespace CalculatorGroup2Tests
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void TestAddition()
        {
            float a = 5, b = 2;
            float result = Operation.OperationAddition.PerformAddition(a, b);

            Assert.AreEqual(7, result);
        }
    }
}

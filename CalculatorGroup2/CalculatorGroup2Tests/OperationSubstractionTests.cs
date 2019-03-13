using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation.Tests
{
    [TestClass()]
    public class OperationSubstractionTests
    {
        [TestMethod()]
        public void PerformSubstractionTest()
        {
            // arrange
            float a = 5, b = 2;
            float expected = 3;
            // act 
            float actual = Operation.OperationSubstraction.PerformSubstraction(a, b);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
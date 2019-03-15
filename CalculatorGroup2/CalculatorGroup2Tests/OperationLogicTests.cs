using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorGroup2;

namespace Tests
{
    [TestClass()]
    public class OperationLogicTests
    {
        [TestMethod()]
        public void TestAddition()
        {
            string input = "5 + 3";
            OperationLogic logic = new OperationLogic();
            string expected = "8";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestSubstraction()
        {
            string input = "5 - 3";
            OperationLogic logic = new OperationLogic();
            string expected = "2";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMultiplication()
        {
            string input = "5 X 3";
            OperationLogic logic = new OperationLogic();
            string expected = "15";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestDivision()
        {
            string input = "9 / 3";
            OperationLogic logic = new OperationLogic();
            string expected = "3";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestCombination1()
        {
            string input = "9 + 3 X 2";
            OperationLogic logic = new OperationLogic();
            string expected = "15";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestCombination2()
        {
            string input = "9 X 3 + 2";
            OperationLogic logic = new OperationLogic();
            string expected = "29";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestCombination3()
        {
            string input = "9 + 3 X 2 - 3 / 6";
            OperationLogic logic = new OperationLogic();
            string expected = "14.5";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestCombination4()
        {
            string input = "9 / 3 + 6 - 1 X 0";
            OperationLogic logic = new OperationLogic();
            string expected = "9";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestCombination5()
        {
            string input = "0 / 4 + 1564 - 74 + 10 / 5";
            OperationLogic logic = new OperationLogic();
            string expected = "1492";

            string actual = logic.PerformOperation(input);

            Assert.AreEqual(expected, actual);
        }

    }
}
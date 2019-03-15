using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputParsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputParsing.Tests
{
    [TestClass()]
    public class ExpressionTests
    {
        [TestMethod()]
        public void SimpleParsing()
        {
            string raw_input = "1 + 5";
            var expr = new Expression(raw_input);
            string expect = "(1 + 5)";

            string actual = expr.Debug();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void NeastedParsing()
        {
            string raw_input = "(1.) + (.5)";
            var expr = new Expression(raw_input);
            string expect = "((1) + (0.5))";

            string actual = expr.Debug();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void MixedParsing()
        {
            string raw_input = "1 + 2 / 4";
            var expr = new Expression(raw_input);
            string expect = "(1 + 2 / 4)";

            string actual = expr.Debug();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void EvalTest()
        {
            string raw_input = "1 + 2 / 4";
            var expr = new Expression(raw_input);
            float expect = 3;

            float actual = expr.ComputeValue();

            Assert.AreEqual(expect, actual);
        }
    }
}
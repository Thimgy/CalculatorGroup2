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
            string raw_input = "(1) + (5)";
            var expr = new Expression(raw_input);
            string expect = "((1) + (5))";

            string actual = expr.Debug();

            Assert.AreEqual(expect, actual);
        }
    }
}
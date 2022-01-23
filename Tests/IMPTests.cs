using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    class IMPTests
    {
        [TestMethod]
        [DataRow("1+1", 1 + 1)]
        [DataRow("1 + 1", 1 + 1)]
        [DataRow("  1+     1  ", 1 + 1)]
        [DataRow("1*1", 1 * 1)]
        [DataRow("1 + 2 * 2 ", 1 + 2 * 2)]
        [DataRow("(1+1)*2", (1 + 1) * 2)]
        [DataRow("2*(1+1)", 2 * (1 + 1))]
        [DataRow("1/1", 1 / 1)]
        [DataRow("3/1", 3 / 1)]
        [DataRow("9/10", 9.0f / 10)]

        [DataRow("1-1", 1 - 1)]
        [DataRow("7-1", 7 - 1)]
        [DataRow("10-3", 10 - 3)]
        [DataRow("-10-3", -10 - 3)]
        [DataRow("-10+3", -10 + 3)]

        public void Predefined(string stringToParse, float expectedResult)
        {
            var result = Try_Antlr.parseIMP(stringToParse);
            Assert.AreEqual(expectedResult, result);
        }
    }
}

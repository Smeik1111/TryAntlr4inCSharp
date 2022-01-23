using Antlr4.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ParsingTest
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
            var result = parseBasicMath(stringToParse);
            Assert.AreEqual(expectedResult, result);
        }


        //public void Fuzzy(string stringToParse, float expectedResult)
        //{
        //    var result = parse(stringToParse);
        //    Assert.AreEqual(result, expectedResult);
        //}

        float parseBasicMath(string stringToParse)
        {
            var stream = CharStreams.fromString(stringToParse);
            var lexer = new BasicMath.BasicMathLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new BasicMath.BasicMathParser(tokens);
            parser.BuildParseTree = true;
            var tree = parser.equation();
            var visitor = new Try_Antlr.CalculateResultVisitor();
            var result = visitor.Visit(tree);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Antlr4.Runtime;
using BasicMath;

namespace Try_Antlr
{
    class Program
    {
        static void Main(string[] args)
        {
            //executeBasicMath();
            executeIMP(@".\..\..\..\ImpTestFiles");
        }

        private static void executeIMP(string pathToFolder)
        {
            var strings = Directory.GetFiles(pathToFolder);
            foreach (var file in strings)
            {
                Console.WriteLine("\nParsing new File:");
                Console.WriteLine($"File: {file}");
                Console.WriteLine($"Text: \n{string.Join('\n', System.IO.File.ReadAllLines(file))}");
                Console.WriteLine("Result:");
                var result = ParseIMP(string.Join('\n', System.IO.File.ReadAllLines(file)), true);
            }
        }

        private static void executeBasicMath()
        {
            var strings = new List<string>() {
                    //"Hello World!",
                    "21+ 1.34",
                    "781 + 348",
                    "21* 1.34",
                    "781 * 348",
                    "21*               1.34",
                    "21 * 134",
                    //"Asd+134",
                    "1.3",
                    "1.3+ (1*2)",
                    "1.3* (1+2)",
                    "1.3 + 2+4+65+(2*3*4)+(1+2)"
            };
            var visitor = new PseudoCodeCompilerVisitor();
            foreach (var expression in strings)
            {
                Console.WriteLine("\nParsing new Expression:");
                Console.WriteLine($"Expression: {expression}");
                Console.WriteLine("Result:");
                var result = ParseBasicMath(expression);
                Console.WriteLine(visitor.Visit(result));
                //BTreePrinter.Print(result);
            }
        }

        public static BasicMathParser.EquationContext ParseBasicMath(string stringToParse)
        {
            var stream = CharStreams.fromString(stringToParse);
            var lexer = new BasicMathLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new BasicMathParser(tokens);
            parser.BuildParseTree = true;
            var result = parser.equation();
            return result;
        }

        public static Antlr4.Runtime.Tree.IParseTree ParseIMP(string stringToParse, bool printTreeToConsole = false)
        {
            var stream = CharStreams.fromString(stringToParse);
            var lexer = new IMP.IMPLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new IMP.IMPParser(tokens);
            parser.BuildParseTree = true;
            var result = parser.prog();


            if (printTreeToConsole)
            {
                Console.WriteLine(PrettyPrint.printSyntaxTree(parser.RuleNames.ToList(), result));
            }
            return result;
        }
    }
}

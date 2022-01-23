using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Try_Antlr
{
    class PrettyPrint
    {
        public static string printSyntaxTree(List<string> ruleNames, Antlr4.Runtime.Tree.IParseTree root)
        {
            string buf = "";
            recursive(root, ref buf, 0, ruleNames);
            return buf;
        }

        private static void recursive(Antlr4.Runtime.Tree.IParseTree aRoot, ref string buf, int offset, List<string> ruleNames)
        {
            for (int i = 0; i < offset; i++)
            {
                buf += "  ";
            }
            buf += (Antlr4.Runtime.Tree.Trees.GetNodeText(aRoot, ruleNames));
            buf += "\n";
            if (aRoot is ParserRuleContext prc)
            {
                if (prc.children != null)
                {
                    foreach (Antlr4.Runtime.Tree.IParseTree child in prc.children)
                    {
                        recursive(child, ref buf, offset + 1, ruleNames);
                    }
                }
            }
        }
    }
}

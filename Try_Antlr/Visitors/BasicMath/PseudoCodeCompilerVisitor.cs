using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicMath;
using Antlr4.Runtime.Tree;


namespace Try_Antlr
{
    class PseudoCodeCompilerVisitor : BasicMath.BasicMathBaseVisitor<string>
    {
        protected override string AggregateResult(string aggregate, string nextResult)
        {
            if (aggregate is null) return nextResult;
            if (nextResult is null) return aggregate;
            return aggregate + '\n' + nextResult;
        }

        public override string VisitMULTIPLY(BasicMathParser.MULTIPLYContext context)
        {
            return $"{VisitChildren(context)}\n" +
                "MULT";
        }

        public override string VisitUNARY(BasicMathParser.UNARYContext context)
        {
            if (context.op.Text == "-")
            {
                return $"-{VisitChildren(context)}";
            }
            return VisitChildren(context);
        }

        public override string VisitATOM(BasicMathParser.ATOMContext context)
        {
            return context.atom.Text;
        }

        public override string VisitPLUS(BasicMathParser.PLUSContext context)
        {
            return $"{VisitChildren(context)}\n" +
               "PLUS";
        }

        public override string VisitMINUS(BasicMathParser.MINUSContext context)
        {
            return $"{VisitChildren(context)}\n" +
              "MINUS";
        }

        public override string VisitDIVIDE(BasicMathParser.DIVIDEContext context)
        {
            return $"{VisitChildren(context)}\n" +
               "DIVIDE";
        }
    }
}

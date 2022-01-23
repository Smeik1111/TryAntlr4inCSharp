using Antlr4.Runtime.Misc;
using BasicMath;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Antlr
{
    public class CalculateResultVisitor : BasicMathBaseVisitor<float>
    {
        public override float VisitMULTIPLY([NotNull] BasicMathParser.MULTIPLYContext context)
        {
            var resultLeft = Visit(context.left);
            var resultRight = Visit(context.right);
            return resultLeft * resultRight;
        }
        public override float VisitDIVIDE([NotNull] BasicMathParser.DIVIDEContext context)
        {
            var resultLeft = Visit(context.left);
            var resultRight = Visit(context.right);
            return resultLeft / resultRight;
        }

        public override float VisitPLUS([NotNull] BasicMathParser.PLUSContext context)
        {
            var resultLeft = Visit(context.left);
            var resultRight = Visit(context.right);
            return resultLeft + resultRight;
        }

        public override float VisitMINUS([NotNull] BasicMathParser.MINUSContext context)
        {
            var resultLeft = Visit(context.left);
            var resultRight = Visit(context.right);
            return resultLeft - resultRight;
        }

        public override float VisitATOM([NotNull] BasicMathParser.ATOMContext context)
        {
            return float.Parse(context.atom.Text);
        }
        public override float VisitBRACKETS([NotNull] BasicMathParser.BRACKETSContext context)
        {
            var result = Visit(context.equation());
            return result;
        }
        public override float VisitUNARY([NotNull] BasicMathParser.UNARYContext context)
        {
            if(context.op.Text == "-")
            {
                return -Visit(context.equation());
            }
            return Visit(context.equation()); ;
        }
    }
}

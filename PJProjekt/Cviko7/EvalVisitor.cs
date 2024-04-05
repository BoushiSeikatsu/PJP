using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviko7
{
    public class EvalVisitor : ExprBaseVisitor<int>
    {
        public override int VisitInt([NotNull] ExprParser.IntContext context)
        {
            return Convert.ToInt32(context.INT().GetText(), 10);
        }
        public override int VisitHexa([NotNull] ExprParser.HexaContext context)
        {
            return Convert.ToInt32(context.HEXA().GetText(), 16);
        }
        public override int VisitOct([NotNull] ExprParser.OctContext context)
        {
            return Convert.ToInt32(context.OCT().GetText(), 8);
        }
        public override int VisitPar([NotNull] ExprParser.ParContext context)
        {
            return Visit(context.expr());
        }
        public override int VisitAdd([NotNull] ExprParser.AddContext context)
        {
            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            if (context.op.Text.Equals("+"))
            {
                return left + right;
            }
            else
            {
                return left - right;
            }
        }
        public override int VisitMul([NotNull] ExprParser.MulContext context)
        {
            var left = Visit(context.expr()[0]);
            var right = Visit(context.expr()[1]);
            if (context.op.Text.Equals("*"))
            {
                return left * right;
            }
            else
            {
                return left / right;
            }
        }
        public override int VisitProg([NotNull] ExprParser.ProgContext context)
        {
            foreach (var expr in context.expr())
            {
                Console.WriteLine(Visit(expr));
            }
            return 0;
        }
    }
}

using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviko7
{
    public class EvalListener : ExprBaseListener
    {
        ParseTreeProperty<int> values = new ParseTreeProperty<int>();

        public override void ExitInt([NotNull] ExprParser.IntContext context)
        {
            values.Put(context, Convert.ToInt32(context.INT().GetText(), 10));
        }
        public override void ExitHexa([NotNull] ExprParser.HexaContext context)
        {
            values.Put(context, Convert.ToInt32(context.HEXA().GetText(), 16));
        }

        public override void ExitOct([NotNull] ExprParser.OctContext context)
        {
            values.Put(context, Convert.ToInt32(context.OCT().GetText(), 8));
        }
        public override void ExitPar([NotNull] ExprParser.ParContext context)
        {
            values.Put(context, values.Get(context.expr()));
        }
        public override void ExitAdd([NotNull] ExprParser.AddContext context)
        {
            var left = values.Get(context.expr()[0]);
            var right = values.Get(context.expr()[1]);
            if (context.op.Text.Equals("+"))
            {
                values.Put(context, left + right);
            }
            else
            {
                values.Put(context, left - right);
            }
        }
        public override void ExitMul([NotNull] ExprParser.MulContext context)
        {
            var left = values.Get(context.expr()[0]);
            var right = values.Get(context.expr()[1]);
            if (context.op.Text.Equals("*"))
            {
                values.Put(context, left * right);
            }
            else
            {
                values.Put(context, left / right);
            }
        }
        public override void ExitProg([NotNull] ExprParser.ProgContext context)
        {
            foreach (var expr in context.expr())
            {
                Console.WriteLine(values.Get(expr));
            }
        }
    }
}

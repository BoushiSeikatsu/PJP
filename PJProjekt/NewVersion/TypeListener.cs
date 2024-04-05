using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace NewVersion
{
    internal class TypeListener : ANTLRGrammarBaseListener
    {
        ParseTreeProperty<object> values = new ParseTreeProperty<object>();
        List<string> errors = new List<string>();
        public override void ExitString([NotNull] ANTLRGrammarParser.StringContext context)
        {
            values.Put(context, context.STRING().GetText());
        }
        public override void ExitInt([NotNull] ANTLRGrammarParser.IntContext context)
        {
            values.Put(context, Convert.ToInt32(context.INT().GetText(), 10));
        }
        public override void ExitFloat([NotNull] ANTLRGrammarParser.FloatContext context)
        {
            values.Put(context, Convert.ToDouble(context.FLOAT().GetText()));
        }
        public override void ExitBool([NotNull] ANTLRGrammarParser.BoolContext context)
        {
            values.Put(context, Convert.ToBoolean(context.BOOL().GetText()));
        }
        
        public override void ExitId([NotNull] ANTLRGrammarParser.IdContext context)
        {
            values.Put(context, context.IDENTIFIER().GetText());
        }
        public override void ExitArNegation([NotNull] ANTLRGrammarParser.ArNegationContext context)
        {
            if(values.Get(context.expr()) is int)
            {
                int right = (int)values.Get(context.expr());
                right *= -1;
                values.Put(context, right);
            }
            else if(values.Get(context.expr()) is double)
            {
                double right = (double)values.Get(context.expr());
                right *= -1;
                values.Put(context, right);
            }
            else
            {
                errors.Add("Unarni minus lze pouzit pouze pro int a float, nikoliv pro hodnotu: " + values.Get(context.expr()));
            }
            Console.WriteLine("Tohle je vystup values: {0} tohle je vystup context: {1}", values.Get(context.expr()), context);
            
            /*if(right.Equals("INT") || right.Equals("FLOAT"))
            {
                right *= -1;
                values.Put(context, -right)
            }*/
        }
        public override void ExitLgNegation([NotNull] ANTLRGrammarParser.LgNegationContext context)
        {
            if(values.Get(context.expr()) is bool)
            {
                bool right = (bool)values.Get(context.expr());
                values.Put(context, right);
            }
            else
            {
                errors.Add("Logickou negaci lze pouzit pouze pro boolean, nikoliv pro hodnotu: " + values.Get(context.expr()));
            }
        }
        public override void ExitMulDiv([NotNull] ANTLRGrammarParser.MulDivContext context)
        {
            if(values.Get(context.expr()[0]) is int || values.Get(context.expr()[1]) is int)
            {
                if(values.Get(context.expr()[0]) is double || values.Get(context.expr()[1]) is double)
                {
                    double left = Convert.ToDouble(values.Get(context.expr()[0]));
                    double right = Convert.ToDouble(values.Get(context.expr()[1]));
                    if (context.op.Text.Equals("*"))
                    {
                        values.Put(context, left * right);
                    }
                    else
                    {
                        values.Put(context, left / right);
                    }
                }
                else if(values.Get(context.expr()[0]) is int && values.Get(context.expr()[1]) is int)
                {
                    int left = (int)values.Get(context.expr()[0]);
                    int right = (int)values.Get(context.expr()[1]);
                    if (context.op.Text.Equals("*"))
                    {
                        values.Put(context, left * right);
                    }
                    else
                    {
                        values.Put(context, left / right);
                    }
                }
            }
            else
            {
                errors.Add("Binarni aritmetickou operaci lze pouzit pouze pro int nebo float, nikoliv pro hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
        }
        public override void ExitModulo([NotNull] ANTLRGrammarParser.ModuloContext context)
        {
            if(values.Get(context.expr()[0]) is int && values.Get(context.expr()[1]) is int)
            {
                int left = (int)values.Get(context.expr()[0]);
                int right = (int)values.Get(context.expr()[1]);
                values.Put(context, left % right);
            }
            else
            {
                errors.Add("Modulo operaci lze pouzit pouze pro dvojici int, nikoliv pro hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
        }
        public override void ExitAddSub([NotNull] ANTLRGrammarParser.AddSubContext context)
        {
            if (values.Get(context.expr()[0]) is int || values.Get(context.expr()[1]) is int)
            {
                if (values.Get(context.expr()[0]) is double || values.Get(context.expr()[1]) is double)
                {
                    double left = Convert.ToDouble(values.Get(context.expr()[0]));
                    double right = Convert.ToDouble(values.Get(context.expr()[1]));
                    if (context.op.Text.Equals("+"))
                    {
                        values.Put(context, left + right);
                    }
                    else
                    {
                        values.Put(context, left - right);
                    }
                }
                else if (values.Get(context.expr()[0]) is int && values.Get(context.expr()[1]) is int)
                {
                    int left = (int)values.Get(context.expr()[0]);
                    int right = (int)values.Get(context.expr()[1]);
                    if (context.op.Text.Equals("+"))
                    {
                        values.Put(context, left + right);
                    }
                    else
                    {
                        values.Put(context, left - right);
                    }
                }
            }
            else
            {
                errors.Add("Binarni aritmetickou operaci lze pouzit pouze pro int nebo float, nikoliv pro hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
        }
        public override void ExitConcat([NotNull] ANTLRGrammarParser.ConcatContext context)
        {
            if(values.Get(context.expr()[0]) is string && values.Get(context.expr()[1]) is string)
            {
                string left = (string)values.Get(context.expr()[0]);
                string right = (string)values.Get(context.expr()[1]);
                values.Put(context, left + right);
            }
            else
            {
                errors.Add("Spojit lze pouze pro dvojici stringu, nikoliv hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
        }
        public override void ExitCompare([NotNull] ANTLRGrammarParser.CompareContext context)
        {
            if (values.Get(context.expr()[0]) is int || values.Get(context.expr()[1]) is int)
            {
                if (values.Get(context.expr()[0]) is double || values.Get(context.expr()[1]) is double)
                {
                    double left = Convert.ToDouble(values.Get(context.expr()[0]));
                    double right = Convert.ToDouble(values.Get(context.expr()[1]));
                    if (context.op.Text.Equals(">"))
                    {
                        values.Put(context, left > right);
                    }
                    else
                    {
                        values.Put(context, left < right);
                    }
                }
                else if (values.Get(context.expr()[0]) is int && values.Get(context.expr()[1]) is int)
                {
                    int left = (int)values.Get(context.expr()[0]);
                    int right = (int)values.Get(context.expr()[1]);
                    if (context.op.Text.Equals(">"))
                    {
                        values.Put(context, left > right);
                    }
                    else
                    {
                        values.Put(context, left < right);
                    }
                }
            }
            else
            {
                errors.Add("Porovnavajici operaci lze pouzit pouze pro int nebo float, nikoliv pro hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
        }
        public override void ExitEquality([NotNull] ANTLRGrammarParser.EqualityContext context)
        {
            if(values.Get(context.expr()[0]) is bool || values.Get(context.expr()[1]) is bool)
            {
                errors.Add("Porovnavajici operaci lze pouzit pouze pro int, float a string, nikoliv pro hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
            else
            {
                if(values.Get(context.expr()[0]) is string && values.Get(context.expr()[1]) is string)
                {
                    string left = (string)values.Get(context.expr()[0]);
                    string right = (string)values.Get(context.expr()[1]);
                    if (context.op.Text.Equals("=="))
                    {
                        values.Put(context, left == right);
                    }
                    else
                    {
                        values.Put(context, left != right);
                    }
                }
                else if(values.Get(context.expr()[0]) is not string && values.Get(context.expr()[1]) is not string)
                {
                    double left = Convert.ToDouble(values.Get(context.expr()[0]));
                    double right = Convert.ToDouble(values.Get(context.expr()[1]));
                    if (context.op.Text.Equals("=="))
                    {
                        values.Put(context, left == right);
                    }
                    else
                    {
                        values.Put(context, left != right);
                    }
                }
                else
                {
                    errors.Add("Nelze porovnat string s ciselnou hodnotou!");
                }
            }
        }
        public override void ExitLogicalAnd([NotNull] ANTLRGrammarParser.LogicalAndContext context)
        {
            if(values.Get(context.expr()[0]) is bool && values.Get(context.expr()[1]) is bool)
            {
                bool left = (bool)values.Get(context.expr()[0]);
                bool right = (bool)values.Get(context.expr()[1]);
                values.Put(context, left && right);
            }
            else
            {
                errors.Add("Logickou AND operaci lze provest pouze pro bool nikoliv pro hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
        }
        public override void ExitLogicalOr([NotNull] ANTLRGrammarParser.LogicalOrContext context)
        {
            if (values.Get(context.expr()[0]) is bool && values.Get(context.expr()[1]) is bool)
            {
                bool left = (bool)values.Get(context.expr()[0]);
                bool right = (bool)values.Get(context.expr()[1]);
                values.Put(context, left || right);
            }
            else
            {
                errors.Add("Logickou OR operaci lze provest pouze pro bool nikoliv pro hodnoty: " + values.Get(context.expr()[0]) + " a " + values.Get(context.expr()[1]));
            }
        }
        public override void ExitAssignment([NotNull] ANTLRGrammarParser.AssignmentContext context)
        {
            Console.WriteLine("Value: {0}, Context: {1}, Expr: {2}", values.Get(context.expr()), context, context.expr());
        }
        /*public override void ExitProg([NotNull] ExprParser.ProgContext context)
        {
            foreach (var expr in context.expr())
            {
                Console.WriteLine(values.Get(expr));
            }
        }*/
    }
}

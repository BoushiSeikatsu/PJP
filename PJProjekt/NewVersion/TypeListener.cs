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
        public List<string> errors = new List<string>();
        Dictionary<string, object> identifiers = new Dictionary<string, object>();
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
        //STATEMENTS PART
        public override void ExitDeclaration([NotNull] ANTLRGrammarParser.DeclarationContext context)
        {
            var primitiveType = context.primitiveType();
            var identifiers = context.IDENTIFIER();
            foreach(var identifier in identifiers)
            {
                if(this.identifiers.Keys.Contains(identifier.GetText()))
                {
                    errors.Add("Tato promenná " + identifier.GetText() + " již byla deklarována!");
                }
                else
                {
                    if(primitiveType.GetText() == "string") 
                    {
                        this.identifiers.Add(identifier.GetText(), "");
                    }
                    if (primitiveType.GetText() == "int")
                    {
                        this.identifiers.Add(identifier.GetText(), 0);
                    }
                    if (primitiveType.GetText() == "float")
                    {
                        this.identifiers.Add(identifier.GetText(), 0.0);
                    }
                    if (primitiveType.GetText() == "bool")
                    {
                        this.identifiers.Add(identifier.GetText(), false);
                    }
                }
            }
            /*foreach(var pair in this.identifiers)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }*/
        }
        public override void ExitDoWhile([NotNull] ANTLRGrammarParser.DoWhileContext context)
        {
            var expr = values.Get(context.expr());
            if(identifiers.Keys.Contains(expr))
            {
                expr = identifiers[expr as string];
            }
            if(expr is not bool)
            {
                errors.Add("Neplatna podminka ve while, dostali jsme: " + expr.GetType() + " cekali jsme: " + typeof(System.Boolean));
            }
        }
        public override void ExitCondStatement([NotNull] ANTLRGrammarParser.CondStatementContext context)
        {
            var value = values.Get(context.expr());
            if(value is not bool)
            {
                errors.Add("Spatná podminka if");
            }
        }
        public override void ExitWhileLoopStatement([NotNull] ANTLRGrammarParser.WhileLoopStatementContext context)
        {
            var value = values.Get(context.expr());
            if (value is not bool)
            {
                errors.Add("Spatná podminka while");
            }
        }
        //EXPRESIONS PART
        public override void ExitParens([NotNull] ANTLRGrammarParser.ParensContext context)
        {
            var expression = values.Get(context.expr());
            values.Put(context, expression);
        }
        public override void ExitArNegation([NotNull] ANTLRGrammarParser.ArNegationContext context)
        {
            var rightExprValue = values.Get(context.expr());
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (rightExprValue is int)
            {
                int right = (int)rightExprValue;
                right *= -1;
                values.Put(context, right);
            }
            else if(rightExprValue is double)
            {
                double right = (double)rightExprValue;
                right *= -1;
                values.Put(context, right);
            }
            else
            {
                errors.Add("Unarni minus lze pouzit pouze pro int a float, nikoliv pro hodnotu: " + rightExprValue);
            }
            /*if(right.Equals("INT") || right.Equals("FLOAT"))
            {
                right *= -1;
                values.Put(context, -right)
            }*/
        }
        public override void ExitLgNegation([NotNull] ANTLRGrammarParser.LgNegationContext context)
        {
            var rightExprValue = values.Get(context.expr());
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (rightExprValue is bool)
            {
                bool right = (bool)rightExprValue;
                values.Put(context, right);
            }
            else
            {
                errors.Add("Logickou negaci lze pouzit pouze pro boolean, nikoliv pro hodnotu: " + rightExprValue);
            }
        }
        public override void ExitMulDiv([NotNull] ANTLRGrammarParser.MulDivContext context)
        {
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is int || rightExprValue is int)
            {
                if(leftExprValue is double || rightExprValue is double)
                {
                    double left = Convert.ToDouble(leftExprValue);
                    double right = Convert.ToDouble(rightExprValue);
                    if (context.op.Text.Equals("*"))
                    {
                        values.Put(context, left * right);
                    }
                    else
                    {
                        values.Put(context, left / right);
                    }
                }
                else if(leftExprValue is int && rightExprValue is int)
                {
                    int left = (int)leftExprValue;
                    int right = (int)rightExprValue;
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
            else if (leftExprValue is double || rightExprValue is double)
            {
                double left = Convert.ToDouble(leftExprValue);
                double right = Convert.ToDouble(rightExprValue);
                if (context.op.Text.Equals("*"))
                {
                    values.Put(context, left * right);
                }
                else
                {
                    values.Put(context, left / right);
                }
            }
            else
            {
                errors.Add("Binarni aritmetickou operaci lze pouzit pouze pro int nebo float, nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
        }
        public override void ExitModulo([NotNull] ANTLRGrammarParser.ModuloContext context)
        {
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is int && rightExprValue is int)
            {
                int left = (int)leftExprValue;
                int right = (int)rightExprValue;
                values.Put(context, left % right);
            }
            else
            {
                errors.Add("Modulo operaci lze pouzit pouze pro dvojici int, nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
        }
        public override void ExitAddSub([NotNull] ANTLRGrammarParser.AddSubContext context)
        {
            //Predelat vsechny expressions na check jestli se jedna o identifier
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if(identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is int || rightExprValue is int)
            {
                if (leftExprValue is double || rightExprValue is double)
                {
                    double left = Convert.ToDouble(leftExprValue);
                    double right = Convert.ToDouble(rightExprValue);
                    if (context.op.Text.Equals("+"))
                    {
                        values.Put(context, left + right);
                    }
                    else
                    {
                        values.Put(context, left - right);
                    }
                }
                else if (leftExprValue is int && rightExprValue is int)
                {
                    int left = (int)leftExprValue;
                    int right = (int)rightExprValue;
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
            else if(leftExprValue is double || rightExprValue is double)
            {
                double left = Convert.ToDouble(leftExprValue);
                double right = Convert.ToDouble(rightExprValue);
                if (context.op.Text.Equals("+"))
                {
                    values.Put(context, left + right);
                }
                else
                {
                    values.Put(context, left - right);
                }
            }
            else
            {
                errors.Add("Binarni aritmetickou operaci lze pouzit pouze pro int nebo float, nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
        }
        public override void ExitConcat([NotNull] ANTLRGrammarParser.ConcatContext context)
        {
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is string && rightExprValue is string)
            {
                string left = (string)leftExprValue;
                string right = (string)rightExprValue;
                values.Put(context, left + right);
            }
            else
            {
                errors.Add("Spojit lze pouze pro dvojici stringu, nikoliv hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
        }
        public override void ExitCompare([NotNull] ANTLRGrammarParser.CompareContext context)
        {
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is int || rightExprValue is int)
            {
                if (leftExprValue is double || rightExprValue is double)
                {
                    double left = Convert.ToDouble(leftExprValue);
                    double right = Convert.ToDouble(rightExprValue);
                    if (context.op.Text.Equals(">"))
                    {
                        values.Put(context, left > right);
                    }
                    else
                    {
                        values.Put(context, left < right);
                    }
                }
                else if (leftExprValue is int && rightExprValue is int)
                {
                    int left = (int)leftExprValue;
                    int right = (int)rightExprValue;
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
                errors.Add("Porovnavajici operaci lze pouzit pouze pro int nebo float, nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
        }
        public override void ExitEquality([NotNull] ANTLRGrammarParser.EqualityContext context)
        {
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is bool || rightExprValue is bool)
            {
                errors.Add("Porovnavajici operaci lze pouzit pouze pro int, float a string, nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
            else
            {
                if(leftExprValue is string && rightExprValue is string)
                {
                    string left = (string)leftExprValue;
                    string right = (string)rightExprValue;
                    if (context.op.Text.Equals("=="))
                    {
                        values.Put(context, left == right);
                    }
                    else
                    {
                        values.Put(context, left != right);
                    }
                }
                else if(leftExprValue is not string && rightExprValue is not string)
                {
                    double left = Convert.ToDouble(leftExprValue);
                    double right = Convert.ToDouble(rightExprValue);
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
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is bool && rightExprValue is bool)
            {
                bool left = (bool)leftExprValue;
                bool right = (bool)rightExprValue;
                values.Put(context, left && right);
            }
            else
            {
                errors.Add("Logickou AND operaci lze provest pouze pro bool nikoliv pro hodnoty: " + leftExprValue  + " a " + rightExprValue);
            }
        }
        public override void ExitLogicalOr([NotNull] ANTLRGrammarParser.LogicalOrContext context)
        {
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is bool && rightExprValue is bool)
            {
                bool left = (bool)leftExprValue;
                bool right = (bool)rightExprValue;
                values.Put(context, left || right);
            }
            else
            {
                errors.Add("Logickou OR operaci lze provest pouze pro bool nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
        }
        public override void ExitAssignment([NotNull] ANTLRGrammarParser.AssignmentContext context)
        {
            var identifier = context.IDENTIFIER().GetText();
            if(this.identifiers.Keys.Contains(identifier))
            {
                var idValue = this.identifiers[identifier];
                var rightExprValue = values.Get(context.expr());
                if (identifiers.Keys.Contains(rightExprValue))
                {
                    rightExprValue = identifiers[rightExprValue as string];
                }
                if (rightExprValue?.GetType() == null)
                {
                    if (idValue.GetType() == typeof(System.Int32))
                    {
                        rightExprValue = (int)0;
                    }
                    else if (idValue.GetType() == typeof(System.Double))
                    {
                        rightExprValue = Convert.ToDouble(0);
                    }
                }
                if (idValue.GetType() == rightExprValue?.GetType())
                {
                    values.Put(context, rightExprValue);
                    identifiers[identifier] = rightExprValue;
                }
                else
                {
                    if (idValue.GetType() == typeof(System.Double) && rightExprValue?.GetType() == typeof(System.Int32))
                    {
                        values.Put(context, rightExprValue);
                        identifiers[identifier] = Convert.ToDouble(rightExprValue);
                    }
                    else
                    {
                        errors.Add("Spatné prirazení hodnoty: " + rightExprValue + " do promenné: " + identifier + ": " + idValue.GetType() + " jelikoz má typ: " + rightExprValue?.GetType());
                    }
                }
            }
       
            else
            {
                errors.Add(identifier + " neni deklarovany");
            }
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

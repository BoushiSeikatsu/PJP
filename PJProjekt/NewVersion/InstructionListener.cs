using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersion
{
    internal class InstructionListener : ANTLRGrammarBaseListener
    {
        ParseTreeProperty<object> values = new ParseTreeProperty<object>();
        public List<string> errors = new List<string>();
        Dictionary<string, object> identifiers = new Dictionary<string, object>();
        public List<string> instructions = new List<string>();
        public ParseTreeProperty<Type> types = new ParseTreeProperty<Type>();
        int labelCounter = 0;
        public InstructionListener(ParseTreeProperty<Type> types)
        {
            this.types = types;
        }
        public override void ExitString([NotNull] ANTLRGrammarParser.StringContext context)
        {
            values.Put(context, context.STRING().GetText());
            instructions.Add("push S " + context.STRING().GetText());
        }
        public override void ExitInt([NotNull] ANTLRGrammarParser.IntContext context)
        {
            values.Put(context, Convert.ToInt32(context.INT().GetText(), 10));
            instructions.Add("push I " + context.INT().GetText());
            var parent = context.Parent;
            if(parent.ChildCount == 3)
            {
                var type = types.Get(parent.GetChild(2));
                if(type == Type.Float)
                {
                    instructions.Add("itof");
                }
                else
                {
                    type = types.Get(parent.GetChild(0));
                    if(type == Type.Float)
                    {
                        instructions.Add("itof");
                    }
                }
            }
        }
        public override void ExitFloat([NotNull] ANTLRGrammarParser.FloatContext context)
        {
            values.Put(context, Convert.ToDouble(context.FLOAT().GetText()));
            instructions.Add("push F " + context.FLOAT().GetText());
        }
        public override void ExitBool([NotNull] ANTLRGrammarParser.BoolContext context)
        {
            values.Put(context, Convert.ToBoolean(context.BOOL().GetText()));
            instructions.Add("push B " + context.BOOL().GetText());
        }

        public override void ExitId([NotNull] ANTLRGrammarParser.IdContext context)
        {
            values.Put(context, context.IDENTIFIER().GetText());
            instructions.Add("load " + context.IDENTIFIER().GetText());
        }
        //STATEMENTS PART
        public override void ExitDeclaration([NotNull] ANTLRGrammarParser.DeclarationContext context)
        {
            var primitiveType = context.primitiveType();
            var identifiers = context.IDENTIFIER();
            foreach (var identifier in identifiers)
            {
                if (this.identifiers.Keys.Contains(identifier.GetText()))
                {
                    errors.Add("Tato promenná " + identifier.GetText() + " již byla deklarována!");
                }
                else
                {
                    if (primitiveType.GetText() == "string")
                    {
                        this.identifiers.Add(identifier.GetText(), "");
                        instructions.Add("push S \"\"");
                        instructions.Add("save " + identifier.GetText());
                    }
                    if (primitiveType.GetText() == "int")
                    {
                        this.identifiers.Add(identifier.GetText(), 0);
                        instructions.Add(@"push I 0");
                        instructions.Add("save " + identifier.GetText());
                    }
                    if (primitiveType.GetText() == "float")
                    {
                        this.identifiers.Add(identifier.GetText(), 0.0);
                        instructions.Add(@"push F 0.0");
                        instructions.Add("save " + identifier.GetText());
                    }
                    if (primitiveType.GetText() == "bool")
                    {
                        this.identifiers.Add(identifier.GetText(), false);
                        instructions.Add(@"push B false");
                        instructions.Add("save " + identifier.GetText());
                    }
                }
            }
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if (parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
        }
        /*foreach(var pair in this.identifiers)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }*/
        public override void ExitDoWhile([NotNull] ANTLRGrammarParser.DoWhileContext context)
        {
            var expr = values.Get(context.expr());
            if (identifiers.Keys.Contains(expr))
            {
                instructions.Add("load " + expr);
                expr = identifiers[expr as string];
            }
            if (expr is not bool)
            {
                errors.Add("Neplatna podminka ve while, dostali jsme: " + expr.GetType() + " cekali jsme: " + typeof(System.Boolean));
            }
        }
        public override void ExitCondStatement([NotNull] ANTLRGrammarParser.CondStatementContext context)
        {
            var value = values.Get(context.expr());
            if (value is not bool)
            {
                errors.Add("Spatná podminka if");
                return;
            }
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if (parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                        labelCounter += 1;
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
        }
        public override void ExitWhileLoopStatement([NotNull] ANTLRGrammarParser.WhileLoopStatementContext context)
        {
            var value = values.Get(context.expr());
            if (value is not bool)
            {
                errors.Add("Spatná podminka while");
            }
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if (parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
            if (parent.GetType() == typeof(ANTLRGrammarParser.WhileLoopStatementContext) || parent.IsEmpty)
            {
                instructions.Add("label " + labelCounter);
                labelCounter += 1;
            }
        }
        public override void EnterWhileLoopStatement([NotNull] ANTLRGrammarParser.WhileLoopStatementContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext) || parent.IsEmpty)
            {
                instructions.Add("label " + (labelCounter));
            }
        }
        public override void EnterCondStatement([NotNull] ANTLRGrammarParser.CondStatementContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
        }
        public override void EnterWriteId([NotNull] ANTLRGrammarParser.WriteIdContext context)
        {
            var parent = context.parent;
            if(parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if(parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
        }
        public override void EnterReadId([NotNull] ANTLRGrammarParser.ReadIdContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
        }
        public override void EnterDeclaration([NotNull] ANTLRGrammarParser.DeclarationContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
        }
        public override void EnterEmptyStatement([NotNull] ANTLRGrammarParser.EmptyStatementContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
        }
        public override void EnterPrintExpr([NotNull] ANTLRGrammarParser.PrintExprContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
        }
        public override void EnterBlockStatements([NotNull] ANTLRGrammarParser.BlockStatementsContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("fjmp " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    //labelCounter += 1;
                }
            }
            if (parent.GetType() == typeof(ANTLRGrammarParser.WhileLoopStatementContext))
            {
                instructions.Add("fjmp " + (labelCounter + 1));
            }
        }
        public override void ExitPrintExpr([NotNull] ANTLRGrammarParser.PrintExprContext context)
        {
            var expression = values.Get(context.expr());
            var parent = context.parent;
            if (identifiers.Keys.Contains(expression))
            {
                instructions.Add("load " + expression);
                instructions.Add("pop");
            }
            else if(parent.IsEmpty)
            {
                if (context.expr().GetType() != typeof(ANTLRGrammarParser.AssignmentContext))
                {
                    instructions.Add("pop");
                }
            }
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if (parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
        }
        public override void ExitWriteId([NotNull] ANTLRGrammarParser.WriteIdContext context)
        {
            int count = context.expr().Length;
            instructions.Add("print " + count);
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if (parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
        }
        public override void ExitReadId([NotNull] ANTLRGrammarParser.ReadIdContext context)
        {
            var ids = context.IDENTIFIER();
            foreach(var id in ids)
            {
                var value = identifiers[id.GetText()];
                if(value is int)
                {
                    instructions.Add("read I");
                }
                if (value is double)
                {
                    instructions.Add("read F");
                }
                if (value is string)
                {
                    instructions.Add("read S");
                }
                if(value is bool)
                {
                    instructions.Add("read B");
                }
                instructions.Add("save " + id.GetText());
            }
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if (parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
        }
        public override void ExitBlockStatements([NotNull] ANTLRGrammarParser.BlockStatementsContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if (parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                        labelCounter += 1;
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
            if (parent.GetType() == typeof(ANTLRGrammarParser.WhileLoopStatementContext))
            {
                instructions.Add("jmp " + (labelCounter));
                labelCounter += 1;
            }
        }
        public override void ExitEmptyStatement([NotNull] ANTLRGrammarParser.EmptyStatementContext context)
        {
            var parent = context.parent;
            if (parent.GetType() == typeof(ANTLRGrammarParser.CondStatementContext))
            {
                if (parent.GetChild(4) == context)
                {
                    instructions.Add("jmp " + labelCounter);
                    if(parent.ChildCount == 5)
                    {
                        instructions.Add("label " + (labelCounter - 1));
                        instructions.Add("label " + labelCounter);
                    }
                }
                else if (parent.ChildCount != 5)
                {
                    instructions.Add("label " + labelCounter);
                    labelCounter += 1;
                }
                else
                {
                    instructions.Add("label " + (labelCounter - 1));
                    instructions.Add("label " + labelCounter);
                }
            }
        }
        //EXPRESIONS PART
        public override void ExitParens([NotNull] ANTLRGrammarParser.ParensContext context)
        {
            var expression = values.Get(context.expr());
            values.Put(context, expression);
            var parent = context.Parent;
            if(parent.ChildCount == 3)
            {
                var type = types.Get(parent.GetChild(2));
                if(type == Type.Float)
                {
                    instructions.Add("itof");
                }
            }
        }
        public override void ExitArNegation([NotNull] ANTLRGrammarParser.ArNegationContext context)
        {
            var rightExprValue = values.Get(context.expr());
            instructions.Add("uminus");
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (rightExprValue is int)
            {
                int right = (int)rightExprValue;
                right *= -1;
                values.Put(context, right);
            }
            else if (rightExprValue is double)
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
            instructions.Add("not");
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
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
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is int || rightExprValue is int)
            {
                if (leftExprValue is double || rightExprValue is double)
                {
                    double left = Convert.ToDouble(leftExprValue);
                    double right = Convert.ToDouble(rightExprValue);
                    if (context.op.Text.Equals("*"))
                    {
                        values.Put(context, left * right);
                        instructions.Add("mul");
                    }
                    else
                    {
                        values.Put(context, left / right);
                        instructions.Add("div");
                    }
                }
                else if (leftExprValue is int && rightExprValue is int)
                {
                    int left = (int)leftExprValue;
                    int right = (int)rightExprValue;
                    if (context.op.Text.Equals("*"))
                    {
                        values.Put(context, left * right);
                        instructions.Add("mul");
                    }
                    else
                    {
                        values.Put(context, left / right);
                        instructions.Add("div");
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
                    instructions.Add("mul");
                }
                else
                {
                    values.Put(context, left / right);
                    instructions.Add("div");
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
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is int && rightExprValue is int)
            {
                instructions.Add("mod");
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
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
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
                        instructions.Add("add");
                    }
                    else
                    {
                        values.Put(context, left - right);
                        instructions.Add("sub");
                    }
                }
                else if (leftExprValue is int && rightExprValue is int)
                {
                    int left = (int)leftExprValue;
                    int right = (int)rightExprValue;
                    if (context.op.Text.Equals("+"))
                    {
                        values.Put(context, left + right);
                        instructions.Add("add");
                    }
                    else
                    {
                        values.Put(context, left - right);
                        instructions.Add("sub");
                    }
                }
            }
            else if (leftExprValue is double || rightExprValue is double)
            {
                double left = Convert.ToDouble(leftExprValue);
                double right = Convert.ToDouble(rightExprValue);
                if (context.op.Text.Equals("+"))
                {
                    values.Put(context, left + right);
                    instructions.Add("add");
                }
                else
                {
                    values.Put(context, left - right);
                    instructions.Add("sub");
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
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is string && rightExprValue is string)
            {
                instructions.Add("concat");
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
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
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
                        instructions.Add("gt");
                    }
                    else
                    {
                        values.Put(context, left < right);
                        instructions.Add("lt");
                    }
                }
                else if (leftExprValue is int && rightExprValue is int)
                {
                    int left = (int)leftExprValue;
                    int right = (int)rightExprValue;
                    if (context.op.Text.Equals(">"))
                    {
                        values.Put(context, left > right);
                        instructions.Add("gt");
                    }
                    else
                    {
                        values.Put(context, left < right);
                        instructions.Add("lt");
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
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is bool || rightExprValue is bool)
            {
                errors.Add("Porovnavajici operaci lze pouzit pouze pro int, float a string, nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
            else
            {
                if (leftExprValue is string && rightExprValue is string)
                {
                    string left = (string)leftExprValue;
                    string right = (string)rightExprValue;
                    if (context.op.Text.Equals("=="))
                    {
                        values.Put(context, left == right);
                        instructions.Add("eq");
                    }
                    else
                    {
                        values.Put(context, left != right);
                        instructions.Add("eq");
                        instructions.Add("not");
                    }
                }
                else if (leftExprValue is not string && rightExprValue is not string)
                {
                    double left = Convert.ToDouble(leftExprValue);
                    double right = Convert.ToDouble(rightExprValue);
                    if (context.op.Text.Equals("=="))
                    {
                        values.Put(context, left == right);
                        instructions.Add("eq");
                    }
                    else
                    {
                        values.Put(context, left != right);
                        instructions.Add("eq");
                        instructions.Add("not");
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
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is bool && rightExprValue is bool)
            {
                instructions.Add("and");
                bool left = (bool)leftExprValue;
                bool right = (bool)rightExprValue;
                values.Put(context, left && right);
            }
            else
            {
                errors.Add("Logickou AND operaci lze provest pouze pro bool nikoliv pro hodnoty: " + leftExprValue + " a " + rightExprValue);
            }
        }
        public override void ExitLogicalOr([NotNull] ANTLRGrammarParser.LogicalOrContext context)
        {
            var leftExprValue = values.Get(context.expr()[0]);
            var rightExprValue = values.Get(context.expr()[1]);
            if (identifiers.Keys.Contains(leftExprValue))
            {
                instructions.Add("load " + leftExprValue);
                leftExprValue = identifiers[leftExprValue as string];
            }
            if (identifiers.Keys.Contains(rightExprValue))
            {
                instructions.Add("load " + rightExprValue);
                rightExprValue = identifiers[rightExprValue as string];
            }
            if (leftExprValue is bool && rightExprValue is bool)
            {
                instructions.Add("or");
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
            if (this.identifiers.Keys.Contains(identifier))
            {
                var idValue = this.identifiers[identifier];
                var rightExprValue = values.Get(context.expr());
                if (identifiers.Keys.Contains(rightExprValue))
                {
                    instructions.Add("load " + rightExprValue);
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
                    instructions.Add("save " + identifier);
                    values.Put(context, identifier);
                    identifiers[identifier] = rightExprValue;
                }
                else
                {
                    if (idValue.GetType() == typeof(System.Double) && rightExprValue?.GetType() == typeof(System.Int32))
                    {
                        instructions.Add("itof");
                        instructions.Add("save " + identifier);
                        values.Put(context, identifier);
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
    }
}

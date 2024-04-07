using Antlr4.Runtime.Tree;
using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewVersion
{
    internal class ParseTreePrinter
    {
        public static string Print(IParseTree tree, ParserRuleContext context)
        {
            var stringBuilder = new StringBuilder();
            Print(tree, context, stringBuilder, 0);
            return stringBuilder.ToString();
        }

        private static void Print(IParseTree tree, ParserRuleContext context, StringBuilder stringBuilder, int indentLevel)
        {
            if (tree is ParserRuleContext parserRuleContext && parserRuleContext != context)
            {
                stringBuilder.AppendLine($"{GetIndentString(indentLevel)}{parserRuleContext.GetType().Name}: {parserRuleContext.GetText()}");
                indentLevel++;
                for (int i = 0; i < parserRuleContext.ChildCount; i++)
                {
                    Print(parserRuleContext.GetChild(i), context, stringBuilder, indentLevel);
                }
            }
            else if (tree is ITerminalNode terminalNode)
            {
                stringBuilder.AppendLine($"{GetIndentString(indentLevel)}{terminalNode.Symbol}: {terminalNode.GetText()}");
            }
        }

        private static string GetIndentString(int indentLevel)
        {
            return new string(' ', indentLevel * 4);
        }
    }
}

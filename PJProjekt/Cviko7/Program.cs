using Antlr4.Runtime.Tree;
using Antlr4.Runtime;
using System.Globalization;

namespace Cviko7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            var fileName = "Test.txt";
            Console.WriteLine("Parsing: " + fileName);
            var inputFile = new StreamReader(fileName);
            AntlrInputStream input = new AntlrInputStream(inputFile);
            ExprLexer lexer = new ExprLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            ExprParser parser = new ExprParser(tokens);

            parser.AddErrorListener(new VerboseListener());

            IParseTree tree = parser.prog();

            /*if (parser.NumberOfSyntaxErrors == 0)
            {
                //Console.WriteLine(tree.ToStringTree(parser));
                ParseTreeWalker walker = new ParseTreeWalker();
                walker.Walk(new EvalListener(), tree);

                new EvalVisitor().Visit(tree);
            }*/
        }
    }
}

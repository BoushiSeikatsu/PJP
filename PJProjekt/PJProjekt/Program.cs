using Antlr4.Runtime.Tree;
using Antlr4.Runtime;

namespace PJProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputFile = new StreamReader("Test.txt");
            AntlrInputStream input = new AntlrInputStream(inputFile);
            ExprLexer lexer = new ExprLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            ExprParser parser = new ExprParser(tokens);
            IParseTree tree = parser.init();
            Console.WriteLine(tree.ToStringTree(parser));
        }
    }
}

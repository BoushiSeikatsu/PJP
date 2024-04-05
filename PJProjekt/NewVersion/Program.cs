using Antlr4.Runtime;
using System.Globalization;

namespace NewVersion
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
            ANTLRGrammarLexer lexer = new ANTLRGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            ANTLRGrammarParser parser = new ANTLRGrammarParser(tokens);
        }
    }
}

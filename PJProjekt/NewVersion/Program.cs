﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
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

            parser.AddErrorListener(new VerboseErrorListener());
            IParseTree tree = parser.program();
            TypeListener typeChecker = new TypeListener();
            var parseTreeString = ParseTreePrinter.Print(tree, parser.Context);
            //Console.WriteLine(parseTreeString);
            if (parser.NumberOfSyntaxErrors == 0)
            {
                //Console.WriteLine(tree.ToStringTree(parser));
                ParseTreeWalker walker = new ParseTreeWalker();
                walker.Walk(typeChecker, tree);
            }
            foreach(var error in typeChecker.errors)
            {
                Console.WriteLine(error);
            }
            InstructionListener instructionListener = new InstructionListener(typeChecker.types);
            if(typeChecker.errors.Count == 0)
            {
                ParseTreeWalker walker2 = new ParseTreeWalker();
                walker2.Walk(instructionListener, tree);
            }
            using (StreamWriter sw = new StreamWriter(@"..\..\..\..\..\output.txt"))
            {
                foreach (string s in instructionListener.instructions)
                {
                    Console.WriteLine(s);
                    sw.WriteLine(s);

                }
            }
        }
    }
}

using Grammar;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using static Grammar.ExtensionsAssistant;

namespace Lab3
{

	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				StreamReader r = new StreamReader(new FileStream("G1.TXT", FileMode.Open));

				GrammarReader inp = new GrammarReader(r);
				var grammar = inp.Read();
				grammar.dump();

				GrammarOps gr = new GrammarOps(grammar);

				// First step, computes nonterminals that can be rewritten as empty word
				foreach (Nonterminal nt in gr.EmptyNonterminals)
				{
					Console.Write(nt.Name + " ");
				}
				Console.WriteLine();
				foreach(var (rule,first) in gr.First)
				{
					//Console.WriteLine(rule + ": " + first.printHashSet());
				}
			}
			catch (GrammarException e)
			{
				Console.WriteLine($"{e.LineNumber}: Error -  {e.Message}");
			}
			catch (IOException e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
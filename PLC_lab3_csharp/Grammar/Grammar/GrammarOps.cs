using Grammar;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
	public class GrammarOps
	{
		public GrammarOps(IGrammar g)
		{
			this.g = g;
			compute_empty();
		}
        private Terminal epsilon = new Terminal("{e}");
		public ISet<Nonterminal> EmptyNonterminals { get; } = new HashSet<Nonterminal>();
        public Dictionary<Rule, HashSet<Terminal>> First { get; } = new Dictionary<Rule, HashSet<Terminal>>();
        private void compute_empty()
		{
			foreach(var rule in g.Rules)
			{
				if(rule.RHS.Count == 0)
				{
					EmptyNonterminals.Add(rule.LHS);
				}
			}
			int lastSize = EmptyNonterminals.Count;
			do
			{
                lastSize = EmptyNonterminals.Count;
                foreach (var rule in g.Rules)
				{
					if (EmptyNonterminals.Contains(rule.LHS)) continue;//If Empty nonterminal is already in the list, skip it
					if(rule.RHS.All(x => x is Nonterminal && (EmptyNonterminals.Contains(x as Nonterminal))))//Check if rule containst only nonterminals that can be empty
					{
						EmptyNonterminals.Add(rule.LHS);
					}
				}
			} while (lastSize != EmptyNonterminals.Count);


        }
		public void compute_first()
		{
			var table = new Dictionary<Nonterminal, (HashSet<Nonterminal> Left, HashSet<Terminal> Right)>();
			// First.Add(g.Rules[0], new HashSet<Terminal>());
			foreach(var rule in g.Rules)
			{
				var left = new HashSet<Nonterminal>();
				var right = new HashSet<Terminal>();
				First.Add(rule, new HashSet<Terminal>());
				foreach(var symbol in rule.RHS)
				{
					if(symbol is Terminal)//Skonci jestli to je terminal
					{
						right.Add(symbol as Terminal);
						break;
					}
					if(symbol is Nonterminal)
					{
						left.Add(symbol as Nonterminal);
						if (!EmptyNonterminals.Contains(symbol))//Jestli se neda vynulovat, skonci
						{
							break;
						}
					}
				}
				//First[rule].Add();
			}
		}
		private IGrammar g;
	}
}

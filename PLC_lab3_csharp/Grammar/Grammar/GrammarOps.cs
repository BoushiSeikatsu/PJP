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

		public ISet<Nonterminal> EmptyNonterminals { get; } = new HashSet<Nonterminal>();
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

		private IGrammar g;
	}
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from E:\Python Scripts\PJP_Project\PJProjekt\PJProjekt\Expr.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace PJProjekt {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ExprParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IExprListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ExprParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] ExprParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExprParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] ExprParser.ProgContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ExprParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStat([NotNull] ExprParser.StatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExprParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStat([NotNull] ExprParser.StatContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] ExprParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] ExprParser.ExprContext context);
}
} // namespace PJProjekt

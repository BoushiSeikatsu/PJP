﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from E:\Python Scripts\PJP_Project\PJProjekt\NewVersion\ANTLRGrammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace NewVersion {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ANTLRGrammarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IANTLRGrammarListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>declaration</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] ANTLRGrammarParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>declaration</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] ANTLRGrammarParser.DeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>emptyStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyStatement([NotNull] ANTLRGrammarParser.EmptyStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>emptyStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyStatement([NotNull] ANTLRGrammarParser.EmptyStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintExpr([NotNull] ANTLRGrammarParser.PrintExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintExpr([NotNull] ANTLRGrammarParser.PrintExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>readId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReadId([NotNull] ANTLRGrammarParser.ReadIdContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>readId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReadId([NotNull] ANTLRGrammarParser.ReadIdContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>writeId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWriteId([NotNull] ANTLRGrammarParser.WriteIdContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>writeId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWriteId([NotNull] ANTLRGrammarParser.WriteIdContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>blockStatements</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockStatements([NotNull] ANTLRGrammarParser.BlockStatementsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>blockStatements</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockStatements([NotNull] ANTLRGrammarParser.BlockStatementsContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>condStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondStatement([NotNull] ANTLRGrammarParser.CondStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>condStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondStatement([NotNull] ANTLRGrammarParser.CondStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>whileLoopStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileLoopStatement([NotNull] ANTLRGrammarParser.WhileLoopStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whileLoopStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileLoopStatement([NotNull] ANTLRGrammarParser.WhileLoopStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>doWhile</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoWhile([NotNull] ANTLRGrammarParser.DoWhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>doWhile</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoWhile([NotNull] ANTLRGrammarParser.DoWhileContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParens([NotNull] ANTLRGrammarParser.ParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParens([NotNull] ANTLRGrammarParser.ParensContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>arNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArNegation([NotNull] ANTLRGrammarParser.ArNegationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>arNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArNegation([NotNull] ANTLRGrammarParser.ArNegationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>lgNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLgNegation([NotNull] ANTLRGrammarParser.LgNegationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lgNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLgNegation([NotNull] ANTLRGrammarParser.LgNegationContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>mulDiv</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDiv([NotNull] ANTLRGrammarParser.MulDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDiv</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDiv([NotNull] ANTLRGrammarParser.MulDivContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>modulo</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModulo([NotNull] ANTLRGrammarParser.ModuloContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>modulo</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModulo([NotNull] ANTLRGrammarParser.ModuloContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>addSub</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSub([NotNull] ANTLRGrammarParser.AddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addSub</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSub([NotNull] ANTLRGrammarParser.AddSubContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>concat</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConcat([NotNull] ANTLRGrammarParser.ConcatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>concat</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConcat([NotNull] ANTLRGrammarParser.ConcatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompare([NotNull] ANTLRGrammarParser.CompareContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompare([NotNull] ANTLRGrammarParser.CompareContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>equality</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquality([NotNull] ANTLRGrammarParser.EqualityContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>equality</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquality([NotNull] ANTLRGrammarParser.EqualityContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>logicalAnd</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalAnd([NotNull] ANTLRGrammarParser.LogicalAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalAnd</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalAnd([NotNull] ANTLRGrammarParser.LogicalAndContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>logicalOr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOr([NotNull] ANTLRGrammarParser.LogicalOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalOr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOr([NotNull] ANTLRGrammarParser.LogicalOrContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] ANTLRGrammarParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] ANTLRGrammarParser.IntContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId([NotNull] ANTLRGrammarParser.IdContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId([NotNull] ANTLRGrammarParser.IdContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] ANTLRGrammarParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] ANTLRGrammarParser.FloatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] ANTLRGrammarParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] ANTLRGrammarParser.StringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] ANTLRGrammarParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] ANTLRGrammarParser.BoolContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] ANTLRGrammarParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] ANTLRGrammarParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] ANTLRGrammarParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] ANTLRGrammarParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] ANTLRGrammarParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] ANTLRGrammarParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] ANTLRGrammarParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] ANTLRGrammarParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveType([NotNull] ANTLRGrammarParser.PrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveType([NotNull] ANTLRGrammarParser.PrimitiveTypeContext context);
}
} // namespace NewVersion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\msi pc\Documents\PythonProjects\PJP\PJProjekt\NewVersion\ANTLRGrammar.g4 by ANTLR 4.6.6

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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IANTLRGrammarListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ANTLRGrammarBaseListener : IANTLRGrammarListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>emptyStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmptyStatement([NotNull] ANTLRGrammarParser.EmptyStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>emptyStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmptyStatement([NotNull] ANTLRGrammarParser.EmptyStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>writeId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWriteId([NotNull] ANTLRGrammarParser.WriteIdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>writeId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWriteId([NotNull] ANTLRGrammarParser.WriteIdContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>whileLoopStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileLoopStatement([NotNull] ANTLRGrammarParser.WhileLoopStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>whileLoopStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileLoopStatement([NotNull] ANTLRGrammarParser.WhileLoopStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>readId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReadId([NotNull] ANTLRGrammarParser.ReadIdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>readId</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReadId([NotNull] ANTLRGrammarParser.ReadIdContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>doWhile</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoWhile([NotNull] ANTLRGrammarParser.DoWhileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>doWhile</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoWhile([NotNull] ANTLRGrammarParser.DoWhileContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>blockStatements</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockStatements([NotNull] ANTLRGrammarParser.BlockStatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>blockStatements</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockStatements([NotNull] ANTLRGrammarParser.BlockStatementsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>declaration</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] ANTLRGrammarParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>declaration</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] ANTLRGrammarParser.DeclarationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>condStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondStatement([NotNull] ANTLRGrammarParser.CondStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>condStatement</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondStatement([NotNull] ANTLRGrammarParser.CondStatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintExpr([NotNull] ANTLRGrammarParser.PrintExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintExpr([NotNull] ANTLRGrammarParser.PrintExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParens([NotNull] ANTLRGrammarParser.ParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParens([NotNull] ANTLRGrammarParser.ParensContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompare([NotNull] ANTLRGrammarParser.CompareContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompare([NotNull] ANTLRGrammarParser.CompareContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] ANTLRGrammarParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] ANTLRGrammarParser.StringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBool([NotNull] ANTLRGrammarParser.BoolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBool([NotNull] ANTLRGrammarParser.BoolContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>lgNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLgNegation([NotNull] ANTLRGrammarParser.LgNegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lgNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLgNegation([NotNull] ANTLRGrammarParser.LgNegationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] ANTLRGrammarParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] ANTLRGrammarParser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>logicalAnd</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalAnd([NotNull] ANTLRGrammarParser.LogicalAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalAnd</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalAnd([NotNull] ANTLRGrammarParser.LogicalAndContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>addSub</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSub([NotNull] ANTLRGrammarParser.AddSubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>addSub</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSub([NotNull] ANTLRGrammarParser.AddSubContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>concat</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConcat([NotNull] ANTLRGrammarParser.ConcatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>concat</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConcat([NotNull] ANTLRGrammarParser.ConcatContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloat([NotNull] ANTLRGrammarParser.FloatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloat([NotNull] ANTLRGrammarParser.FloatContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>mulDiv</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDiv([NotNull] ANTLRGrammarParser.MulDivContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDiv</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDiv([NotNull] ANTLRGrammarParser.MulDivContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInt([NotNull] ANTLRGrammarParser.IntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInt([NotNull] ANTLRGrammarParser.IntContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>arNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArNegation([NotNull] ANTLRGrammarParser.ArNegationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>arNegation</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArNegation([NotNull] ANTLRGrammarParser.ArNegationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] ANTLRGrammarParser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] ANTLRGrammarParser.IdContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>logicalOr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOr([NotNull] ANTLRGrammarParser.LogicalOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>logicalOr</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOr([NotNull] ANTLRGrammarParser.LogicalOrContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>modulo</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModulo([NotNull] ANTLRGrammarParser.ModuloContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>modulo</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModulo([NotNull] ANTLRGrammarParser.ModuloContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>equality</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquality([NotNull] ANTLRGrammarParser.EqualityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>equality</c>
	/// labeled alternative in <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquality([NotNull] ANTLRGrammarParser.EqualityContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] ANTLRGrammarParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] ANTLRGrammarParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] ANTLRGrammarParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] ANTLRGrammarParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] ANTLRGrammarParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] ANTLRGrammarParser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ANTLRGrammarParser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimitiveType([NotNull] ANTLRGrammarParser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ANTLRGrammarParser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimitiveType([NotNull] ANTLRGrammarParser.PrimitiveTypeContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace NewVersion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\msi pc\Documents\PythonProjects\PJP\PLC_Lab9\PLC_Lab9\PLC_Lab9_expr.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace PLC_Lab9 {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPLC_Lab9_exprListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class PLC_Lab9_exprBaseListener : IPLC_Lab9_exprListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>declaration</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>declaration</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] PLC_Lab9_exprParser.DeclarationContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintExpr([NotNull] PLC_Lab9_exprParser.PrintExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintExpr([NotNull] PLC_Lab9_exprParser.PrintExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>mulDivMod</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulDivMod([NotNull] PLC_Lab9_exprParser.MulDivModContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>mulDivMod</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulDivMod([NotNull] PLC_Lab9_exprParser.MulDivModContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParens([NotNull] PLC_Lab9_exprParser.ParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParens([NotNull] PLC_Lab9_exprParser.ParensContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] PLC_Lab9_exprParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] PLC_Lab9_exprParser.AssignmentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>addSub</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAddSub([NotNull] PLC_Lab9_exprParser.AddSubContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>addSub</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAddSub([NotNull] PLC_Lab9_exprParser.AddSubContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] PLC_Lab9_exprParser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] PLC_Lab9_exprParser.IdContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloat([NotNull] PLC_Lab9_exprParser.FloatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloat([NotNull] PLC_Lab9_exprParser.FloatContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInt([NotNull] PLC_Lab9_exprParser.IntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInt([NotNull] PLC_Lab9_exprParser.IntContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] PLC_Lab9_exprParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] PLC_Lab9_exprParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] PLC_Lab9_exprParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] PLC_Lab9_exprParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] PLC_Lab9_exprParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] PLC_Lab9_exprParser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PLC_Lab9_exprParser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimitiveType([NotNull] PLC_Lab9_exprParser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PLC_Lab9_exprParser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimitiveType([NotNull] PLC_Lab9_exprParser.PrimitiveTypeContext context) { }

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
} // namespace PLC_Lab9

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\msi pc\Documents\PythonProjects\PJP\PJProjekt\Cviko7\Expr.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Cviko7 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ExprParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IExprVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>singleExpr</c>
	/// labeled alternative in <see cref="ExprParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleExpr([NotNull] ExprParser.SingleExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multipleExprEq</c>
	/// labeled alternative in <see cref="ExprParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleExprEq([NotNull] ExprParser.MultipleExprEqContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multipleExprCmp</c>
	/// labeled alternative in <see cref="ExprParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleExprCmp([NotNull] ExprParser.MultipleExprCmpContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>emptyStatement</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyStatement([NotNull] ExprParser.EmptyStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>writeId</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWriteId([NotNull] ExprParser.WriteIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>readId</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReadId([NotNull] ExprParser.ReadIdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>blockStatements</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockStatements([NotNull] ExprParser.BlockStatementsContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>loopStatement</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopStatement([NotNull] ExprParser.LoopStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>declaration</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] ExprParser.DeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>condStatement</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondStatement([NotNull] ExprParser.CondStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>printExpr</c>
	/// labeled alternative in <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintExpr([NotNull] ExprParser.PrintExprContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>compare</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompare([NotNull] ExprParser.CompareContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParens([NotNull] ExprParser.ParensContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] ExprParser.StringContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBool([NotNull] ExprParser.BoolContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>lgNegation</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLgNegation([NotNull] ExprParser.LgNegationContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>assignment</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] ExprParser.AssignmentContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>logicalAnd</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalAnd([NotNull] ExprParser.LogicalAndContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>addSub</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddSub([NotNull] ExprParser.AddSubContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloat([NotNull] ExprParser.FloatContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>mulDiv</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMulDiv([NotNull] ExprParser.MulDivContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInt([NotNull] ExprParser.IntContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>arNegation</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArNegation([NotNull] ExprParser.ArNegationContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>id</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitId([NotNull] ExprParser.IdContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>logicalOr</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalOr([NotNull] ExprParser.LogicalOrContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>equality</c>
	/// labeled alternative in <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEquality([NotNull] ExprParser.EqualityContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multipleCondsAnd</c>
	/// labeled alternative in <see cref="ExprParser.joinedCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleCondsAnd([NotNull] ExprParser.MultipleCondsAndContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>singleCond</c>
	/// labeled alternative in <see cref="ExprParser.joinedCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleCond([NotNull] ExprParser.SingleCondContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>multipleCondsOr</c>
	/// labeled alternative in <see cref="ExprParser.joinedCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleCondsOr([NotNull] ExprParser.MultipleCondsOrContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ExprParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] ExprParser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ExprParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] ExprParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ExprParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondition([NotNull] ExprParser.ConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ExprParser.joinedCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJoinedCondition([NotNull] ExprParser.JoinedConditionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ExprParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] ExprParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="ExprParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimitiveType([NotNull] ExprParser.PrimitiveTypeContext context);
}
} // namespace Cviko7

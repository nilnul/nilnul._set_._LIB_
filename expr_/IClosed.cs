using nilnul.obj;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace nilnul.set.expr_
{
	/// <summary>
	/// like <see cref="obj.ICall"/>|<see cref="obj.ICalc"/>, but here the inputs and output are expr, not literal values.
	/// </summary>
	public interface IClosed:IExpr, capsule_.ISubexprSameType { }

	public interface ClosedI<TEl>
		:IExpr,
		capsule_.ISubexprSameType
		,
		nilnul.set.ExprI<TEl>
		,
		nilnul.obj.expr_.typed_.generi_.ClosedI<HashSet<TEl>>
		//,
		//_closed_.ToCanonicI<TEl>

	{ }
	public class Closed<T>
		: nilnul.obj.expr_.typed_.generi_.Closed<HashSet<T>>
		,
		nilnul.set.expr_.ClosedI<T>
	{
		public Closed(obj.expr_.typed_.GeneriI<HashSet<T>> val) : base(val)
		{
		}

		public Closed(ExprI4 expr) : base(expr)
		{
		}

		public Closed(ConstantExpression constantExpression):base(
			new obj.Expr4(
			constantExpression
				)
		)
		{
		}
		public Closed(Expression constantExpression):base(
			new obj.Expr4(
			constantExpression
				)
		)
		{
		}

	}


}

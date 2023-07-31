using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_
{
	public abstract class TernaryA<T>
: nilnul.obj.calc_._ternary.OpArgs<
	nilnul.set.op_.TernaryI<T>
	,
	nilnul.set.expr_.closed_.CallI<T>
	,
	nilnul.set.expr_.closed_.CallI<T>
	,
	nilnul.set.expr_.closed_.CallI<T>

	>
		,
		set.expr_.closed_.CallI<T>
	{
		public TernaryA(op_.TernaryI<T> op, CallI<T> arg, CallI<T> arg1,CallI<T> arg2) : base(op, arg, arg1,arg2)
		{
		}

		public TernaryA(
			op_.TernaryI<T> op

			, Var<T> x
			, Var<T> y
			, Var<T> z
		) : base(
			op
			,
			
				x
			
			,
			
				y
			
			,
			
				z
			
		)
		{
		}
		public TernaryA(
			op_.TernaryI<T> op

			, ParameterExpression x
			, ParameterExpression y
			, ParameterExpression z
		) : this(
			op
			,
			new set.expr_.Var<T>(
				x
			)
			,
			new set.expr_.Var<T>(
				y
			)
			,
			new set.expr_.Var<T>(
				z
			)
		)
		{
		}

		public abstract CommonI<T> toCommon();

		public Ee<HashSet<T>> generi => new(
			new nilnul.obj.Expr4(
			(MethodCallExpression)this
			)
		);

		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => generi.ee.expr;

		public obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>> closed => new obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>>(this);

		IOp _call_.OpI.op =>base.op;

		static public implicit operator System.Linq.Expressions.MethodCallExpression(TernaryA<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(
expr.op),
				expr.op.GetType().GetMethod("op", new[] {
					typeof(HashSet<T>)
					,
					typeof(HashSet<T>)
					,
					typeof(HashSet<T>)
				}
				)

				,
				expr.arg.expr.ee
				,
				expr.arg1.expr.ee
				,
				expr.arg2.expr.ee
			);
		}
	}
}

using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.plain_
{
	public abstract class BinaryA<T>
: nilnul.obj.expr_.call_.BinaryA<
	nilnul.set.op_.BinaryI1<T>
	,
	nilnul.set.expr_.closed_.PlainI<T>
	,
	nilnul.set.expr_.closed_.PlainI<T>

	>
		,
		set.expr_.closed_.PlainI<T>
	{
		public BinaryA(op_.BinaryI1<T> op, PlainI<T> arg, PlainI<T> arg1) : base(op, arg, arg1)
		{
		}

		public BinaryA(
			op_.BinaryI1<T> op

			, ParameterExpression x
			,
			HashSet<T> constantExpression
		) : this(
			op
			,
			new set.expr_.Var<T>(
				x
			)
			,
			new set.expr_.closed_.plain_.Nary<T>(
				constantExpression
			)
		)
		{
		}

		public BinaryA(BinaryI1<T> op, Var<T> var, PlainI<T> plainI)
			:this(
				 op,
				 new unary_.Noop<T>(var)
				 ,
				 plainI
				)
		{
		}

		public Ee<HashSet<T>> generi => new(
			new nilnul.obj.Expr4(
			(MethodCallExpression)this
			)
		);

		public		 obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => generi.ee.expr;

		public obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>> closed => new obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>>(this);

		public abstract CommonI<T> toCommon();

		static public implicit operator System.Linq.Expressions.MethodCallExpression(BinaryA<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(
expr.op),
				expr.op.GetType().GetMethod("op", new[] { typeof(bool), typeof(bool) })

				,
				expr.arg.expr.ee
				,
				expr.arg1.expr.ee
			);
		}

	
	}
}

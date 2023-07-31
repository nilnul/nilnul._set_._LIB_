using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._expr;
using nilnul.bit.var;
using nilnul.obj._expr_;
using System.Linq.Expressions;
using nilnul.obj.expr.be_.typed_.generi.vow;

namespace nilnul.set.expr_.call_
{
	public interface IUnary : expr_.ICall { }

	public class Unary<T>
		:
		nilnul.obj.expr_.call_.UnaryA<
			nilnul.set.op_.UnaryI1<T>, nilnul.set.ExprI<T>
		>
		,
		nilnul.set.ExprI<T>
		,
		set.expr_.call_.IUnary
		,
		set.expr_._call_.OpI
		,
		set.expr_.CallI<T>

	{

		public Unary(
			set.op_.UnaryI1<T> op,
				set.ExprI<T> x
		)
			: base(op, x)
		{

		}
		public Unary(
			set.op_.UnaryI1<T> op
			,
ParameterExpression x
		) : this(op,

			new nilnul.set.Expr<T>(x)
		)
		{
		}
		public Unary(
			set.op_.UnaryI1<T> op,

			set.expr_.Var<T> x

			)
			: base(op,
				(x)
			)
		{

		}





		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => new obj._expr.expr0lamda.be_.nonlamda.vow.Ee(
(MethodCallExpression)this
)
		;
		public Ee<HashSet<T>> generi => new Ee<HashSet<T>>(
			this
		);

		IOp _call_.OpI.op => base.op;

		public override string ToString()
		{
			if (this.arg is _call_.OpI arg9op)
			{
				if (set.op.co.be_.lex_.Precedence.Unison.be(this.op, arg9op.op))
				{
					return $"{this.op}({arg})";
				}
				return $"{this.op}{arg}";


			}
			return $"{this.op}({arg})"; /// defensive; 

		}


		static public implicit operator System.Linq.Expressions.MethodCallExpression(Unary<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(expr.op)
				,
				expr.op.GetType().GetMethod("op", new[] { typeof(ISet<T>) })

				,
				expr.arg.expr.ee

			);
		}
	}

}

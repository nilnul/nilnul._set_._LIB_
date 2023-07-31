using nilnul.bit._expr.untyped.be.vow;
using nilnul.bit.op_.binary_;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.call_
{
	public class Binary<TEl>
: nilnul.obj.expr_.call_.BinaryA<
	nilnul.set.op_.BinaryI<TEl>
	,
	nilnul.set.ExprI<TEl>
	,
	nilnul.set.ExprI<TEl>

	>
		,
		set.ExprI<TEl>
		,
		set.expr_.ICall
		,
		set.expr_.CallI<TEl>
	{
		public Binary(op_.BinaryI<TEl> op, ExprI<TEl> arg, ExprI<TEl> arg1) : base(op, arg, arg1)
		{
		}

		public Binary(
			op_.BinaryI<TEl> op

			, ParameterExpression x
			,
			ConstantExpression constantExpression
		) : this(
			op
			,
			new set.Expr<TEl>(
				x
			)
			,
			new set.Expr<TEl>(
				constantExpression
			)
		)
		{
		}

		public Ee<HashSet<TEl>> generi => new(
			new nilnul.obj.Expr4(
			(MethodCallExpression)this
			)
		);

		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => generi.ee.expr;

		IOp _call_.OpI.op => base.op;


		public override string ToString()
		{
			var formerArgAsTxt = this.arg.ToString();

			if (this.arg is _call_.OpI arg9op)
			{
				if (!set.op.co.be_.lex_.Precedence.Unison.be(arg9op.op, this.op))
				{
					formerArgAsTxt = $"({formerArgAsTxt})";
				}
			}
			else
			{
					formerArgAsTxt = $"({formerArgAsTxt})";/// defensive; 

			}

			var latterArgAsTxt = this.arg1.ToString();

			if (this.arg1 is _call_.OpI arg9op1)
			{
				if (set.op.co.be_.lex_.Precedence.Unison.be(this.op,arg9op1.op ))
				{
					latterArgAsTxt = $"({latterArgAsTxt})";
				}
			}
			else
			{
					latterArgAsTxt = $"({latterArgAsTxt})";/// defensive; 

			}


			return $"{formerArgAsTxt}{this.op}{latterArgAsTxt}";

		}

		static public implicit operator System.Linq.Expressions.MethodCallExpression(Binary<TEl> expr)
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

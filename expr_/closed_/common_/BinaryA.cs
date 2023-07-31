using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.expr_.typed_;
using nilnul.set.expr_.var.sety.ballot.maxterm.coefeds_.isovars_.unlike;
using nilnul.set.expr_.var.sety.ballot.minterms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_
{
	public abstract class BinaryA<T>
: nilnul.obj.expr_.call_.BinaryA<
	nilnul.set.op_.BinaryI1<T>
	,
	nilnul.set.expr_.closed_.CommonI<T>
	,
	nilnul.set.expr_.closed_.CommonI<T>

	>
		,
		set.expr_.closed_.CommonI<T>
	{
		public BinaryA(op_.BinaryI1<T> op, CommonI<T> arg, CommonI<T> arg1) : base(op, arg, arg1)
		{
		}
		public BinaryA(op_.BinaryI1<T> op, Var<T> arg, CommonI<T> arg1) : base(op, arg, arg1)
		{
		}

		public BinaryA(
			op_.BinaryI1<T> op

			, ParameterExpression x
			,
			ParameterExpression constantExpression
		) : this(
			op
			,
			new set.expr_.Var<T>(
				x
			)
			,
			new set.expr_.Var<T>(
				constantExpression
			)
		)
		{
		}


		public Ee<HashSet<T>> generi => new(
			new nilnul.obj.Expr4(
			(MethodCallExpression)this
			)
		);

		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => generi.ee.expr;

		public obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>> closed => new obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>>(this);

		IOp _call_.OpI.op => base.op;

		public override string ToString()
		{
			var formerArgAsTxt = this.arg.ToString();


			if (!set.op.co.be_.lex_.Precedence.Unison.be(arg.op, this.op))
			{
				formerArgAsTxt = $"({formerArgAsTxt})";
			}


			var latterArgAsTxt = this.arg1.ToString();


			if (set.op.co.be_.lex_.Precedence.Unison.be(this.op, arg1.op))
			{
				latterArgAsTxt = $"({latterArgAsTxt})";
			}



			return $"{formerArgAsTxt} {this.op} {latterArgAsTxt}";

		}


		public abstract Sop<T> toSop();

		//public abstract Product<T> toPos();

		static public implicit operator System.Linq.Expressions.MethodCallExpression(BinaryA<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(
expr.op),
				expr.op.GetType().GetMethod("op", new[] { typeof(HashSet<T>), typeof(HashSet<T>) })

				,
				expr.arg.expr.ee
				,
				expr.arg1.expr.ee
			);
		}
	}
}

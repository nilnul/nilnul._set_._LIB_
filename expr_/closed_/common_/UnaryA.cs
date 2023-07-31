using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.expr.stati._stati;
using nilnul.bit.var.stati;
using nilnul.bit.var.stati.s;
using nilnul.obj.expr.stati._stati;
using nilnul.bit.expr.stati;
using nilnul._expr;
using nilnul.bit.var;
using nilnul.obj._expr_;
using nilnul.bit._expr.untyped.be.vow;
using System.Linq.Expressions;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.set.expr_.var.sety.ballot.minterms;

namespace nilnul.set.expr_.closed_.common_
{
	public interface IUnary:ICall { }

	public interface UnaryI<T>
		:

		nilnul.set.expr_.closed_.CommonI<T>
		,
		IUnary
	{
	}
	public abstract class UnaryA<T>
		:
		nilnul.obj.expr_.call_.UnaryA<
			nilnul.set.op_.UnaryI1<T>, nilnul.set.expr_.closed_.CommonI<T>
		>
		,
		UnaryI<T>

	{

		public UnaryA(
			set.op_.UnaryI1<T> op
			,
			set.expr_.closed_.CommonI<T> x
		)
			: base(op, x)
		{

		}
		public UnaryA(
			set.op_.UnaryI1<T> op,

			set.expr_.Var<T> x

			)
			: base(
				op
				,
				(x)
			)
		{

		}
		public UnaryA(
			set.op_.UnaryI1<T> op
			,
ParameterExpression x
		)
			: this(
				  op,

			new nilnul.set.expr_.Var<T>(x)
		)
		{
		}





		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => new obj._expr.expr0lamda.be_.nonlamda.vow.Ee(
(MethodCallExpression)this
)
		;
		public Ee<HashSet<T>> generi => new (
			this
		);

		 

		public obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>> closed => new obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>>(this);

		IOp _call_.OpI.op => base.op;


		public override string ToString()
		{
			if (set.op.co.be_.lex_.Precedence.Unison.be(this.op, arg.op))
			{
				return $"{this.op}({arg})";
			}
			return $"{this.op}{arg}";


		}

		static public implicit operator System.Linq.Expressions.MethodCallExpression(UnaryA<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(expr.op)
				,
				expr.op.GetType().GetMethod("op", new[] { typeof(HashSet<T>) })

				,
				expr.arg.expr.ee

			);
		}
	
		//public abstract CommonI<T> toCommon();
		public abstract Sop<T> toSop();
	}

}

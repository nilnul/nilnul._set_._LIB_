using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr_.typed_;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.unary_
{
	[Obsolete(nameof(set.expr_.Var<T>))]
	public class Noop<T>
		:
		nilnul.obj.calc_._unary.OpArg<
			nilnul.set.op_.UnaryI1<T>, nilnul.set.expr_.Var<T>
			>
		//closed_.call_.UnaryA<T>
		,
		closed_.CallI<T>
	{
		public Noop(Var<T> arg) : base(set.op_.unary_.Noop<T>.Unison, arg)
		{
		}


		public Noop(ParameterExpression x) : this(new Var<T>(x))
		{
		}



		public obj._expr.expr0lamda.be_.nonlamda.vow.Ee expr => new obj._expr.expr0lamda.be_.nonlamda.vow.Ee(
(MethodCallExpression)this
)
		;

		public obj.expr.be_.typed_.generi.vow.Ee<HashSet<T>> generi => new(
			this
		);



		public obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>> closed => new obj.expr_.typed_.generi.be_.closed.vow.Ee<HashSet<T>>(this);


		static public implicit operator System.Linq.Expressions.MethodCallExpression(Noop<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(expr.op)
				,
				expr.op.GetType().GetMethod("op", new[] { typeof(HashSet<T>) })

				,
				expr.arg.expr.ee

			);
		}


		public CommonI<T> toCommon()
		{

			return (this.arg);
		}
	}
}

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

namespace nilnul.set.expr_.closed_.plain_
{
	public interface IUnary:ICall { }


	public abstract class UnaryA<T>
		:
		nilnul.obj.expr_.call_.UnaryA<
			nilnul.set.op_.UnaryI1<T>, nilnul.set.expr_.closed_.PlainI<T>
		>
		,
		nilnul.set.expr_.closed_.PlainI<T>
		,
		IUnary

	{

		public UnaryA(
			set.op_.UnaryI1<T> op,
				set.expr_.closed_.PlainI<T> x
		)
			: base(op, x)
		{

		}
		public UnaryA(
			set.op_.UnaryI1<T> op,

			set.expr_.closed_.plain_.unary_.Noop<T> x

			)
			: base(op,

				  
				(x)
			)
		{

		}
		public UnaryA(
			set.op_.UnaryI1<T> op,

			set.expr_.Var<T> x

			)
			: this(op,

				new   set.expr_.closed_.plain_.unary_.Noop<T>(x)
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

		public abstract CommonI<T> toCommon();

		static public implicit operator System.Linq.Expressions.MethodCallExpression(UnaryA<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(expr.op)
				,
				expr.op.GetType().GetMethod("op", new[] { typeof(ISet<T>) })

				,
				expr.arg.expr.ee

			);
		}

		//static public UnaryA<T> OfComplement(ClosedI<T> closed, HashSet<T> omega) {
		//	return new UnaryA<T>(
		//		new nilnul.set.op_.unary_.Complement<T>(omega)
		//		,
		//		closed
		//	);
		//}
		/// <summary>
		/// empty set as the omega. this is useless unless taken as a placeholder in expr;
		/// </summary>
		/// <param name="closed"></param>
		/// <returns></returns>
		//static public UnaryA<T> OfComplement(ClosedI<T> closed) {
		//	return OfComplement(closed, new HashSet<T>());
		//}

	}

}

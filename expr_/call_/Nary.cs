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
using nilnul.set.expr_.closed_._call_;
using nilnul.set.expr_.closed_;
using nilnul.set.expr_.var.sety.ballot.minterms;
using nilnul.set.expr_.var.sety.ballot.maxterm.coefeds_.isovars_.unlike;

namespace nilnul.set.expr_.call_
{
	public interface INary:ICall { }

	public interface NaryI<T>
		:
		nilnul.set.expr_.CallI<T>
		,
		INary
	{
	}

	public  class Nary<T>
		:
		nilnul.obj.Box_ofIn<
			nilnul.set.op_.Nary<T>
		>
		,
		NaryI<T>
		,
		expr_.CallI<T>
		//,
		//expr_.closed_.CommonI<T>
		//,
		//expr_.closed_.CallI<T>
		,
		expr_.closed_.common_.INary

	{
		public Nary(in HashSet<T> val) : this(new op_.Nary<T>(val))
		{
		}

		public Nary(HashSet<T> x) :this(new op_.Nary<T>(x))
		{
		}


		public Nary(in op_.Nary<T> val) : base(val)
		{
		}

		public Nary(op_.Nary<T> x) : base(x)
		{
		}

		public Nary(ConstantExpression constantExpression):this((HashSet<T>) constantExpression.Value )
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

		public IOp op => base.boxed;

		//public Product<T> toPos()
		//{
		//	return  Product<T>.Of(
		//		this.boxed.op()
		//	);
		//}

		//public CommonI<T> toCommon()
		//{
		//	return this;
		//}


		public override string ToString()
		{
			return $"{op}";
		}


		static public implicit operator System.Linq.Expressions.MethodCallExpression(Nary<T> expr)
		{
			return System.Linq.Expressions.Expression.Call(
				Expression.Constant(expr.boxed)
				,
				expr.boxed.GetType().GetMethod(
					"op"
					//, new[] {  }
				)

			);
		}


	}

}

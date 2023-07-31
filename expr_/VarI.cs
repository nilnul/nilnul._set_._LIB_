using nilnul.obj.expr_.typed_.generi.be_.closed.vow;
using nilnul.set.expr_.closed_;
using nilnul.set.expr_.var.sety.ballot.maxterm.coefeds_.isovars_.unlike;
using nilnul.set.expr_.var.sety.ballot.minterms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_
{
	public class Var<T>
		: nilnul.obj.expr_.typed_.generi_.Var<HashSet<T>>
		,
		set.ExprI<T>
		,
		set.expr_.ClosedI<T>
		,
		set.expr_.closed_.CallI<T>
		,
		set.expr_.closed_.CommonI<T>
		,
		closed_.common_.unary_.INoop
		,
		expr_.call_.unary_.INop

	{
		public IOp op => set.op_.unary_.Noop<T>.Unison;

		public Var(ParameterExpression val) : base(val)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">
		/// exception would be thrown if the name conflicts with another when prasing an expr;
		/// </param>
		public Var(string s) : base(s)
		{
		}

		public Var() :
this(
			Expression.Parameter(typeof(bool))
		)

		{
		}

		public bool Equals(Var<T> other)
		{
			return obj.expr_.var.Eq.Singleton.Equals(this.sys, other.sys);
			//throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return obj. expr_.var.Eq.Singleton.GetHashCode(this.sys);
		}

		static public  bool operator ==(
			Var<T> x,
			Var<T> y

			) {
			return obj. expr_.var.Eq.Singleton.Equals(x.sys, y.sys);

		}

		public override bool Equals(object obj)
		{
			if (obj is Var<T> var)
			{
				return this == var;
			}
			return base.Equals(obj);
		}

		public CommonI<T> toCommon()
		{
			return this;
		}

	

		public Sop<T> toSop()
		{
			return  Sop<T>.Of(
				this
			);
		}

		//public Product<T> toPos()
		//{

		//	return Product<T>.Of(this);
		//}

		static public  bool operator !=(
			Var<T> x,
			Var<T> y

			) {
			return !(x== y);

		}

	}

}

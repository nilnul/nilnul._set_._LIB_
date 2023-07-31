using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.nary_
{
	public class Omega<T>
		:
		nilnul.set.expr_.call_.Nary<T>
		,
		closed_.CommonI<T>
		,
		INary
	{
		public Omega(in HashSet<T> val) : base(val)
		{
		}

		public Omega(HashSet<T> x) : base(x)
		{
		}

		public Omega(in Nary<T> val) : base(val)
		{
		}

		public Omega(Nary<T> x) : base(x)
		{
		}

		public Omega(ConstantExpression constantExpression) : base(constantExpression)
		{
		}
	}
}

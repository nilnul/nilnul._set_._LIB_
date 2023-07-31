using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.call_.unary_
{
	public interface INop { }
	public class Noop<T>
		: expr_.call_.Unary<T>,INop

	{
		public Noop( ExprI<T> x) : base(set.op_.unary_.Noop<T>.Unison, x)
		{
		}

		public Noop( ParameterExpression x) : base(set.op_.unary_.Noop<T>.Unison, x)
		{
		}

		public Noop(Var<T> x) : base(set.op_.unary_.Noop<T>.Unison, x)
		{
		}

		public override string ToString()
		{
			return $"{arg}"; /// defensive; 

		}
	}
}

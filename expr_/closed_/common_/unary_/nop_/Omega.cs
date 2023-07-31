using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.unary_.nop_
{
	public class Omega<T>
		: closed_.common_.unary_.Noop<T>
		,
		closed_.CommonI<T>
	{
		

		public Omega( ParameterExpression x) : base( x)
		{
		}
		public Omega( string x) : this(
			ParameterExpression.Parameter(
				typeof(HashSet<T>),x
			)
		)
		{
		}
		public Omega( ) : this(
			"u"
		)
		{
		}



		public override CommonI<T> toCommon()
		{
			return this;
		}
	}
}

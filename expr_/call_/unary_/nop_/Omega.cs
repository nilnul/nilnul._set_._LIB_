using nilnul.obj.expr_.typed_.generi.be_.closed.vow;
using nilnul.set.expr_.closed_;
using nilnul.set.expr_.var.sety.ballot.minterms;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.call_.unary_.nop_
{
	[Obsolete(nameof(expr_.var_.Omega<T>))]
	public class Omega<T>
		: Noop<T>
		,
		expr_.closed_.CommonI<T>
		,
		expr_.closed_.CallI<T>

	{
		public Ee<HashSet<T>> closed => new Ee<HashSet<T>>(this);

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

		public CommonI<T> toCommon()
		{
			return this;
		}

		public Sop<T> toSop()
		{
			return Sop<T>.Of(
				this.arg
			);
		}
	}
}

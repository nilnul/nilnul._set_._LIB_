using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.unary_
{
	public class Complement<T>
		: closed_.common_.UnaryA<T>
		,
		closed_.CommonI<T>
	{

		public Complement(
			HashSet<T> arg
			,
			closed_.CommonI<T> arg1
		) : base(
			new set.op_.unary_.Complement<T>(arg)
			, arg1
		)
		{
		}

		public Complement(
			HashSet<T> arg
			, ParameterExpression x
		) : base(
			new set.op_.unary_.Complement<T>(arg)
			,
			x
		)
		{
		}

		public override CommonI<T> toCommon()
		{
			return this;
		}
	}
}

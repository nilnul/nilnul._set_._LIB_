using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.plain_.unary_
{
	public class Noop<T>
		: closed_.plain_.UnaryA<T>
		,
		plain_.CommonI<T>
	{
		public Noop( closed_.PlainI<T> arg) : base(set.op_.unary_.Noop<T>.Unison, arg)
		{
		}

		public Noop( ParameterExpression x) : base(set.op_.unary_.Noop<T>.Unison, x)
		{
		}

		public override CommonI<T> toCommon()
		{
			return this;
		}
	}
}

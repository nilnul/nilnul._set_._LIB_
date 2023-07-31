using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.unary_
{
	public class Complement<T>
		: closed_.call_.UnaryA<T>
		,
		closed_.CommonI<T>
	{
		public Complement( closed_.CallI<T> arg) : base(set.op_.unary_.Noop<T>.Unison, arg)
		{
		}

		public Complement( ParameterExpression x) : base(set.op_.unary_.Noop<T>.Unison, x)
		{
		}

		public override CommonI<T> toCommon()
		{
			return new common_.unary_.Complement<T>(this.arg.toCommon());
		}
	}
}

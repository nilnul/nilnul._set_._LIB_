using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.binary_
{
	public class Union<T>
		: closed_.call_.BinaryA<T>
	{
		public Union( CallI<T> arg, CallI<T> arg1) : base(set.op_.binary_.Union<T>.Unison, arg, arg1)
		{
		}

		public Union( ParameterExpression x, ParameterExpression constantExpression) : base(set.op_.binary_.Union<T>.Unison, x, constantExpression)
		{
		}

		public override CommonI<T> toCommon()
		{
			return new closed_.common_.binary_.Union<T>(
				arg.toCommon()
				,
				arg1.toCommon()
			);
		}
	}
}

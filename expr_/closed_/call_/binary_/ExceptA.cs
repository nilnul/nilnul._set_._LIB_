using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.binary_
{
	public abstract class ExceptA<T>
		: closed_.call_.BinaryA<T>

	{
		public ExceptA( CallI<T> arg, CallI<T> arg1) : base(
			nilnul.set.op_.binary_.Except<T>.Unison
			, arg, arg1
		)
		{
		}

		public ExceptA(
			ParameterExpression x, ParameterExpression constantExpression
		)
		: base(
				nilnul.set.op_.binary_.Except<T>.Unison
				,
				x
				  ,
				constantExpression
		)
		{
		}

		
	}
}

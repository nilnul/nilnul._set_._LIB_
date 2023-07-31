using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.plain_.binary_
{
	public class Concur<T>
		: BinaryA<T>
	{
		public Concur(BinaryI1<T> op, PlainI<T> arg, PlainI<T> arg1) : base(op, arg, arg1)
		{
		}

		public Concur(BinaryI1<T> op, ParameterExpression x, HashSet<T> constantExpression) : base(op, x, constantExpression)
		{
		}

		public override CommonI<T> toCommon()
		{

			return new 
		}
	}
}

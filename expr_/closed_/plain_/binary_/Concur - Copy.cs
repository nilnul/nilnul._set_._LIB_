using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.plain_.binary_
{
	public class Intersect<T>
		: BinaryA<T>
	{
		public Intersect( PlainI<T> arg, PlainI<T> arg1) : base(set.op_.binary_.Intersect<T>.Singleton, arg, arg1)
		{
		}

		public Intersect(BinaryI<T> op, ParameterExpression x, ConstantExpression constantExpression) : base(op, x, constantExpression)
		{
		}


		public closed_.CommonI<T> toCommon() {
			return new 
		}

		public nilnul.bit.expr_.capsule.to_._calibrate.TruthTable calibrate() {

		}
	}
}

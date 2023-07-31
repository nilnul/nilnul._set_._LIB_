using nilnul.set.expr_.var.sety.ballot.minterms;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.binary_
{
	public class Union<T>
		: closed_.common_.BinaryA<T>
	{
		public Union( CommonI<T> arg, CommonI<T> arg1) : base(
			nilnul.set.op_.binary_.Union<T>.Unison

			,
			arg, arg1)
		{
		}

		public Union( ParameterExpression x, ParameterExpression y)
			: base(
			nilnul.set.op_.binary_.Union<T>.Unison

				  , x, y)
		{
		}

		public override Sop<T> toSop()
		{
			return new Sop<T>(
				this.arg.toSop().minterms.Concat( this.arg1.toSop().minterms)
			);
		}
	}
}

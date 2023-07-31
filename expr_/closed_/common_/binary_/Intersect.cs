using nilnul.set.expr_.var.sety.ballot.minterms;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.binary_
{
	public class Intersect<T>
		: closed_.common_.BinaryA<T>

	{
		public Intersect( CommonI<T> arg, CommonI<T> arg1) : base(
			nilnul.set.op_.binary_.Intersect<T>.Singleton
			, arg, arg1
		)
		{
		}

		public Intersect( ParameterExpression x, ParameterExpression y)
			: base(
			nilnul.set.op_.binary_.Intersect<T>.Singleton

				  , x, y)
		{
		}

		public override Sop<T> toSop()
		{
			/// each arg is toSop();
			/// eg:
			/// (xy |x!z)  &  (x | y!z)
			/// now <see cref="except_.comple_._OfMintermX.OfMinterm{T}(var.sety.ballot.Minterm{T})"/>
			///
			
			var newMintermEs =  this.arg.toSop().minterms.SelectMany(
				minterm0=>	this.arg1.toSop().minterms.Select(
					minterm1=>	   minterm0.ballot.Concat(
						minterm1.ballot
					)	///eg: x&x, x&!x, which is disallowed
				)
			) ;

			return new Sop<T>(
				newMintermEs.Select(
					votes=> var.valves._ProductX.ProductAsMinterm0nul<T>(votes)
				).Where(x=>x is not null)
			);

		}
	}
}

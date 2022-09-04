using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix.twoDimensionalArray._be
{
	public partial class Square< TElement>
		:nilnul.bit.op.predicate.UnaryI< TElement[,]>
	{

		static public bool Eval(TElement[,] m) {
			if (m==null)
			{


				throw new ArgumentNullException();
				
			}
			return m.GetLongLength(0) == m.GetLongLength(1);
		
		}

		public partial class Be : nilnul.bit.op.predicate.Unary<TElement[,]> {
			public Be()
				:base(Square<TElement>.Eval)
			{

			}
		}

		public class Asserted:nilnul.bit.op.predicate.unary.Asserted<TElement[,],Be>
		{
			public Asserted(TElement[,] val)
				:base(val)
			{

			}
			
		}




		public bool eval(TElement[,] x)
		{
			return Eval(x);
			throw new NotImplementedException();
		}
	}
}

using nilnul.set.expr_.var.set.ballot.maxterm.coefeds_.isovars_.unlike;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.binary_.except_._comple_.t0Pos_
{
	[Obsolete("we cannot achieve our goal for " + nameof(expr_.var.set.ballot.maxterm.coefeds),true)]
	public abstract class OfCoefedsA<T>
		:closed_._common_.ToProductOfSumI<T>
	{

		public  Product<T> toPos()
		{
			//var arg2pos = this.arg1.toPos();

			/// complement the pos such as:
			/// (0+x+!z) ({1,2} + x +y )
			/// we get:
			/// ! (  (0+x+y!z) ({1,2} + xy +y!z )  )
			///
			///  = !(0+x+y!z) + !({1,2} + xy +y!z )
			///  = !0!x! (y!z)  + !{1,2} !(xy) !(y!z)
			///  = !x(!y + z) + !{1,2} (!x+!y) (!y + z)
			///  =(!y+z) ( !x + !{1,2} (!x+!y) )
			///  = (!y+z) (!x + !{1,2} !x + !{1,2} !y )
			///  = (!y+z) (!x (omega + !{1,2} ) + !{1,2} !y )
			///  =(!y+z) (!x +!{1,2} !y )
			///  =(!y+z) (!x +!w !y )
			///  =(!y+z) (  (!x + !w)   (!x + !y )  )
			///  =(!y+z)   (!x + !w)   (!x + !y )  
			///
			///  here the !w cannot be computed into a literal, as the omega is a var, not a val.
			///
			///
			/// remark:
			///  we cannot achieve our goal for <see cref="expr_.var.set.ballot.maxterm.coefeds"/>, as for a literal set, it's complement cannot be a literal set anymore, due to that the omega is a var.
			///  If the omega were a literal, we can achieve our goal.
			///  For the omega to be a var, we need to have a var for any literal set.

			throw new NotImplementedException();

		}
	}
}
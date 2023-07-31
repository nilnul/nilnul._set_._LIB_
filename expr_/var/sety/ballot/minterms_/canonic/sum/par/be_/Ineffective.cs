using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum.par.be_
{
	public class Ineffective
	{
		static public bool IsIneffective<TEl>(Sum<TEl> sum, Var<TEl> var) {
			/// pertition the interpretations into two groups: one with var, one with the var's complement
			///
			var g=sum.distinct.eeByRef.GroupBy(
				g => g.ballot[var]
			).ToArray();

			/// this is a sum of product. if the two groups are the same, and we multiple them with the complements pair, the sum would be like nilling out the var.
			return minterms_.canonic.co_.isovars.be_._EqAsSetX._SameSet_01canonic1isovars<TEl>(
				g.Where(x => x.Key).SelectMany(y=>y)
				,
				g.Where(x=>!x.Key).SelectMany(y=>y)
			);
		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic.sum.pars_.ineffective
{
	static public class _RemoveX
	{

		static public IEnumerable<Ballot<TEl>> Remove<TEl>(Sum<TEl> sum)
		{

			var vars = sum.vars;

			var ballots = sum.distinct.eeByRef.Select(m=>m.ballot);

			foreach (var var in vars)
			{

				/// pertition the interpretations into two groups: one with var, one with the var's complement
				///
				var g = ballots.GroupBy(
					g => g[var]
				).ToArray();

				/// this is a sum of product. if the two groups are the same, and we multiple them with the complements pair, the sum would be like nilling out the var.
				///
				var lefthalf = g.Where(x => x.Key).SelectMany(y => y).Select(
					b=>b.Where(k=>k.Key!=var)
				).Select(bb=>new Ballot<TEl>(bb) );
				var rightHalf = g.Where(x => !x.Key).SelectMany(y => y).Select(
					b=>b.Where(k=>k.Key!=var)
				).Select(bb=>new Ballot<TEl>(bb) );;

				var t = minterms_.canonic.co_.isovars.be_._EqAsSetX._EqAsSet_0canonic_1canonic_01isokeys<TEl>(
					lefthalf
					,
					rightHalf
				);

				if (t)
				{
					ballots = lefthalf
						//	.Select(
						//	b =>
						//	{
						//		var t = new Ballot<TEl>(b);

						//		//t.Remove(var);

						//		return t;

						//	}
						//)
					;
				}
			}

			return ballots;

		}
	}
}
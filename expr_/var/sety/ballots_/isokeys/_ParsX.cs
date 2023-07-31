using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballots_.isokeys
{
	static public  class _ParsX
	{
		static public IEnumerable<Var<TEl>> Pars<TEl>(this IEnumerable<Ballot<TEl>> ballots) {
			return  ballots.FirstOrDefault()?.Keys ?? Enumerable.Empty<Var<TEl>>();
		}
	}
}

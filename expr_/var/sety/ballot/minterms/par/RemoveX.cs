using nilnul.set.expr_.var.sety.ballot.minterms_.canonic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms.par
{
	static public class _RemoveX
	{
		static public IEnumerable<Ballot<TEl>> RemoveAsBallots<TEl>(Sum<TEl> sum, Var<TEl> var)
		{
			return sum.distinct.eeByRef.Select(
				minterm =>{

					var t = new Ballot<TEl>(minterm.ballot);

					t.Remove(var);

					return t;

				}
			);
		}
	}
}
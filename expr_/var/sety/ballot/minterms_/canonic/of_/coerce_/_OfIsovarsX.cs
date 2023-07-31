using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterms_.canonic.of_.coerce_
{
	static public class _OfIsovarsX

	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">isovars, but might be nondistinct.</param>
		/// <returns></returns>
		static public IEnumerable<Minterm<TEl>> _RemoveRepetives_0isovars<TEl>(IEnumerable<Minterm<TEl>> val)
		{

			return val.Distinct(
				minterm.re_.isovars_._eq._SameVal4EachVar<TEl>.Unison
			);
		}


	}
}

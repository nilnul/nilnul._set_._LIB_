using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballots_.isokeys_.distinct.of_.coerce_
{
	static public class _OfIsovarsX

	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="val">isovars, but might be nondistinct.</param>
		/// <returns></returns>
		static public IEnumerable<Ballot<TEl>> _RemoveRepetives_0isokeys<TEl>(IEnumerable<Ballot<TEl>> val)
		{

			return val.Distinct(
				ballot.re_.isokeys_._eq._SameVal4EachVar<TEl>.Unison
			);
		}

	}
}

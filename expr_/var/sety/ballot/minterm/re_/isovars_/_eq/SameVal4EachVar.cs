using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterm.re_.isovars_._eq
{
	/// <summary>
	/// given that:
	///		minterm of isovars,
	///	to determine whether the two are equal.
	///	Note this cannot be taken as an equality comparer, as the assumption is not guranteed, and can only be applied when the assumption is true.
	///	This is mainly used in <see cref="minterms_.canonic.of_.coerce_._OfIsovarsX"/>
	/// </summary>
	public class _SameVal4EachVar<TEl>
		: minterm.EqI<TEl>

	{
		public bool Equals(Minterm<TEl> x, Minterm<TEl> y)
		{
			return ballot.re_.isokeys_._eq._SameVal4EachVar<TEl>.Unison.Equals(
				x.ballot
				,
				y.ballot
			);
		}

		public int GetHashCode(Minterm<TEl> obj)
		{
			return 0;
		}


		static public _SameVal4EachVar<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<_SameVal4EachVar<TEl>>.Unison;
			}
		}

	}
}

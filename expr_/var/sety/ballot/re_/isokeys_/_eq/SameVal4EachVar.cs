using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.re_.isokeys_._eq
{
	/// <summary>
	/// assumes that the vars are same.
	/// the assumption might be not true, so this cannot be taken as an equalityCompare, and can only be applied for <see cref="minterms_.canonic.of_.coerce_._OfIsovarsX"/> where the assumption is true;
	/// </summary>
	public class _SameVal4EachVar<TEl>
		: ballot.EqI<TEl>
	{
		public bool Equals(Ballot<TEl> x, Ballot<TEl> y)
		{
			return x.All(
				kv => y[kv.Key] == kv.Value
			);
		}

	


		public int GetHashCode(Ballot<TEl> obj)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterm
{
	/// <summary>
	/// </summary>
	public class Eq<TEl>
		: minterm.EqI<TEl>

	{
		public bool Equals(Minterm<TEl> x, Minterm<TEl> y)
		{
			return ballot.Eq<TEl>.Unison.Equals(
				x.ballot
				,
				y.ballot

			);
		}

		public int GetHashCode(Minterm<TEl> obj)
		{
			return ballot.Eq<TEl>.Unison.GetHashCode(obj.ballot);
		}


		static public Eq<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq<TEl>>.Unison;
			}
		}

	}
}

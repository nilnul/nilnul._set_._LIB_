using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot
{
	/// <summary>
	/// </summary>
	public class Eq<TEl>
		: ballot.EqI<TEl>
	{
		public bool Equals(Ballot<TEl> x, Ballot<TEl> y)
		{
			return nilnul.set._eq_._OnSeqX.Eq(
				x
				,
				y
				,
				var.valve.Eq<TEl>.Unison
			);
		}

		public int GetHashCode(Ballot<TEl> obj)
		{
			return 0;
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

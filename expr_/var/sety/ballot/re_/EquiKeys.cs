using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.re_
{
	public class IsoKeys<T>
		:
		ReI<T>
	{
		public bool re(Ballot<T> a, Ballot<T> b)
		{
			return var.sety._EqX.Eq(
				a.Keys
				,
				b.Keys
			);
		}


		static public IsoKeys<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<IsoKeys<T>>.Unison;
			}
		}

	}
}

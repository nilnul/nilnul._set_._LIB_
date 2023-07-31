using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterm.re_
{
	public class IsoVars<T>
		:
		ReI<T>
		,
		EquivI<T>

	{
		public bool re(Minterm<T> a, Minterm<T> b)
		{
			return var.sety.ballot.re_.IsoKeys<T>.Unison.re(
				a.ballot,b.ballot
			);
		}

		public bool Equals(Minterm<T> x, Minterm<T> y)
		{
			return re(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Minterm<T> obj)
		{
			return 0;
		}

		static public IsoVars<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<IsoVars<T>>.Unison;
			}
		}

	}
}

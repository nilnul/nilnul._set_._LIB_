using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.re_
{
	public class IsoVars<T>
		:
		ReI<T>
	{
		public bool re(Maxterm<T> a, Maxterm<T> b)
		{
			return var.sety.ballot.re_.IsoKeys<T>.Unison.re(
				a.ballot,b.ballot
			);
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

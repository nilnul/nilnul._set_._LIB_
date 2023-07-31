using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefed.re_
{
	/// <summary>
	/// terms with same vars. but this is not necessarily the like terms, which require not only same vars, but also same negation or not for same var ;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class IsoVars<T>
		:
		ReI<T>
	{

		public bool re(Coefed<T> a, Coefed<T> b)
		{
			return maxterm.re_.IsoVars<T>.Unison.re(a.maxterm, b.maxterm);
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

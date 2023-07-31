using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefed.re_.isovars_
{
	/// <summary>
	/// isvars, but different; that means the vals are not iso;
	/// </summary>
	/// <remarks>
	/// whether the coef is different, is irrelevant;
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public class DifInverses<T>
			:
			ReI<T>
	{

		public bool re(Coefed<T> a, Coefed<T> b)
		{
			return ballot.maxterm.re_.isovars_.Dif<T>.Unison.re(a.maxterm,b.maxterm);

		}

		static public DifInverses<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<DifInverses<T>>.Unison;
			}
		}

	}
}

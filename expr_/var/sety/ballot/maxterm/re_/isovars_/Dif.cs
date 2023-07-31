using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.re_.isovars_
{
	/// <summary>
	/// isvars, but different; that means the vals are not iso;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Dif<T>
			:
			ReI<T>
	{
		//public bool _re_01isovars(Maxterm<T> a, Maxterm<T> b)
		//{
		//	return ballot.re_.isokeys_.Dif<T>.Unison._re_01isokeyss(a.ballot,b.ballot);
		//}
		public bool re(Maxterm<T> a, Maxterm<T> b)
		{
			return ballot.re_.isokeys_.Dif<T>.Unison.re(a.ballot,b.ballot);
		}


		static public Dif<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Dif<T>>.Unison;
			}
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.re_.isokeys_
{
	/// <summary>
	/// isvars, but different; that means the vals are not iso;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Dif<T>
			:
			ReI<T>
	{
		public bool _re_01isokeyss(Ballot<T> a, Ballot<T> b)
		{
			return !_eq._SameVal4EachVar<T>.Unison.Equals(a,b);
		}

		public bool re(Ballot<T> a, Ballot<T> b)
		{
			return re_.IsoKeys<T>.Unison.re(a, b) && _re_01isokeyss(a, b);
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

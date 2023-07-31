using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set._eq_.onSeq_
{

	public class Eq8static<T, TEq>
		:
		OnSeq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Eq8static() : base(
			 nilnul._obj.typ_._UnisonX<TEq>.Unison
		)
		{
		}
		static public OnSeq<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<OnSeq<T>>.Unison;
			}
		}
	}
}

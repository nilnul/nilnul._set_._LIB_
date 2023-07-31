using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.ofSeq_.binary_.except_
{
	public class Eq8default<T,TEq>
		:
		set.op_.ofSeq_.binary_.Except<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Eq8default() : base(

				 nilnul._obj.typ_._UnisonX<TEq>.Unison

		)
		{
		}


		static public Eq8default<T,TEq> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq8default<T,TEq>>.Unison;
			}
		}





	}
}

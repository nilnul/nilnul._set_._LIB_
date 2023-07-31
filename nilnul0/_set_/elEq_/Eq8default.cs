using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set_.elEq_
{
	public class Eq8default<TEl, TEq> :
		_set_.ElEqA_ovEl<TEl>
		where TEq : IEqualityComparer<TEl>, new()

	{


		public Eq8default() : base(
				 nilnul._obj.typ_._UnisonX<TEq>.Unison
			 )
		{

		}


		static public Eq8default<TEl, TEq> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq8default<TEl, TEq>>.Unison;
			}
		}

	}
}

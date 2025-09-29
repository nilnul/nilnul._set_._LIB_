using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.set.eq_
{


	public class ElEqAsDefaulted<T, TEq>
	:
		nilnul.set.Eq1<T>


		where TEq : IEqualityComparer<T>, new()
	{

		public ElEqAsDefaulted():base( nilnul._obj.typ_._UnisonX<TEq>.Unison)
		{

		}


		static public ElEqAsDefaulted<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ElEqAsDefaulted<T, TEq>>.Instance;
			}
		}




	}
}



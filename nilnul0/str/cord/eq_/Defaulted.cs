using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.cord.eq_
{
	public class Defaulted<TEl, TEq>
		:
		nilnul.str.cord.Eq<TEl>
		where TEq : IEqualityComparer<TEl>, new()
	{
		public Defaulted():base( nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		
	}
}

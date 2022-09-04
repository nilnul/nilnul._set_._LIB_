using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.eq_
{
	public class Defaulted<TEl, TEq>
		:
		nilnul.set.family.Eq<TEl>
		where TEq : IEqualityComparer<TEl>, new()
	{
		public Defaulted():base( nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.s
{
	//alias for set.Set<set.Set<T,TEq>, set.Eq<T,TEq> >

	[Obsolete()]

	public class Set<T,TEq>
				: set.Set<set.Set<T,TEq>,set.Set<T,TEq>.Eq>

		where TEq:IEqualityComparer<T>,new()
	{
		static public TEq Eq = SingletonByDefaultNew<TEq>.Instance;
		public Set()
			
		{

		}
		public Set(IEnumerable<set.Set<T,TEq>> sets)
			:base(sets)
		{

		}



	}

	
}

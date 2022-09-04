using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.rel
{

	public partial class Subset2<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		static public bool Be(Set<T,TEq> a, Set<T,TEq> b) 
		
		{

			return a.IsSubsetOf(b);
		
		}




	}
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.set.rel;

namespace nilnul.collection.set.rel
{
	public partial class Disjoint<T,TEq>

		where TEq:IEqualityComparer<T>,new()
	{
		

		static public bool Be( Set<T,TEq>  a,Set<T,TEq> b) {

			return !Joint<T,TEq>.Be(a, b);
		
		}

	
	}
}

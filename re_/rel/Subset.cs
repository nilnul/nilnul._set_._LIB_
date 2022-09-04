using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.rel
{

	public partial class Subset<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		static public bool Be(EqContext<T,TEq>.Set a, EqContext<T,TEq>.Set b) 
		
		{

			return a.IsSubsetOf(b);
		
		}




	}
}



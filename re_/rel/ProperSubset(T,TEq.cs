using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.rel
{
	/// <summary>
	/// 
	/// </summary>
	public class ProperSubset<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		static public bool Be(set.Set<T,TEq> a, set.Set<T,TEq> b) {
			return Subset2<T,TEq>.Be(a,b) && set.Set<T,TEq>.Eq.NotEq(a,b);
		
		}
	}
}

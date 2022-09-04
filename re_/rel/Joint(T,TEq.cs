using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set;
using nilnul.collection.set.op.expr;

namespace nilnul.collection.set.rel
{
	static public class Joint<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		static public bool Be(set.Set<T,TEq> a,set.Set<T,TEq> b) { 

				return a.Intersect(b, a.Comparer).Count() > 0;
	
		}

	




	}
}

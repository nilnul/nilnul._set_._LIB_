using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.op
{
	public partial class Union<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		IEnumerable<set.Set<T,TEq>> sets;

	

		static public set.Set<T,TEq> Eval(set.Set<T,TEq> x, set.Set<T,TEq> y){
			var r = new set.Set<T,TEq>(  x);

			r.UnionWith(y);

			return r;

		}
					
	}
}

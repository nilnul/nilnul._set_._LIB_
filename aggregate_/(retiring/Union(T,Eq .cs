using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.s
{
	public partial class Union<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		IEnumerable<set.Set<T,TEq>> sets;

	

		static public set.Set<T,TEq> Eval(IEnumerable<set.Set<T,TEq>> sets){
			var r = new set.Set<T,TEq>();

			foreach (var item in sets)
			{
				r.UnionWith(item);
				
			}
			return r;

		}
					
	}
}

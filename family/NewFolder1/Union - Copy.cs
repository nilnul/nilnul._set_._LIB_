using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family
{
	[Obsolete(nameof(_UniteX))]
	static public class _UnionX
	{
		static public nilnul.Set1<T, TEq> Union<T, TEq>(
			nilnul.set.Family<T,TEq> family
		)
			where TEq:IEqualityComparer<T>,new()
		{
			var r = new Set1<T, TEq>();
			family.ForEach(x => r.UnionWith(x));

			return r;
		}


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	static public class _UnionX
	{
		static public HashSet<T> Union<T>(HashSet<T> x, IEnumerable<T> y) {
			var r = new HashSet<T>(x, x.Comparer);
			r.UnionWith(y);
			return r;
			
		}
	}

}

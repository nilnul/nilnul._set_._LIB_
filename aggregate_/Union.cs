using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slew_.set.aggregate_
{
	public class Union
	{
		static public HashSet<T> _Eval<T>(
			IEqualityComparer<T> elementEq
			,

			IEnumerable<HashSet<T>> _sets_elementEqSameAsGiven


		)
		{
			var r = new HashSet<T>(elementEq );

			foreach (var item in _sets_elementEqSameAsGiven)
			{
				r.UnionWith(item);

			}
			return r;

		}
	}
}

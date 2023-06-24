using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.co.to_.quotient_
{
	static public class _JaccardIndexX
	{
		static public (int numer, int denom) JaccardIndex<T>(HashSet<T> x, HashSet<T> y){

			//var union = new HashSet<T>(x);
			//union.UnionWith(y);

			//var c = union.Count;
			//if (c==0)
			//{
			//	return (1, 1);
			//}
			var intersected = new HashSet<T>(x);
			intersected.IntersectWith(y);
			var denom = x.Count + y.Count - intersected.Count;

			return (intersected.Count, denom);

		}
	}
}

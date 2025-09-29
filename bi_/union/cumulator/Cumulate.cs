using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.union.cumulator
{
	static public class _CumulateX
	{
		private static HashSet<T> Disjunct<T>(IEqualityComparer<T> eq, IEnumerable<IEnumerable<T>> sets)
		{
			var r = new HashSet<T>(eq);

			foreach (var item in sets)
			{
				r.AddRange(item);
			}
			return r;
		}
		static public HashSet<T> Disjunct<T>(IEqualityComparer<T> eq, params IEnumerable<T>[] sets)
		{
			return Disjunct(eq, (IEnumerable<IEnumerable<T>>)sets);
		}

		public static HashSet<T> Disjunct<T>(HashSet<T> boxed, params IEnumerable<T>[] par)
		{
			return Disjunct(boxed.Comparer, nilnul.obj.seq.op_.unary_._PrependX.Prepend(boxed, par));
			//throw new NotImplementedException();
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.sect.cascader
{
	static public class _CascadeX
	{
		public static HashSet<T> Conjunct<T>(
			HashSet<T> boxed
			,
			IEnumerable< IEnumerable<T>> par)
		{
			var r = new HashSet<T>(boxed, boxed.Comparer);

			foreach (var item in par)
			{
				r.IntersectWith(item);
				
			}
			return r;
		}


		public static HashSet<T> Conjunct<T>(HashSet<T> boxed, params IEnumerable<T>[] par)
		{
			return Conjunct(boxed, (IEnumerable<IEnumerable<T>> )par);
		}

		private static HashSet<T> Conjunct<T>(IEqualityComparer<T> eq
			,
			IEnumerable<T> omega
			,

			IEnumerable<IEnumerable<T>> sets)
		{
			var r = new HashSet<T>( omega,eq);
			return Conjunct(r, sets);

		}
		static public HashSet<T> Conjunct<T>(
			IEqualityComparer<T> eq
			,
			IEnumerable<T> omega
			,
			params IEnumerable<T>[] sets
		) {
			return Conjunct(eq,omega, (IEnumerable<IEnumerable< T>>)sets);
		}

	}
}

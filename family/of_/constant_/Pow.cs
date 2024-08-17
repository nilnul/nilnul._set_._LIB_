using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.family.ctor_
{
	/// <summary>
	/// the set of all subsets of the given set.
	/// </summary>
	static public  class _PowX
	{


		public static IEnumerable<HashSet<T>> ToHashSets<T>(this HashSet<T> universe) {

			return _ToEnumerables<T>(universe).Select(c=>new HashSet<T>(c,universe.Comparer));
		
		}

		private static IEnumerable<IEnumerable<T>> _ToEnumerables<T>(IEnumerable<T> universe) {
			if (universe.Count() == 0)
			{
				yield return (new T[0]);

			}
			else
			{
				foreach ( var item in _ToEnumerables(universe.Skip(1)))
				{
					yield return item;
					yield return (new []{universe.First() }).Union(item);

				}
			}

		
		}

		

	}
}

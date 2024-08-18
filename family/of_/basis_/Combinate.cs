using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.family.op_.of_.set_
{
	/// <summary>
	/// </summary>
	static public class _CombinateX
	{
		static public HashSet<HashSet<T>> Combinate_assumeSelectedCountLe<T>(HashSet<T> set, uint count)
		{

			if (count == 0)
			{
				return new HashSet<HashSet<T>>(
					new HashSet<T>[] { new HashSet<T>(set.Comparer) }
					,
					HashSet<T>.CreateSetComparer()
				);
			}
			var r = new HashSet<HashSet<T>>(HashSet<T>.CreateSetComparer());

			foreach (var item in set)
			{
				HashSet<T> beheadedSet = new HashSet<T>(set, set.Comparer);
				beheadedSet.Remove(item);
				var beheadedSetCombination = Combinate_assumeSelectedCountLe(beheadedSet, count - 1);

				var headArr = new[] { item };

				beheadedSetCombination.ForEach(x => { x.Add(item); });

				r.AddRange(beheadedSetCombination);

			}

			return r;
		}
		/// <summary>
		/// bring out each combination given a set.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="set"></param>
		/// <returns></returns>
		static public HashSet<HashSet<T>> Combinate<T>(HashSet<T> set)
		{
			return Combinate_assumeSelectedCountLe(set, (uint) set.Count);
		}

		static public HashSet<HashSet<T>> Combinate<T>(HashSet<T> set, uint count)
		{
			if (count > set.Count)
			{
				return new HashSet<HashSet<T>>(
					//new HashSet<T>[] { new HashSet<T>(set.Comparer) }
					//,
					HashSet<T>.CreateSetComparer()
				);
			}

			return Combinate_assumeSelectedCountLe(set, count);
		}


		static public HashSet<HashSet<T>> Combinate<T>(IEnumerable<T> set)
		{
			return Combinate(new HashSet<T>(set));
		}

		static public HashSet<HashSet<T>> Combinate<T>(params T[] set)
		{
			return Combinate(new HashSet<T>(set));
		}
	}
}
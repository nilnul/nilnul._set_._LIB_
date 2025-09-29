using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace set.collection.nilnul_obsolete
{
	/// <summary>
	/// this wi
	/// </summary>
	///
	[Obsolete(nameof(nilnul.set._CombinateX))]
	public partial class Combinate
	{
		/// <summary>
		/// bring out each combination given a set.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="set"></param>
		/// <returns></returns>
		static public HashSet<HashSet<T>> Eval<T>(HashSet<T> set)
		{
			if (set.Count == 0)
			{
				
				return new HashSet<HashSet<T>>(
					new HashSet<T>[]{new HashSet<T>(set.Comparer)}
					,
					
					HashSet<T>.CreateSetComparer()
				);

			}
			else
			{
				///take the first element
				///

				//HashSet<T> head= new HashSet<T>();

				//head.Add(set.First());



				HashSet<T> beheadedSet = new HashSet<T>(set.Skip(1),set.Comparer);

				var beheadedSetCombination = Eval(beheadedSet);


				var withFirstCombination = new HashSet<HashSet<T>>(HashSet<T>.CreateSetComparer());

				foreach (var item in beheadedSetCombination)
				{
					var t = new HashSet<T>(item,set.Comparer);

					t.Add(set.First());

					withFirstCombination.Add(t);
				}

				beheadedSetCombination.UnionWith(withFirstCombination);

				return beheadedSetCombination;



			}

		}

		static public HashSet<HashSet<T>> Eval<T>(IEnumerable<T> set)
		{
			return Eval(new HashSet<T>(set));
		
		}

		static public HashSet<HashSet<T>> Eval<T>(params T[] set)
		{
			return Eval(new HashSet<T>(set));

		}
	}

}

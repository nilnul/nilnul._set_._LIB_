using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.op_.of_.set_
{
	[Obsolete(nameof(permutate_._ByLoopX))]
	static public class _PermutateX
	{
		

		static public IEnumerable<obj.sortie_.OvSeq<T>> Permutate<T>(
			HashSet<T> set
		)
		{
			if (set.Any())
			{
				foreach (var item in set)
				{
					var deheadedSet = new HashSet<T>(set, set.Comparer);
					deheadedSet.Remove(item);

					foreach (var permutated in Permutate<T>(deheadedSet))
					{
						yield return new obj.sortie_.OvSeq<T>(
							set.Comparer
							,
							new[] { item }.Concat(
								
									permutated.ee
								
							)
						);
					}
				}
			}
			else
			{
				yield return new obj.sortie_.OvSeq<T>(
					set.Comparer, new T[0]
				);
			}
		}

		static public obj.sortie_.OvSeq<T>[] Permutate2Arr<T>(
			HashSet<T> set
		)
		{
			return Permutate<T>(set).ToArray();
		}
	
		static public IEnumerable<obj.sortie_.OvSeq<T>> Permutate<T>(
			HashSet<T> set
			,
			uint selected
		)
		{

			return _CombinateX.Combinate(set, selected).SelectMany(
				x =>Permutate(x)
			);
		}


		static public obj.sortie_.OvSeq<T>[] Permutate2Arr<T>(
			IEnumerable<T> set
			,
			IEqualityComparer<T> eq

		)
		{
			return Permutate2Arr( new HashSet<T>(set,eq));

		}

		
		static public IEnumerable<obj.sortie_.OvSeq<T>> Permutate<T>(
			IEnumerable<T> set
			,
			IEqualityComparer<T> eq
			
		)
		{

			return Permutate( new HashSet<T>(set,eq));
		}


	}
}

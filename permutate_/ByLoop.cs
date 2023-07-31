using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.permutate_
{
	static public class _ByLoopX
	{
		static public List<T[]> Permutate_assumeDistinct<T>(
			T[] arr
		)
		{
			var prefixedOrderedS = new List<T[]>() { arr };

			//var arrLenDec = arr.Length - 1;

			/// [   |  0,1,2,3 ], ... index is the position of the bar
			for (int prefixedCount = 0, prefixedCountInc=prefixedCount+1; prefixedCountInc < arr.Length; prefixedCount++, prefixedCountInc++)		//prefixed count is the count of elements before the bar
			{

				var newlyAdded4CurrentPrefixedCount = new List<T[]>() { };		

				for (int indexOfCurrentPrefixOrderedS = 0; indexOfCurrentPrefixOrderedS < prefixedOrderedS.Count; indexOfCurrentPrefixOrderedS++)		//loop thru current list of prefix-ordered-S
				{
					var newlyAdded4PrefixOrderedEl = new List<T[]>() { };
					///  [ 0,1, |  2, 3]		index is the position of the bar.
					///
					//var indexAfterBar_plusOne = index + 1;
					for (int indexOfLatter = prefixedCountInc; indexOfLatter < arr.Length; indexOfLatter++)
					{
						var newly2Add = (T[])prefixedOrderedS[indexOfCurrentPrefixOrderedS].Clone();

						nilnul.obj.str.act_._SwapElX.Swap_byTuple(newly2Add, prefixedCount, indexOfLatter);

						newlyAdded4PrefixOrderedEl.Add(newly2Add);
					}
					newlyAdded4CurrentPrefixedCount.AddRange(newlyAdded4PrefixOrderedEl);
				}
				prefixedOrderedS.AddRange(newlyAdded4CurrentPrefixedCount);
			}
			return prefixedOrderedS;
		}

		static public List<T[]> Permutate<T>(
			HashSet<T> set
		)
		{
			return Permutate_assumeDistinct(set.ToArray());

			
		}

	

		static public IEnumerable<T[]> Permutate<T>(
			HashSet<T> set
			,
			uint selected
		)
		{

			return _CombinateX.Combinate(set, selected).SelectMany(
				x => Permutate(x)
			);
		}


		static public IEnumerable<T[]> Permutate<T>(
			IEnumerable<T> set
			,
			IEqualityComparer<T> eq
			,
			uint selected

		)
		{
			return Permutate(new HashSet<T>(set, eq),selected);
		}

		static public IEnumerable<T[]> Permutate<T>(
			IEnumerable<T> set
			,
			IEqualityComparer<T> eq

		)
		{
			return Permutate(new HashSet<T>(set, eq));
		}

		static public IEnumerable<T[]> Permutate<T>(
			IEnumerable<T> set
			

		)
		{

			return Permutate(set, EqualityComparer<T>.Default);
		}


	}
}

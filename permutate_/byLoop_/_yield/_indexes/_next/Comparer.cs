using nilnul.obj.seq.be_;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.permutate_.byLoop_._yield._indexes._next
{
	/*
	 by "next", we mean among all permutation that follows, we use the smallest one. In other words, we need to define a comparer (linear order)
	Note: 0,1,2,3,4,5, the original one, is considered to be the smallest.
	 5,4,3,2,1,0, is considered to be the biggest.
	 */
	/*
	 this is also an order of permutation ( each permutation is corresponding to a num that is _le_ a factorial number).

	 */
	static public class _ComparerX
		//: IComparer<int[]>
	{
		static public int Compare_assumeSameLength1DifItemwise(int[] a, int[] b) {
			if (a.None())
			{
				return 0;
			}
			var min = a.Min();
			return Array.IndexOf(a, min).CompareTo(Array.IndexOf(b,min) );
		}
		static public int Compare_assumeSameLength1DifItemwise(List<int> a, List<int> b) {
			if (a.None())
			{
				return 0;
			}

			var min = a.Min();
			return (a.IndexOf( min) ).CompareTo(b.IndexOf(min) );
		}
		/// <summary>
		/// assume the two params are of the length
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		static public int Compare_assumeSameLengthedPermutations(int[] _indexes, int[] y)
		{
			
			

			return Compare_assumeSameLengthedPermutations(
				_indexes.ToList(),
				y.ToList()
			);

			
			
		}
		static public int Compare_assumeSameLengthedPermutations(List<int> l, List<int> l2)
		{
			
			for (int i = l.Count-1; i >=0; i--)
			{
				if (l[i]==l2[i])
				{
					l.RemoveAt(i);
					l2.RemoveAt(i);
				}
			}

			return Compare_assumeSameLength1DifItemwise(l,l2);

			
			
		}

	}
}

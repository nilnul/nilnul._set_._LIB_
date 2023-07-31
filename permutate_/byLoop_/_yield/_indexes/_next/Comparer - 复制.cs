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
	public class Comparer : IComparer<int[]>
	{
		public int compare_ofDifAtEach(int[] a, int[] b) {

			var min = a.Min();
			return Array.IndexOf(a, min).CompareTo(Array.IndexOf(b,min) );
		}
		public int compare_ofDifAtEach(List<int> a, List<int> b) {

			var min = a.Min();
			return (a.IndexOf( min) ).CompareTo(b.IndexOf(min) );
		}
		/// <summary>
		/// assume the two params are of the length
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(int[] _indexes, int[] y)
		{
			
			if (_indexes.Length <= 1)
			{
				return 0;
			}

			var f = foundIndex(_indexes);
			var f2 = foundIndex(_indexes);
			if (f.found==-1)
			{
				if (f2.found==-1)
				{
					return 0;
				}
				else
				{
					return 1;
				}

			}
			if (f2.found==-1)
			{
				return -1;
			}

			if (f.right<f2.right)
			{
				return -1;
			}
			if (f.right>f2.right)
			{
				return 1;
			}

			///remove same digits.
			///
			var l = _indexes.ToList();
			var l2 = y.ToList();
			for (int i = 0; i < l.Count; i++)
			{
				if (l[i]==l2[i])
				{
					l.RemoveAt(i);
					l2.RemoveAt(i);
				}
			}

			return compare_ofDifAtEach(l,l2);

			return Compare(
				_indexes.Skip(
					f.right
				).Select(v=> v-f.right).ToArray()
				,
				y.Skip(
					f2.right
				).Select(v=> v-f2.right).ToArray()

			);
			
		}
		public (int found, int right ) foundIndex(int[] _indexes)
		{
			if (_indexes.Length <= 1)
			{
				return (-1, 0) ;
			}

			var indexesLenMinusTwo = _indexes.Length - 2;

			Contract.Assert(indexesLenMinusTwo >= 0, "as we have checked against _indexes.Length <=1");


			for (int biggestVal2shiftRight_searching = indexesLenMinusTwo; biggestVal2shiftRight_searching >= 0; biggestVal2shiftRight_searching--)
			{

				var foundIndex = Array.IndexOf<int>(_indexes, biggestVal2shiftRight_searching);

				var foundIndexInc = foundIndex + 1;

				var targetIndex = foundIndexInc == _indexes.Length ?
					-1/*ArgumentOutOfRangeException 
startIndex is outside the range of valid indexes for array.

					but in running, we found no bug.


					and: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.indexof?redirectedfrom=MSDN&view=netcore-3.1#System_Collections_Generic_List_1_IndexOf__0_System_Int32_  says:  0 (zero) is valid in an empty list.

					String.IndexOf has the same behavior and is a bit better documented (although without specifying the reason):
The startIndex parameter can range from 0 to the length of the string instance. If startIndex equals the length of the string instance, the method returns -1.

					Here, to align with the documentation in case in the future the undocumentated implementation aligned with the documentation, we implement ours according to documentation.
					  */
					:
					Array.FindIndex<int>(_indexes, foundIndexInc, el => el > biggestVal2shiftRight_searching); //smallest possible step




				if (targetIndex >= 0)
				{
					Func<int, bool> p = i => _indexes[i] > biggestVal2shiftRight_searching;

					var targetIndexInc = targetIndex + 1;

					/// 0,1,5,3,4,2, where foundIndex is [3]=3, targetIndex is [4]=4. index2reorder is [2,4]=5,4
					/// 0,5,2,4,3,1, where foundIndex is [2]=2, targetIndex is [3]=4. index2reorder is [1,3,4]=5,4,3
					var indexes2reorder = Enumerable.Range(0, foundIndex).Where(
						p
					).Append(
						foundIndex
					).Concat(
						Enumerable.Range(targetIndexInc, _indexes.Length - targetIndexInc)
						.Where(
							p
						)
					).ToArray();

					return (foundIndex, indexes2reorder.First());
	
				}

			}
			return (-1, 0);
		}
	}
}

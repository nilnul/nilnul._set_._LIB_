using nilnul.obj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.permutate_.byLoop_._yield
{
	/*
	take an permuation itself as state; and infer next permutation.
	by "next", we mean among all permutation that follows, we use the smallest one. In other words, we need to define a comparer (linear order)
	We use lexical comparer, eg:
		3,5,1,2,4,0
		vs
		3,4,1,2,5,0
		the latter is smaller as [1]'s 4 is smaller than 5.
	Note: 0,1,2,3,4,5, the original one, is considered to be the smallest.


		 */
	/// <summary>
	/// warn: there is an immutable arr which must be cloned if this.ToArray is called;; use this for the purpose of getting a Enumerator.
	/// this is also an order of permutation (corresponding to a num _le_ a factorial number).
	/// </summary>
	public class Indexes :
	   //nilnul.obj._seq_.GetEnumeratorA<int[]>,
	   IEnumerable<int[]>
	{
		int[] _indexes;

		public Indexes(int count)
		{
			_indexes = Enumerable.Range(0, count).ToArray();
		}

		public IEnumerable<int[]> eachCloned()
		{
			return this.Select(x => (int[])x.Clone());
		}

		public int[][] eachClonedAsArr()
		{
			return eachCloned().ToArray();
		}

		public IEnumerator<int[]> GetEnumerator()
		{
			///Note: we keep lower (value(number), which is not array index)s not move as possible as we could.
			///find the largest value that is movable ( there is a larger value to the right).
			///so we need to find largest pair that is swappable (left lt rigth).
			///
			/// 
			/// we first find biggest number that: to itsRight (including itself), still has growth space (not totaly ordered reversely).
			/// now how to grow (swap which two?)? find the smallest growth.
			/// 
			/// we will move this number only one step, and fill the vacancy with smallest number that can move left and so on (i.e., other numbers are reordered to initial state.)
			///

			yield return _indexes;

			///find the biggest, to the right of which there is still growth space ().
			if (_indexes.Length <= 1)
			{
				yield break;
			}

			// say: 6-2=4
			var indexesLenMinusTwo = _indexes.Length - 2;
			while (true)
			{

				//var indexesLenMinusTwo = _indexes.Length - 2;
				Contract.Assert(indexesLenMinusTwo >= 0, "as we have checked against _indexes.Length <=1");


				///eg: 		3,5,1,2,4,0
				///		we need to find "3", which is the biggest val that can be pushed back for the state to grow
				///		we start from 4 (as "5" is never capable to be pushed back to grow), to 0, to find one single such val.
				for (int biggestVal2shift_searching = indexesLenMinusTwo; biggestVal2shift_searching >= 0; biggestVal2shift_searching--)//always find the biggest val (not index) to shift to minimize growth cost.
				{

					var foundIndex = Array.IndexOf<int>(_indexes, biggestVal2shift_searching);

					//ArraySegment<int> segmentToTheRight = new ArraySegment<int>(_indexes, foundIndex, _indexes.Length - foundIndex);

					var foundIndexInc = foundIndex + 1;

					var targetIndex =  foundIndexInc == _indexes.Length ?
						-1/*ArgumentOutOfRangeException 
startIndex is outside the range of valid indexes for array.

					but in running, we found no bug.


					and: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.indexof?redirectedfrom=MSDN&view=netcore-3.1#System_Collections_Generic_List_1_IndexOf__0_System_Int32_  says:  0 (zero) is valid in an empty list.

					String.IndexOf has the same behavior and is a bit better documented (although without specifying the reason):
The startIndex parameter can range from 0 to the length of the string instance. If startIndex equals the length of the string instance, the method returns -1.

					Here, to align with the documentation in case in the future the undocumentated implementation aligned with the documentation, we implement ours according to documentation.
					  */
						:
						Array.FindIndex<int>(_indexes, foundIndexInc, el => el > biggestVal2shift_searching); //smallest possible step




					if (targetIndex >= 0)
					{
						Func<int, bool> p = i => _indexes[i] > biggestVal2shift_searching;

						var targetIndexInc = targetIndex + 1;
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

						_indexes[targetIndex] = biggestVal2shift_searching;

						/// shift is possible. now do something.
						///
						/// find all values geater than i
						/// reorder them
						///

						var biggestVal2ShiftInc = biggestVal2shift_searching + 1;

						for (int indexOfGreater = 0; indexOfGreater < indexes2reorder.Count(); indexOfGreater++)
						{
							_indexes[indexes2reorder[indexOfGreater]] = biggestVal2ShiftInc + indexOfGreater;

						}

						yield return _indexes;
						break;      //end this loop; don't loop any more; more loops are unnecessary for this time of searching.


					}

					//if (targetIndex < 0)
					//{
					if (biggestVal2shift_searching == 0)
					{
						yield break;
					}
					//continue;
					//}

				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

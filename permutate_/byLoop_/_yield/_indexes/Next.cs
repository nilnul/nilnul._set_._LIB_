using nilnul.obj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.permutate_.byLoop_._yield._indexes
{
	/*
	take an permuation itself as state; and infer next permutation.
	 */

	/// <summary>
	/// </summary>
	static public class _NextX

	{

		/// <summary>
		/// keep the left part stable, and try to order the right part eventually reversed.
		/// 0,1,2,3,4,5  ------> 5,4,3,2,1,0.
		/// in between,
		/// 0,1,2,3,4,5,       "" --------->
		/// 0 1 2 3,        5,4
		///
		/// =========
		///0 ,1 2         3 5 4
		/// here while keeping "012" intact,  we need to move 3 to the end, one step each time. At each step, shuffle "4","5" from "45" to "54".
		/// ---------->
		///
		/// 
		/// 0,1,2,     5,4,3 -------->
		///========
		/// "01    2543"
		/// here while keeping "01" intact, we need to move 2 to the end,step by step. at each step, we need shuffle "345" from "345" to "543". Note here "01" is ordered; we need to pay attention to "3245", changing from "3245" to "5243", depleting the possibilites of "3,4,5", we can then, noting that "01" is neglected, if we find bigger ones in "5243", that has potential to move right, which is 2 again (keep in mind we have run out the possibilities of "543"). eventually we will move 2 to the end and we get "3452", then "5432"
		/// 
		/// 0,1,     5,4,3,2. ------->
		/// 0,     5 ,4,3,2,1 -------->
		/// "",        5,4,3,2,1,0
		/// 
		/// </summary>
		/// <param name="_indexes">
		/// eg: 3,5,1,2,4,0
		/// </param>
		/// <returns></returns>
		/// 
		static public bool Shuffled(int[] _indexes)
		{
			///Note: we keep smaller values not move as possible as we could.
			///So we will shuffle only larger numbers.
			///
			/// Let's take "0,1,2,3,5,4" as example
			///
			///find the largest value that is movable ( there is a larger value to the right, note there might be more than one larger value, as in "0,1,2,3,5,4"). Here what we find is "3".
			///
			/// we will move "3" to the position of the nearest bigger one, i.e., the position of "5". Now the array becomes "0,1,2,_3_,3,4". 
			/// 
			/// then we will keep numbers less than "3" in their original place. But we will repopulate the position of numbers greater than 3, into the natural order.  "0,1,2,_4_,3,_5_" is what we get; (note "4,...,5" is in natural order.).
			///
			/// * the spirit of this is: keep as much smaller numbers as possible in their original position. find the largest value to move. when moving, move as less steps as possible. when moved, keep larger values's order as "optimal" as possible, that is, to a natural order


			///find the biggest, to the right of which there is at least one larger number.
			if (_indexes.Length <= 1)
			{
				return false;
			}

			// say: 6-2=4
			var indexesLenMinusTwo = _indexes.Length - 2;

			Contract.Assert(indexesLenMinusTwo >= 0, "as we have checked against _indexes.Length <=1");


			///eg: 		3,5,1,2,4,0
			///		we need to eventually find "3", which is the biggest val that can be pushed right for the state to grow.
			///		To achive this, we first search 4(as "5" will never have a larger number to the right), then 3, then 2, ..., till we find one that has at least one larger number to the right. In this example, the search will stop at "3"
			for (int biggestVal2shiftRight_searching = indexesLenMinusTwo; biggestVal2shiftRight_searching >= 0; biggestVal2shiftRight_searching--)//always find the biggest val (not index) to shift to minimize growth cost.
			{

				var foundIndex = Array.IndexOf<int>(_indexes, biggestVal2shiftRight_searching);

				//ArraySegment<int> segmentToTheRight = new ArraySegment<int>(_indexes, foundIndex, _indexes.Length - foundIndex);

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

					/// 0,1,5,3,4,2, where foundIndex is 3, targetIndex is 4.
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
					#region eg: 0,5,2,4,3,1  ==>  0,3,4,2,5,1
					_indexes[targetIndex] = biggestVal2shiftRight_searching;

					/// shift is possible. now do something.
					///
					/// find all values geater than biggestVal2shift_searching
					/// reorder them
					///

					var biggestVal2ShiftInc = biggestVal2shiftRight_searching + 1;

					for (int indexOfGreater = 0; indexOfGreater < indexes2reorder.Count(); indexOfGreater++)
					{
						_indexes[indexes2reorder[indexOfGreater]] = biggestVal2ShiftInc + indexOfGreater;

					}

					#endregion



					return true;
				}
				///now targetIndex = -1

			}
			///for 0, we find no larger number to the right.
			///So every number has no larger number.
			///We are alread at "5,4,3,2,1,0"
			return false;

		}


	}
}

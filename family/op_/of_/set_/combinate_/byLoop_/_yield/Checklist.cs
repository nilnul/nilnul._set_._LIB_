using nilnul.obj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.op_.of_.set_.combinate_.byLoop_._yield
{
	/*
	This will take the combination itself as state, and derive the next.
	"next" here means:
		1) any that comes after ; and
		2) for all that comes after, we choose one that comes first.
	So here the problem is : what is "after". In other orders, we need to define a comparer for this. the comparer we choose is "lexical" comparer: for any two str, we compare first element pair that differs.
	for example:
	  false, true, false, true, true, false
	  vs
	  false, true, false, true, false, true

	the second would be greater in that, last "true"'s position is pushed back more.

	Note: in implementing the comparer,
		for a state:
			true, false, true, false,false, true, true
		when we push forward the second true, all the "true"s that follows shall be aligned left, as this is the next (least great)
		thus: the next is:
			true, false, false, true, true, true, false.
		 */
	/// <summary>
	/// warn: there is an immutable arr which must be cloned if this.ToArray is called; use this for the purpose of getting a Enumerator.
	/// this is also an order of permutation (corresponding to a num le a factorial number).
	/// </summary>
	public class Checklist :
	   //nilnul.obj._seq_.GetEnumeratorA<int[]>,
	   IEnumerable<bool[]>
	{
		private int _samples;

		public int samples
		{
			get { return _samples; }
			set { _samples = value; }
		}


		private bool[] _checklist;

		public bool[] checklist
		{
			get { return _checklist; }
			set { _checklist = value; }
		}

		public int total { get { return _checklist.Length; } }


		/// <summary>
		/// assme count>=select
		/// </summary>
		/// <param name="population"></param>
		/// <param name="toChoose"></param>
		public Checklist(int population, int toChoose)
		{
			_samples = toChoose;
			_checklist = new bool[population];

		}
		public Checklist(int population, uint toChoose):this(population,(int) toChoose)
		{

		}

		public IEnumerable<bool[]> eachCloned()
		{
			return this.Select(x => (bool[]) (x.Clone() ));
		}

		public bool[][] eachClonedAsArr()
		{
			return eachCloned().ToArray();
		}


		/// <summary>
		/// find an order
		/// </summary>
		/// <returns></returns>
		public IEnumerator<bool[]> GetEnumerator()
		{
			for (int i = 0; i < _samples; i++)
			{
				_checklist[i] = true;
			}

			yield return _checklist;

			//if (_toChoose == 0)
			//{
			//	yield break;
			//}
			//if (_toChoose == _beChosenS.Length)
			//{
			//	yield break;
			//}

			var lastIndex = _checklist.Length - 1;

			if (lastIndex < 0)
			{
				yield break;
			}

			while (true)
			{
				var firstTrue = Array.IndexOf<bool>(_checklist, true);

				if (firstTrue < 0)
				{
					yield break;
				}
				///	 eg:  (true), false, true, false,false, true, true
				///


				var lastCandidateFalse = Array.LastIndexOf<bool>(_checklist, false, lastIndex, lastIndex - firstTrue);

				if (lastCandidateFalse < 0)
				{
					yield break;
				}
				///	 eg:  true, false, true, false, (false), true, true

				/// find nearest true before lastAvailableFalse
				///
				Debug.Assert(lastCandidateFalse > 0);

				var lastTrueBeforeLastCandidateFalse = Array.LastIndexOf<bool>(_checklist, true, lastCandidateFalse - 1);

				///	 eg:  true, false, (true), false,false, true, true
				_checklist[lastTrueBeforeLastCandidateFalse] = false;

				lastTrueBeforeLastCandidateFalse++;

				//how many trueS hereafter?
				//var truesHence = _beChosenS.Skip(lastTrueBeforeLastCandidateFalse).Count(b => b);
				var truesHence = _checklist.Length - lastCandidateFalse;  ///the trues (except the one being pushed back) + (note here we use ".Length" which will add one to the trues Length)the one being pushed back
				var trueReinitEnd = lastTrueBeforeLastCandidateFalse + truesHence;

				for (; lastTrueBeforeLastCandidateFalse < trueReinitEnd; lastTrueBeforeLastCandidateFalse++)
				{
					_checklist[lastTrueBeforeLastCandidateFalse] = true;
				}

				for (; lastTrueBeforeLastCandidateFalse < _checklist.Length; lastTrueBeforeLastCandidateFalse++)
				{
					_checklist[lastTrueBeforeLastCandidateFalse] = false;
				}

				yield return _checklist;

			}


		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

using nilnul.obj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.op_.of_.set_.combinate_.byLoop_
{
	/// <summary>
	/// warn: there is an immutable arr which must be cloned if this.ToArray is called.
	/// this is also an order of permutation (corresponding to a num le a factorial number).
	/// </summary>
	public class Slider :
	   //nilnul.obj._seq_.GetEnumeratorA<int[]>,
	   IEnumerator<bool[]>
	{
		int _toChoose;
		bool[] _beChosenS;

		/// <summary>
		/// assme count>=select
		/// </summary>
		/// <param name="population"></param>
		/// <param name="toChoose"></param>
		public Slider(int population, int toChoose)
		{
			_toChoose = toChoose;
			_beChosenS = new bool[population];

		}

		public bool[] Current => _beChosenS;

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			//throw new NotImplementedException();
		}

		//public bool[][] everyCloned()
		//{
		//	return this.Select(x => (bool[])x.Clone()).ToArray();
		//}
		/// <summary>
		/// find an order
		/// </summary>
		/// <returns></returns>
		//public IEnumerator<bool[]> GetEnumerator()
		//{



		//}

		public bool MoveNext()
		{
			for (int i = 0; i < _toChoose; i++)
			{
				_beChosenS[i] = true;
			}

			return true;

			//yield return _beChosenS;

			if (_toChoose == 0)
			{
				return false;
			}
			if (_toChoose == _beChosenS.Length)
			{
				return false;
			}


			while (true)
			{
				var lastFalse = Array.LastIndexOf<bool>(_beChosenS, false);
				var lastTrueBeforeLastFalse = Array.LastIndexOf<bool>(_beChosenS, true, 0, lastFalse);
				if (lastTrueBeforeLastFalse >= 0)
				{
					_beChosenS[lastTrueBeforeLastFalse] = false;
					_beChosenS[lastFalse] = true;
					//yield return _beChosenS;

				}
				else
				{
				//	yield break;
				}




			}

		}

		public void Reset()
		{


		}

		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	return GetEnumerator();

		//}
	}
}

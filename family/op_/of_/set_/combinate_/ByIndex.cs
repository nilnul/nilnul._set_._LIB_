using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.family.op_.of_.set_.combinate_
{
	/// <summary>
	/// </summary>
	static public class _ByIndexsX
	{
		/// <summary>
		/// cord (or, sometimes, cluster) is a str of strS.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="set"></param>
		/// <param name="sample"></param>
		/// <returns></returns>
		static public IEnumerable<IEnumerable<T>> Cord_assumeDistinct1SampleLe<T>(IEnumerable<T> set, uint sample)
		{

			var enumerator = new byLoop_._yield.Checklist(set.Count(), sample)/*.eachCloned()*/.GetEnumerator();

			while (enumerator.MoveNext())
			{
				yield return set.Where((e, i) => enumerator.Current[i] ).ToArray();
			}

		}
		static public IEnumerable<IEnumerable<T>> _Cord_assumeDistinct1SampleNumLe<T>(IEnumerable<T> set, int sample)
		{
			return Cord_assumeDistinct1SampleLe(set, (uint)sample);
		}

		static public IEnumerable<IEnumerable<T>> _Cord_assumeDistinct<T>(IEnumerable<T> set, uint sample)
		{
			if (sample > set.Count())
			{
				return new IEnumerable<T>[0];
			}

			return Cord_assumeDistinct1SampleLe(set, sample);
		}

		static public IEnumerable<IEnumerable<T>> _Cord_assumeDistinct<T>(IEnumerable<T> set, int sample)
		{
			

			return _Cord_assumeDistinct(set, (uint) sample);
		}



		static public HashSet<HashSet<T>> Family_assumeSampleLe<T>(HashSet<T> set, uint sample)
		{
			return new HashSet<HashSet<T>>(
				Cord_assumeDistinct1SampleLe(set,sample).Select(s=> new HashSet<T>(s,set.Comparer))
				,
				 HashSet<T>.CreateSetComparer()
			);
		}



		/// <summary>
		/// bring out each combination given a set.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="set"></param>
		/// <returns></returns>
		static public HashSet<HashSet<T>> Family<T>(HashSet<T> set)
		{
			return Family_assumeSampleLe(set, (uint) set.Count);
		}

		static public HashSet<HashSet<T>> Family<T>(HashSet<T> set, uint sample)
		{
			if (sample > set.Count)
			{
				return new HashSet<HashSet<T>>(
					//new HashSet<T>[] { new HashSet<T>(set.Comparer) }
					//,
					HashSet<T>.CreateSetComparer()
				);
			}

			return Family_assumeSampleLe(set, sample);
		}


		static public HashSet<HashSet<T>> Family<T>(IEnumerable<T> set)
		{
			return Family(new HashSet<T>(set));
		}

		static public HashSet<HashSet<T>> Family<T>(params T[] set)
		{
			return Family(new HashSet<T>(set));
		}
	}
}
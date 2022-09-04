using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	/// <summary>
	/// partite a set into a family that is an equivalent class.
	/// we can consider to use <see cref="IEnumerable{T}.GroupBy"/>
	/// </summary>
	static public class _PartiteX
	{


		static public IEnumerable<HashSet<T>> Partite<T>(
			IEnumerable<T> set
			,
			IEqualityComparer<T> innerEq,
			IEqualityComparer<T> equiv
		)
		{
			//first make each element a set.

			var list = new List<HashSet<T>>();

			set.ForEach(
				x => list.Add(new HashSet<T>(innerEq) { x })
			);


			//merge joints


			for (int i = 0; i < list.Count - 1; i++)
			{
				for (int j = i+1; j < list.Count; j++)
				{
					if (nilnul.set.re_._JointX.Re(list[i ], list[j] ,equiv))
					{
						list[i ].AddRange(list[j]);

						list[j].Clear();
					}


				}



			}
			list.RemoveAll(x => x.Count == 0);

			return list;

		}



		static public IEnumerable<HashSet<T>> Partite_byMerge<T>(
			IEnumerable<T> set,
			IEqualityComparer<T> equiv)
		{
			//first make each element a set.

			var list = new List<HashSet<T>>();

			set.ForEach(
				x => list.Add(new HashSet<T>() { x })
			);


			//merge joints


			for (int i = 0; i < list.Count - 1; i++)
			{
				for (int j = i + 1; j < list.Count; j++)
				{
					if (nilnul.set.re_._JointX.Re(list[i], list[j], equiv))
					{
						list[i].AddRange(list[j]);

						list[j].Clear();
					}


				}



			}
			list.RemoveAll(x => x.Count == 0);

			return list;

		}

		
		static public IEnumerable<IGrouping<T,T>> Partite_byGroup<T>(
			IEnumerable<T> set
			,
			IEqualityComparer<T> equiv
		)
		{
			return set.GroupBy(x => x, equiv);

		}


	}
}

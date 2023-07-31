using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.partite_
{
	/// <summary>
	/// the elementEq for the set is defaulted
	/// </summary>
	///
	[Obsolete("default element eq is provided in runtime at: " + nameof(nilnul.set._PartiteX.Partite_byMerge) )]
	static public class _InnerEqDefaultX
	{


		static public IEnumerable<HashSet<T>> Partite<T>(
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

		

	}
}

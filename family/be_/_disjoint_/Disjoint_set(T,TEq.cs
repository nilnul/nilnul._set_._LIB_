
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set.rel;

namespace nilnul.collection.set.s
{
	[Obsolete()]

	public partial class Disjoint_set<T, TEq>

		: nilnul.bit.be.FroFunc<set.Set<set.Set<T, TEq>, set.Set<T, TEq>.Eq>>

		where TEq : IEqualityComparer<T>, new()
	{
		public Disjoint_set()
			: base(Be)
		{

		}

		static public bool Be(set.Set<set.Set<T, TEq>, set.Set<T, TEq>.Eq> sets_notNull)
		{
			var counts = sets_notNull.Count;
			for (int i = 0; i < counts; i++)
			{
				for (int j = i + 1; j < counts; j++)
				{
					if (
						rel.Joint<T, TEq>.Be(
							(sets_notNull as IEnumerable<set.Set<T, TEq>>).ElementAt(i)
							,
							(sets_notNull as IEnumerable<set.Set<T, TEq>>).ElementAt(j)
						)
					)
					{
						return false;
					}
				}
			}
			return true;
		}






		public class Noun
			: 
			nilnul.bit.be.Predicated<
				set.Set<set.Set<T, TEq>, set.Set<T, TEq>.Eq>
				,
				Disjoint_set<T, TEq>
			>
		{

			public Noun(set.Set<set.Set<T, TEq>,set.Set<T,TEq>.Eq> setOfSets)
				: base(setOfSets)
			{

			}


		}
	}
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set.rel;

namespace nilnul.collection.set.s
{
	[Obsolete()]

	public partial class Disjoint<T, TEq>
		: nilnul.bit.be.FroFunc<s.Set<T, TEq>>
		where TEq : IEqualityComparer<T>, new()
	{
		public Disjoint()
			: base(Be)
		{

		}

		static public bool Be(s.Set<T, TEq> sets_notNull)
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




		public class Adj : nilnul.bit.AdjI<s.Set<T, TEq>>
		{

			public bool be(s.Set<T, TEq> val)
			{
				return Be(val);

				throw new NotImplementedException();
			}
		}



		public class Noun
			: nilnul.bit.adj.Noun<
				s.Set<T, TEq>
				,
				Adj
			>
		{

			public Noun(s.Set<T, TEq> setOfSets)
				: base(setOfSets)
			{

			}

			static public set.Set<T, TEq> ContainerOf(Noun disjointSets, T element)
			{

				foreach (var set in disjointSets.val)
				{
					if (set.Contains(element))
					{
						return set;

					}


				}
				return null;

			}




			static public set.Set<T, TEq> ContainerOf(IEnumerable<set.Set<T, TEq>> disjointSets, T element)
			{

				foreach (var set in disjointSets)
				{
					if (set.Contains(element))
					{
						return set;

					}


				}
				return null;

			}


		}

		public class Predicated
			: nilnul.bit.be.Predicated<s.Set<T, TEq>, Disjoint<T, TEq>>
		{
			public Predicated(
				s.Set<T, TEq> set
			)
				: base(set)
			{

			}
		}
	}
}




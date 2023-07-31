
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.set.rel;

namespace nilnul.collection.set.rel
{
	public partial class Disjoint<T,TEq>

		where TEq:IEqualityComparer<T>,new()
	{
		static public Predicate<HashSet<T>, HashSet<T>> Create()
		{
			return Predicate<HashSet<T>, HashSet<T>>.CreateNegativeFrom(
				JointX.Is
			);
		}

		static public bool Be( EqContext<T,TEq>.Set  a,EqContext<T,TEq>.Set b) {

			return !JointX.Be(a, b);
		
		}

		static public bool Be(NotNull2< IEnumerable<EqContext<T,TEq>.Set>> sets) {
			return _Be(sets.val);
		
		}

		static public bool _Be(IEnumerable<EqContext<T, TEq>.Set> sets_notNull)
		{
			var counts = sets_notNull.Count();
			for (int i = 0; i < counts; i++)
			{
				for (int j = i + 1; j < counts; j++)
				{
					if (JointX.Be(sets_notNull.ElementAt(i), sets_notNull.ElementAt(j)))
					{
						return false;
					}
				}
			}
			return true;
		}

		static public bool _Be(EqContext<T,TEq>.Set.Eq.SetOfSet sets_notNull) {

			var counts = sets_notNull.Count;
			for (int i = 0; i < counts; i++)
			{
				for (int j = i + 1; j < counts; j++)
				{
					if (
						JointX.Be<
							EqContext<T,TEq>.Set
							,
							EqContext<T,TEq>.Set.Eq
						>(
							(sets_notNull as IEnumerable<EqContext<T,TEq>.Set>).ElementAt(i)
							,
							(sets_notNull as IEnumerable<EqContext<T, TEq>.Set>).ElementAt(j)
						)
					)
					{
						return false;
					}
				}
			}
			return true;


		
		}

		static public bool Be(NotNull2<EqContext<T, TEq>.Set.Eq.SetOfSet> sets_notNull)
		{

			return _Be(sets_notNull.val);



		}

		public class Adj:nilnul.bit.AdjectiveI3<EqContext<T,TEq>.Set.Eq.SetOfSet>
		{

			public bool be(NotNull2<EqContext<T, TEq>.Set.Eq.SetOfSet> val)
			{
				return Be(val.val);

				throw new NotImplementedException();
			}
		}

		public class Noun
		{
			EqContext<T, TEq>.Set.Eq.SetOfSet _setOfSets;
			public Noun( EqContext<T, TEq>.Set.Eq.SetOfSet setOfSets)

			{

			}


		}
	}
}

namespace nilnul.set.rel
{
	public partial class Disjoint<TElement>
	{
		static public Predicate<HashSet<TElement>, HashSet<TElement>> Create()
		{
			return Predicate<HashSet<TElement>, HashSet<TElement>>.CreateNegativeFrom(
				JointX.Is
			);
		}




	}
}

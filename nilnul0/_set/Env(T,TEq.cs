
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set.rel;

namespace nilnul.collection.set.s
{

	public partial class Env<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{


		public partial class Disjoint
		{

			static public bool Be(EqContext<T, TEq>.Set.Eq.SetOfSet sets_notNull)
			{

				var counts = sets_notNull.Count;
				for (int i = 0; i < counts; i++)
				{
					for (int j = i + 1; j < counts; j++)
					{
						if (
							JointX.Be<
								EqContext<T, TEq>.Set
								,
								EqContext<T, TEq>.Set.Eq
							>(
								(sets_notNull as IEnumerable<EqContext<T, TEq>.Set>).ElementAt(i)
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



		
			public class Adj : nilnul.bit.AdjI<EqContext<T, TEq>.Set.Eq.SetOfSet>
			{

	

				public bool be(EqContext<T, TEq>.Set.Eq.SetOfSet val)
				{
					return Be(val);

					throw new NotImplementedException();
				}
			}



			public class Noun
				:nilnul.bit.adj.Noun<
					EqContext<T, TEq>.Set.Eq.SetOfSet
					,
					Adj
				>

			{
				
				public Noun(EqContext<T, TEq>.Set.Eq.SetOfSet setOfSets)
					:base(setOfSets)
				{

				}


			}
		}
	}


}

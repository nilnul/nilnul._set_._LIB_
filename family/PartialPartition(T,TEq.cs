using nilnul.collection.set.rel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.s
{
	public partial class PartialPartition<T,TEq>
		

		where TEq:IEqualityComparer<T>,new()
	{

		static public bool Be(set.Set<T,TEq> universe, Disjoint<T,TEq>.Noun partition)
		{

		
			foreach (var item in partition.val)
			{


				if (collection.set.rel.Subset2<T,TEq>.Be(item,universe))
				{
					return false;
					
				}

			}
			return true;

		}

		public class Noun
		{
			private set.Set<T,TEq> _universe;

			public set.Set<T,TEq> universe
			{
				get { return _universe; }
				set { _universe = value; }
			}

			private Disjoint<T,TEq>.Noun _disjointSets;

			public Disjoint<T,TEq>.Noun disjointSets
			{
				get { return _disjointSets; }
				set { _disjointSets = value; }
			}
		

			public Noun(set.Set<T, TEq> universe, Disjoint<T, TEq>.Noun partition)
			{
				nilnul.bit.Assertion.True(Be(universe, partition));
				this.universe = universe;
				this.disjointSets= partition;



			}
			
		}

		public class Noun<TUniv>
			:Noun
			where TUniv:set.Set<T,TEq>,new()
		{
			static public TUniv Univ=SingletonByDefault<TUniv>.Instance;
			public Noun(Disjoint<T,TEq>.Noun disjointSets)
				:base(Univ,disjointSets)
			{

			}

		}


		


	}
}

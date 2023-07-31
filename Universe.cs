using nilnul.collection.set.rel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.s
{
	public partial class Univ<T, TEq>
		where TEq : IEqualityComparer<T>
	{


		static public bool IsPartial(EqContext<T, TEq>.Set universe, Env<T, TEq>.Disjoint.Noun partition)
		{

			foreach (var item in partition.val)
			{


				if (collection.set.rel.Subset<T, TEq>.Be(item, universe))
				{
					return false;

				}

			}
			return true;

		}


		private EqContext<T, TEq>.Set _universe;

		public EqContext<T, TEq>.Set universe
		{
			get { return _universe; }
			set { _universe = value; }
		}

		public Univ(
			EqContext<T, TEq>.Set universe
			)
		{
			this._universe = universe;
		}

		public bool isPartialPartition(Env<T, TEq>.Disjoint.Noun partition)
		{
			return IsPartial(_universe, partition);
		}


		public class Universe<TSet>
			: Universe
			where TSet : EqContext<T, TEq>.Set, new()
		{
			public Universe()
				: base(SingletonByDefaultNew<TSet>.Instance)
			{

			}

			public class PartialPartition
			{
				private Env<T, TEq>.Disjoint.Noun _disjoinSets;

				public Env<T, TEq>.Disjoint.Noun disjointSets
				{
					get { return _disjoinSets; }
					set { _disjoinSets = value; }
				}
				public PartialPartition(Env<T, TEq>.Disjoint.Noun disjointSets)
				{
					this._disjoinSets = disjointSets;

				}
			}

			public class Partition
			{

				static public bool Be(PartialPartition partialPartition)
				{ 
					return 
				
				}
				private PartialPartition _partialPartition;

				public PartialPartition partialPartition
				{
					get { return _partialPartition; }
					set { _partialPartition = value; }
				}




			}



		}






	}
}

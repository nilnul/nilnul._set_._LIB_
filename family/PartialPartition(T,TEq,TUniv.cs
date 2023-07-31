using nilnul.collection.set.rel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.s
{
	public partial class PartialPartition<T,TEq,TUniv>
		:PartialPartition<T,TEq>
		where TEq:IEqualityComparer<T>,new()
		where TUniv:set.Set<T,TEq>,new()
	{

		static public TUniv Univ=SingletonByDefaultNew<TUniv>.Instance;

		static public bool Be(Disjoint<T, TEq>.Noun partition) {
			return PartialPartition<T, TEq>.Be(Univ, partition);
		
		}






		


	}
}

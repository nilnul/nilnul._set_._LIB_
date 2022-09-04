
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set.rel;
using nilnul.collection.set.op.expr;

namespace nilnul.collection.set.s
{

	public partial class Partition<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{

		static public bool Be( PartialPartition<T,TEq>.Noun partialPartition  ) {

			return partialPartition.universe.SetEquals(

				s.Union<T,TEq>.Eval(partialPartition.disjointSets.val)


				
			);
		
		}



	}


}

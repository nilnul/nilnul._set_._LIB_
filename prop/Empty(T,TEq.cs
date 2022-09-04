using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.prop
{
	public partial class Empty<T,TEq>

		:nilnul.bit.Predicate3<set.Set<T,TEq>>
		where TEq:IEqualityComparer<T>,new()
	{

		static public bool Be(set.Set<T,TEq> set) {
			return set.Count == 0;
		}

		public Empty()
			:base(Be)
		{

		}

	}

	
}

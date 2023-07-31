using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.prop
{
	public partial class Singleton<T,TEq>
		:nilnul.bit.Predicate3<set.Set<T,TEq>>

		where TEq:IEqualityComparer<T>,new()

	{
		public Singleton()
			:base(Be)
		{

		}
		static public bool Be(set.Set<T,TEq> set) {
			return set.Count == 1;
		}

	}
}

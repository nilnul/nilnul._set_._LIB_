using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	public class HashSet<T,Comparer>
		:HashSet<T>
		where Comparer:IEqualityComparer<T>,new()
	{

		public HashSet()
			:base(new Comparer())
		{

		}


		public HashSet(IEnumerable<T> collection)
			:base(collection,new Comparer())
		{
		}
					
					

	}
}

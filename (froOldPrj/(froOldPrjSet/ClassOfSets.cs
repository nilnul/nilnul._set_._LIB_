using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.finite
{
	public partial class ClassOfSets<T>:HashSet<HashSet<T>>,IEqualityComparer<HashSet<T>>
	{



		public bool Equals(HashSet<T> x, HashSet<T> y)
		{
			if (IsHashSet.Is(typeof(T)))
			{

				
			}

			throw new NotImplementedException();
		}

		public int GetHashCode(HashSet<T> obj)
		{
			return obj.GetHashCode();
		}
	}
}

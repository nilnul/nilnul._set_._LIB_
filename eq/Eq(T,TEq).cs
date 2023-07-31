using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.set
{

	[Obsolete(nameof(nilnul.set.EqI<T>))]

	public class Eq<T, TEq>
	:
		IEqualityComparer<Set<T, TEq>>

		where TEq:IEqualityComparer<T>,new()
		{

			static public bool Be(
				Set<T, TEq> x, Set<T, TEq> y
			)
			{

				return x.SetEquals(y);
			}

			static public bool NotEq(
							Set<T, TEq> x, Set<T, TEq> y
	
				) {
					return Be(x, y);


			}

			public bool Equals(Set<T, TEq> x, Set<T, TEq> y)
			{

				return x.SetEquals(y);
				throw new NotImplementedException();
			}

			public int GetHashCode(Set<T, TEq> obj)
			{

				return 0;
				throw new NotImplementedException();
			}
		



	}
}



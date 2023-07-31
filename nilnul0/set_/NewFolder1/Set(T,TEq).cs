using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.set
{
	[Obsolete()]

	public class Set<T, TEq>
		: Set<T>
		where TEq : IEqualityComparer<T>, new()
	{

		static public TEq ElementEq = SingletonByDefaultNew<TEq>.Instance;

		public Set()
			: base(SingletonByDefaultNew<TEq>.Instance)
		{

		}


		public Set(IEnumerable<T> collection)
			: base(collection, ElementEq)
		{

		}


		 public void addRange(IEnumerable<T> elements)
		{
			
			foreach (var item in elements)
			{
				Add(item);

			}
		}


		public class Eq :
			IEqualityComparer<Set<T, TEq>>
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
}



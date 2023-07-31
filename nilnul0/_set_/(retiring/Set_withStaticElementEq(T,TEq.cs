using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.set
{
	[Obsolete()]

	public class Set_withStaticElementEq<T, TEq>
		: Set<T>
		where TEq : IEqualityComparer<T>, new()
	{
		static public IEqualityComparer<T> ElementEq = SingletonByDefaultNew<TEq>.Instance;

		public Set_withStaticElementEq()
			: base(ElementEq)
		{

		}


		public Set_withStaticElementEq(IEnumerable<T> collection)
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
			IEqualityComparer<Set_withStaticElementEq<T, TEq>>
		{

			static public bool Be(
				Set_withStaticElementEq<T, TEq> x, Set_withStaticElementEq<T, TEq> y
			)
			{

				return x.SetEquals(y);
			}

			static public bool NotEq(
							Set_withStaticElementEq<T, TEq> x, Set_withStaticElementEq<T, TEq> y
	
				) {
					return Be(x, y);


			}

			public bool Equals(Set_withStaticElementEq<T, TEq> x, Set_withStaticElementEq<T, TEq> y)
			{

				return x.SetEquals(y);
				throw new NotImplementedException();
			}

			public int GetHashCode(Set_withStaticElementEq<T, TEq> obj)
			{

				return 0;
				throw new NotImplementedException();
			}
		}



	}
}



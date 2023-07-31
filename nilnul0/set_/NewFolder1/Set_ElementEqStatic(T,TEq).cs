using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.set
{
	public class Set_ElementEqStatic<T, TEq>
		: HashSet<T>
		where TEq : IEqualityComparer<T>, new()
	{
		static public IEqualityComparer<T> EqOfElement = SingletonByDefaultNew<TEq>.Instance;

		public Set_ElementEqStatic()
			: base(EqOfElement)
		{

		}


		public Set_ElementEqStatic(IEnumerable<T> collection)
			: base(collection, EqOfElement)
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
			IEqualityComparer<Set_ElementEqStatic<T, TEq>>
		{

			static public bool Be(
				Set_ElementEqStatic<T, TEq> x, Set_ElementEqStatic<T, TEq> y
			)
			{

				return x.SetEquals(y);
			}

			static public bool NotEq(
							Set_ElementEqStatic<T, TEq> x, Set_ElementEqStatic<T, TEq> y
	
				) {
					return Be(x, y);


			}

			public bool Equals(Set_ElementEqStatic<T, TEq> x, Set_ElementEqStatic<T, TEq> y)
			{

				return x.SetEquals(y);
				throw new NotImplementedException();
			}

			public int GetHashCode(Set_ElementEqStatic<T, TEq> obj)
			{

				return 0;
				throw new NotImplementedException();
			}
		}



	}
}



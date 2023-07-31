using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.finite
{
	public partial class FiniteSet<T> : HashSet<T>
		, IEquatable<FiniteSet<T>>
	{



		//private Func<T,T,bool> _comparer;
		public FiniteSet(Func<T, T, bool> comparer)
			: base(new FuncAsEqualityComparer<T>(comparer))
		{

		}

		public FiniteSet()
			: base()
		{

		}


		
					

		public FiniteSet(IEnumerable<T> elements)
			: base(elements)
		{
		}

		public FiniteSet(IEnumerable<T> elements,Func<T,T,bool> comparer)
			: base(elements,new FuncAsEqualityComparer<T>(comparer))
		{
		}

		public FiniteSet(IEnumerable<T> elements, IEqualityComparer<T> comparer)
			: base(elements, comparer)
		{
		}

		public  bool Contains(T element)
		{
			foreach (var item in this)
			{
				if (this.Comparer.Equals(item, element))
				{
					return true;

				}


			}
			return false;

		}

		public FiniteSet<T> ExceptToNew(FiniteSet<T> toBeExcepted) {

			var r = new FiniteSet<T>(this,this.Comparer);
			r.ExceptWith(toBeExcepted);
			return r;
		}

		public void AddRange(params T[] elements) {
			foreach (var item in elements)
			{
				this.Add(item);
				
			}
			
		}









		//public static bool Is(Type t) {

		//    if (t.IsGenericType)
		//    {
		//        return t.GetGenericTypeDefinition() == typeof(FiniteSet<object>).GetGenericTypeDefinition();

		//    }
		//    return false;
		//}


		//public bool Equals(FiniteSet<T> other)
		//{
		//    return this.SetEquals(other);

		//}

		public bool Equals(FiniteSet<T> other)
		{
			return this.SetEquals(other);
		}
	}
}

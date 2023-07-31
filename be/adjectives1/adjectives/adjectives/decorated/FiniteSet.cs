using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using set.collection.nilnul;

namespace nilnul.collection.set
{
	public partial class FiniteSet<T> : HashSet<T>
		, IEquatable<FiniteSet<T>>
		,
		SetI<T>
	{

		//private Func<T,T,bool> _comparer;
		public FiniteSet(Func<T, T, bool> comparer)
			: base(new FuncComparer<T>(comparer))
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
			: base(elements,new global::set.collection.nilnul.FuncComparer<T>(comparer))
		{
		}

		public FiniteSet(IEnumerable<T> elements, IEqualityComparer<T> comparer)
			: base(elements, comparer)
		{
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
			return this.SetEquals(other);	//use this.comparer
		}

		public bool contains(T a)
		{
			return this.Contains(a);
		}
	}
}

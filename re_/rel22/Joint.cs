using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set;
using nilnul.collection.set.op.expr;

namespace nilnul.set.rel
{
	static public class JointX
	{
		static public nilnul.bit.Predicate<HashSet<T>, HashSet<T>> CreateAssert<T>() {
			return new Predicate<HashSet<T>, HashSet<T>>(Is);
		}

		static public nilnul.bit.Predicate<HashSet<T>, HashSet<T>> CreateDeny<T>()
		{
			return Predicate<HashSet<T>, HashSet<T>>.CreateNegativeFrom(Is);
		}

		static public class Singleton<T> {

			static public nilnul.bit.Predicate<HashSet<HashSet<T>>> enumerableDeny = nilnul.bit.Predicate<HashSet<HashSet<T>>>.CreateInverse(Is);
		
		}
		
		static public nilnul.bit.Predicate<HashSet<HashSet<T>>> CreateEnumerableDeny<T>()
		{
			return Singleton<T>.enumerableDeny;


		}

		static public bool Is<T>(HashSet<T> a, HashSet<T> b)
		{
			return a.Intersect(b).Count() > 0;

		}

		static public bool Is<T, Eq>(HashSet<T, Eq> a, HashSet<T, Eq> b)
			where Eq : IEqualityComparer<T>, new()
		{
			return a.Intersect(b, a.Comparer).Count() > 0;

		}

		static public bool No<T>(HashSet<T> a, HashSet<T> b)
		{
			return !Is(a, b);

		}

		static public bool Is<T>(Union2<T> a, HashSet<T> b)
		{
			return Is(a.toLiteral(), b);

		}

		static public bool Is<T>(HashSet<T> b,Union2<T> a )
		{
			return Is(a.toLiteral(), b);

		}

		static public bool Is<T, Eq>(Union2<T, Eq> a, HashSet<T, Eq> b)
			where Eq : IEqualityComparer<T>, new()
		{
			return Is(a.ToLiteral(), b);

		}

		static public bool Is<T, Eq>(HashSet<T, Eq> b, Union2<T, Eq> a)
	where Eq : IEqualityComparer<T>, new()
		{
			return Is(b, a.ToLiteral());

		}

		static public bool Is<TElement, Eq>(TElement element,HashSet<TElement, Eq> sets)
			where Eq : IEqualityComparer<TElement>, new()
		{
			return sets.Contains(element);
		}

		static public bool Is<TElement, Eq>(IEnumerable<HashSet<TElement, Eq>> sets)

			where Eq : IEqualityComparer<TElement>, new()

		{
			if (sets == null)
			{
				return false;

			}
			if (sets.Count() == 1)
			{
				return false;

			}

			return _Is(sets);

		}

		static public bool Is<TElement>(HashSet<HashSet<TElement>> sets)
		{

			if (sets == null)
			{
				return false;

			}
			if (sets.Count() == 1)
			{
				return false;

			}

			return _Is(sets);


		}

		

		static public bool _Is<TElement, Eq>(IEnumerable<HashSet<TElement, Eq>> sets_multiple)
			where Eq : IEqualityComparer<TElement>, new()
		{
			var skipped = sets_multiple.Skip(1);
			
			return  Is(
					skipped
				)  
				|| 
				
				Is(
					sets_multiple.First(),new Union2<TElement,Eq>(skipped)
				)
				;
		}
		


		static public bool _Is<TElement>(IEnumerable<HashSet<TElement>> sets_multiple)
			
		{
			if (sets_multiple.Count()==2)
			{
				return Is(sets_multiple.First(), sets_multiple.Skip(1).First());
				
			}

			var deheaded = sets_multiple.Skip(1);

			return _Is(
					deheaded
				)
				||

				Is(
					sets_multiple.First(), new Union2<TElement>(deheaded)
				)
				;
		}

		static public bool No<TElement, TEq>(IEnumerable<HashSet<TElement, TEq>> sets)

			where TEq : IEqualityComparer<TElement>, new()
		{
			return !Is(sets);

		}

		static public void AssertIs<T, Eq>(Union2<T, Eq> a, HashSet<T, Eq> b)
			where Eq : IEqualityComparer<T>, new()
		{
			nilnul.bit.AssertX.True(Is<T, Eq>(a, b));

		}



		static public void AssertNo<T, Eq>(Union2<T, Eq> a, HashSet<T, Eq> b)
			where Eq : IEqualityComparer<T>, new()
		{
			nilnul.bit.AssertX.False(Is<T, Eq>(a, b));

		}




	}
}

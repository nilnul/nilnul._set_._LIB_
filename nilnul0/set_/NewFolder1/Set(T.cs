using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	/// <summary>
	/// all the instances of T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete()]

	public partial class Set<T>
		: HashSet<T>
	{

		public Set()
		{
		}
		public Set(IEqualityComparer<T> eq)
			:base(eq)
		{

		}

		public Set<T> genEmpty() {
			return new Set<T>();
		}

		public Set(IEnumerable<T> elements, IEqualityComparer<T> eq)
			:base(elements,eq)
		{

		}
		public Set(IEnumerable<T> elements)
			:this(elements,EqualityComparer<T>.Default)
		{

		}

		public void AddRange(IEnumerable<T> elements)
		{
			if (elements == null)
			{
				return;
			}
			foreach (var item in elements)
			{
				Add(item);

			}
		}

		public void add(IEnumerable<T> elements)
		{
			if (elements == null)
			{
				return;
			}
			foreach (var item in elements)
			{
				Add(item);

			}
		}

		public override string ToString()
		{
			return String.Format("{{{0}}}", nilnul.collection.TostrX.Tostr(this));

			
		}

		public class Eq
			:IEqualityComparer<Set<T>>
		{
			private IEqualityComparer<T> _elementEq;

			public IEqualityComparer<T> elementEq
			{
				get { return _elementEq; }
				set { _elementEq = value; }
			}
			
			public Eq(IEqualityComparer<T> eq)
			{
				_elementEq = eq;

			}

			public Eq()
				:this(EqualityComparer<T>.Default)
			{

			}

			public bool Equals(Set<T> x, Set<T> y)
			{
				return x.SetEquals(y);

				throw new NotImplementedException();
			}

			public int GetHashCode(Set<T> obj)
			{
				return 1;
				throw new NotImplementedException();
			}
		}






	}
}

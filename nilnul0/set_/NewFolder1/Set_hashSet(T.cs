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
	public partial class Set_hashSet<T>
		: HashSet<T>
	{

		public Set_hashSet()
		{
		}
		public Set_hashSet(IEqualityComparer<T> eq)
			:base(eq)
		{

		}

		public Set_hashSet(IEnumerable<T> elements, IEqualityComparer<T> eq)
			:base(elements,eq)
		{

		}

		public Set_hashSet(IEnumerable<T> elements)
			: base(elements, EqualityComparer<T>.Default)
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







	}
}
namespace nilnul.set
{
	/// <summary>
	/// all the instances of T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Set_hashSet<T>
		: HashSet<T>
	{

		public Set_hashSet()
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




	}
}

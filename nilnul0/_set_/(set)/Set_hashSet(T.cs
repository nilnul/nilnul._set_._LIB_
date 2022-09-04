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

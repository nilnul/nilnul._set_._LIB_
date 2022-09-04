using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection
{
	/// <summary>
	/// all the instances of T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	static public partial class Set_hashSetX
	{



		static public void AddRange<T>(this HashSet<T> set, IEnumerable<T> elements)
		{
			if (elements == null)
			{
				return;
			}
			foreach (var item in elements)
			{
				set.Add(item);

			}
		}


	}
}

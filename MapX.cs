using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.map
{
	/// <summary>
	/// List is a special List with Key is of type natural
	/// Map is an alias for Dictionary
	/// </summary>
	static public partial class MapX
	{
		static public bool Equals<T>(IEnumerable<T> left, IEnumerable<T> right)
		{

			//as a dictionary of i.

			return left.SequenceEqual(right);

		}
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="enumerable"></param>
		/// <param name="index"></param>
		/// <returns></returns>
		/// <remarks>
		/// Excerpt is returning a set.
		/// </remarks>
		static public IEnumerable<T> Ignore<T>(this IEnumerable<T> enumerable, int index)
		{
			for (int i = 0; i < enumerable.Count(); i++)
			{
				if (i != index)
				{
					yield return enumerable.ElementAt(i);


				}

			}


		}


	}
}

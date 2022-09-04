using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{
	static public class IEnumerableIndexOfExtension
	{

		public static int FirstIndexOf<T>(this IEnumerable<T> enumerable, T element, IEqualityComparer<T> comparer = null)
		{
			int i = 0;
			comparer = comparer ?? EqualityComparer<T>.Default;
			foreach (var currentElement in enumerable)
			{
				if (comparer.Equals(currentElement, element))
				{
					return i;
				}

				i++;
			}

			return -1;
		}


		public static int FirstIndexOf<T>(this IEnumerable<T> enumerable, T element, Func<T,T,bool> comparer )
		{
			int i = 0;
			

			foreach (var currentElement in enumerable)
			{
				if (comparer(currentElement, element))
				{
					return i;
				}

				i++;
			}

			return -1;
		}
	}
}

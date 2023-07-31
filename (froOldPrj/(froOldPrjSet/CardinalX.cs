using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	/// <summary>
	/// cardinal, in addition to integer/ordinal, is extension of natural, 
	/// </summary>
	static public partial class CardinalX
	{

		static public int Eval<T>(
			this
			IEnumerable<T>	elements
			,IEqualityComparer<T> eq
		)
			
		{
			var set = new HashSet<T>(eq);

			foreach (var item in elements)
			{
				if (!set.Contains(item))
				{
					set.Add(item);
					
				}
				
			}

			return set.Count;


			throw new NotImplementedException();

		
		}

		static public int Eval<T, TEq>(
			IEnumerable<T> elements
			) 
			where TEq:IEqualityComparer<T>,new()
		
		{
			return Eval<T>(elements, SingletonByDefaultNew<TEq>.Instance);
		
		}
	}
}

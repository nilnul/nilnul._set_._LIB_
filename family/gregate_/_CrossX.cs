using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family
{
	/// <summary>
	/// 
	/// </summary>
	/// cross
	/// sect
	static public class _CrossX
	{
		static public HashSet<T> Intersect<T>(
			nilnul.set.Family<T> family
		)
			
		{
			var r = new HashSet<T>(family.elEq);

			family.ForEach(x => r.IntersectWith(x));

			return r;
		}

		static public HashSet<T> Intersect<T>(
			HashSet< HashSet<T> > family
			,
			IEqualityComparer<T> elEq
		)
			
		{
			return Intersect(new Family<T> (elEq, family));
		}



	}
}

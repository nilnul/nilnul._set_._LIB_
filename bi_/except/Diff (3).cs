using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	static public partial class SubtractX
	{
		static public HashSet<T> Subtract<T>(this HashSet<T> a,HashSet<T> b) {
			HashSet<T> r = new HashSet<T>(a);
			r.ExceptWith(b);
			return r;
			
		}

		static public HashSet<T> Complement<T>(this HashSet<T> a,HashSet<T> universal) {
			if (a.IsSubsetOf(universal))
			{
				return universal.Subtract(a);
			}
			else
			{
				throw new Exception(string.Format("{0} is not a subset of {1}",a,universal));
			}
		}

	}
}

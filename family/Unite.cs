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
	/// unite
	/// unison
	/// uniform
	/// 
	static public class _UniteX
	{
		static public HashSet<T> Unite<T>(
			nilnul.set.Family<T> family
		)
			
		{
			var r = new HashSet<T>(family.elEq);

			family.ForEach(x => r.UnionWith(x));

			return r;
		}

		static public HashSet<T> Unite<T>(
			HashSet< HashSet<T> > family
			,
			IEqualityComparer<T> elEq
		)
			
		{
			return Unite(new Family<T> (elEq, family));
		}



	}
}

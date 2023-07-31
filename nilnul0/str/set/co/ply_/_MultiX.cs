using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.set.co.ply_
{
	static public class _MultiX
	{
	

		static public IEnumerable<IEnumerable<T>> Op_assumeSets_byLinq<T>(
			IEnumerable< IEnumerable<T>> a
			,
			IEnumerable<IEnumerable<T>> b
			
		) {

			return (from x in a
					from y in b
					select x.Concat(y) );
		}

	


	}

	
}

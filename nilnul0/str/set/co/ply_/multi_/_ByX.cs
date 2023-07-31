using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.set.co.ply_.multi_
{
	static public class _ByX
	{
		static public IEnumerable<IEnumerable<T>> Op_assumeSets<T>(
			IEnumerable< IEnumerable<T>> a
			,
			IEnumerable<IEnumerable<T>> b
			
		) {

			return a.SelectMany(x => b.Select(y=> x.Concat(y)    )  );
		}

	

		static public IEnumerable<IEnumerable<T>> Op_assumeSets_byJoin<T>(
			IEnumerable< IEnumerable<T>> a
			,
			IEnumerable<IEnumerable<T>> b
			
		) {

			return a.Join(b,x=>true, y=>true, (m,n)=>m.Concat(n));
		}


	}

	
}

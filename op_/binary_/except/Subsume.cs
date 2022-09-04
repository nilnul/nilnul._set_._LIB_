using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.except
{
	static public class _SubsumeX
	{
		static public void ExceptOnOld<T>(HashSet<T> univ,  params IEnumerable<T>[] sets) {
			

			foreach (var item in sets)
			{
				univ.Except(item);
			}
		}

		static public HashSet<T> ExceptAsNew<T>(HashSet<T> univ,  params IEnumerable<T>[] sets) {
			var r = new HashSet<T>(univ,univ.Comparer);

			ExceptOnOld(r, sets);
			return r;
		}


	}
}

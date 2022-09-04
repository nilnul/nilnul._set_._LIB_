using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.collection
{
	static public class X
	{
		static public string ToTxt(this IEnumerable x,string separator) {
			return string.Join(separator, x.ToObjSeq_cast());
		}

		static public string ToTxt(this IEnumerable<object> x,string separator=",") {
			return string.Join(separator, x);
		}

		[Obsolete("ToObjSeq_cast")]
		static public IEnumerable<object> ToObjSeq(this IEnumerable list)
		{

			foreach (var item in list)
			{
				yield return item;
			}

		}
		static public IEnumerable<object> ToObjSeq_cast(this IEnumerable list)
		{

			return list.Cast<object>();

		}

	}
}

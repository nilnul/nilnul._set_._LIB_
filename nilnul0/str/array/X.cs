using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.array
{
	static public class X
	{
		static public string ToTxt<T>(this T[] x,string separator) {
			return $"[{collection.X.ToTxt( x,separator)}]";
        }
		static public string ToTxt<T>(this T[] x) {
			return ToTxt(x,",");
        }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix.rel
{
	static public partial class EqX
	{
		static public int GetHashCode<T>(T[,] x) {

			var r = 0;
			foreach (var item in x)
			{
				r ^= item.GetHashCode();
			}
			return r;
		}
	}
}

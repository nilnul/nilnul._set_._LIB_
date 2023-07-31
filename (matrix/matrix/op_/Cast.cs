using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slew_.matrix.op_
{
	static public class _CastX
	{
		static public R[,] Cast<T,R>(this T[,] a, Func<T,R> func) {
			var r = new R[ a.GetLength(0),a.GetLength(1)];

			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					r[i, j] = func(a[i,j]);

				}
			}
			return r;
		}
	}
}

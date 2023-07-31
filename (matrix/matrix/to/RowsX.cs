using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix.to
{
	static public class RowsX
	{

		static public IEnumerable<T[]> Eval<T>(this T[,] matrix)
		{

			return MatrixX.Rows(matrix);

		}

	}
}

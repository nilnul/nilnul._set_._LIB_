using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.matrix.to_
{
	[Obsolete("nilnul.num::nilnul.obj.matrix.Dim")]
	public static  class _DimX
	{

		static public _matrix.dimension_.OfInt DimOfInt<T>( T[,] matrix)
		{
			return new _matrix.dimension_.OfInt(matrix.GetLength(0), matrix.GetLength(1));
		

		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix.to
{
	public class Txt
	{

		static public string Eval<T>( T[,] matrix)
		{
			var rows = collection.matrix.MatrixX.Rows(matrix);
			return collection.vector.to.Txt.Eval(
				rows.Select(c=>collection.vector.to.Txt.Eval(c))
				
			);
		

		}

	}
}

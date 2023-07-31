using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.matrix.fro_
{
	public static class _StrX
	{

		public static T[,] _CreateMatrix_discardRemainders<T>(this IEnumerable<T> elements, int rows)
		{
			var dimension = _matrix.dimension_.OfInt._CreateFro_discardRemainder(elements.Count(), rows);

			var matrix = _FroX.CreateFroDimension<T>(dimension);
			
			for (int i = 0, strIndex = 0; i < dimension.rows; i++ )
			{

				for (var j = 0; j < dimension.cols; j++)
				{
					matrix[i, j] = elements.ElementAt(strIndex);
					strIndex++;

				}
				 
			}
			return matrix;
		}
	}
}

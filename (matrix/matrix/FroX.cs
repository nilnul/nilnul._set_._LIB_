using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.matrix
{
	static public class _FroX
	{
		static public T[,] CreateFroDimension<T>(this _matrix.Dimension dimension) {
			return new T[dimension.rows,dimension.cols];
		}
static public T[,] CreateFroDimension<T>(this _matrix.dimension_.OfInt dimension) {
			return new T[dimension.rows,dimension.cols];
		}	}
}

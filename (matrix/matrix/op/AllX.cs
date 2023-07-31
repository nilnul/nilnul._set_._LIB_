using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix.op
{
	static public class AllX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="vector"></param>
		/// <returns></returns>
		static public T[,] ToMatrixVertical<T>(this T[] vector)
		{
			return vector.ToMatrix().Transpose();
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection._matrix
{
	static public class PromoteX
	{
		static public T[,] ToMatrix<T>(this T[] vector)
		{
			T[,] r = new T[1, vector.Length];
			for (int i = 0; i < r.GetLength(1); i++)
			{
				r[0, i] = vector[i];
			}
			return r;
		}

	
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.collection.matrix
{
	public partial class Matrix
	{
		static public T[,] Transpose<T>(T[,] matrix)
		{
			T[,] r = new T[matrix.GetLength(1), matrix.GetLength(0)];
			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix[j, i];
				}
			}
			return r;
		}

		static public Matrix<T> Transpose<T>(Matrix<T> matix) {

			return new Matrix<T>(Transpose( matix.components));
		
		}


	

	}
}

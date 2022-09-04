using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection.matrix
{
	static public partial class IntToBoolMatrix
	{
		static public bool[,] Eval(int[,] matrix) {
			if (matrix==null)
			{
				return null;
				
			}

			bool[,] r=new bool[matrix.GetLength(0),matrix.GetLength(1)];

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					r[i, j] = matrix[i, j]==0?false:true;

				}

			}
			return r;
		
		}
	}
}

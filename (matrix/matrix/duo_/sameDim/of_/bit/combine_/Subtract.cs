using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.matrix.duo_.sameDim.of_.bit.combine_
{
	public class Subtract
	{
		static public bool[,] _Subtract_sameSize(bool[,] a_square, bool[,] b_square)
		{
			var len = a_square.GetLength(0);
			var r = new bool[len, len];
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					r[i, j] = nilnul.bit.op.binary.NotImply.Eval(a_square[i, j], b_square[i, j]);
				}
			}
			return r;
			//throw new NotImplementedException();
		}
	}
}
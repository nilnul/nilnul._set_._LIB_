using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slew_.matrix_
{
	public class Square<T> : nilnul.slew_.matrix.be_.Square<T>.En
	{
		public Square(T[,] val) : base(val)
		{
		}

		public int dimension { get {
				return avowed.GetLength(0);
			} }
	}
}

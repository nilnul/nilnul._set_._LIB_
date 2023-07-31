using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.matrix.be_
{
	static public class _SquareX
	{
		static public bool Square<T>(T[,] matrix) {
			return  nilnul.matrix.to_._DimX.DimOfInt(matrix).beSquare;

		}
	}
	
	/// <summary>
/// what is the dimension of [0,3]?
/// </summary>
/// <typeparam name="T"></typeparam>
	public class Square<T> : BeI<T>
	{
		public bool be(T[,] m)
		{
			return  nilnul.matrix.to_._DimX.DimOfInt(m).beSquare;
		}
		public class En :
			be.En<T, Square<T>>

		{
			public En(T[,] val) : base(val)
			{
			}
		}
	}
}

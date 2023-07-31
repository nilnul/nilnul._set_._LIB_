using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.slew_.matrix.be_
{
	public class Square<T> : BeI<T>
	{
		public bool be(T[,] m)
		{
			return m.GetLongLength(0) == m.GetLongLength(1);
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

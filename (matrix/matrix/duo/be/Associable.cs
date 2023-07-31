using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix.duo.be
{
	public partial class Associable
	{
		static public bool Eval<T>(T[,] a, T[,] b) {
			return a.GetLength(0) == b.GetLength(1);
		}
	}

	public class Associable<T>
		: nilnul.ReI<T[,], T[,]>
	{
		public bool be(T[,] obj, T[,] obj1)
		{
			return Associable.Eval(obj, obj1);
			//throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.matrix.duo.be_
{
	public  class SameDimension
	{
		static public bool Eval<T>(T[,] a, T[,] b) {
			return a.GetLength(1) == b.GetLength(0);
		}
	}

	public class SameDimension<T>
		: nilnul.ReI<T[,], T[,]>
		,
		nilnul.matrix.duo.BeI<T>

	{
		public bool be(Duo<T> obj)
		{
			return be(obj.Item1,obj.Item2);
		}

		public bool be(T[,] obj, T[,] obj1)
		{
			return Associable.Eval(obj, obj1);
			//throw new NotImplementedException();
		}

		public class En : nilnul.be.Asserted_assertDefaultDiscarded<Duo<T>, Associable<T>>
		{
			public En(Duo<T> val) : base(val)
			{
			}
		}
	}
}

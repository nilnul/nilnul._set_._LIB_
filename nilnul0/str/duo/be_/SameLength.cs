using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.str.be_
{
	public class SameLength<T>
		:str.duo.BeI<T>
	{
		static public bool Eval(T[] a, T[] b) {

			return a.Length == b.Length;

		}
		static public bool Eval(IEnumerable<T> a, IEnumerable<T>  b) {

			return a.Count() == b.Count();

		}

		public bool be(Duo<T> obj)
		{
			return Eval(obj.Item1, obj.Item2);

			//throw new NotImplementedException();
		}

		public class En :
			nilnul.be.Asserted_assertDefaultDiscarded<Duo<T>, SameLength<T>>
		{
			public En(Duo<T> val) : base(val)
			{
			}
		}
	}
}

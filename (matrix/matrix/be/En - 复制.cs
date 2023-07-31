using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.slew_.matrix.be
{
	public class En<T>
		: nilnul.obj.be.En<T[,], BeI<T>>
	{
		public En(T[,] val, BeI<T> be) : base(val, be)
		{
		}
	}

	public class En<T, TBe>
		: En<T>
		where TBe : BeI<T>,new()
	{
		public En(T[,] val) : base(val, SingletonByDefault<TBe>.Lazy)
		{
		}
	}
}

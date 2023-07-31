using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.seq;
using nilnul.slew_;
using nilnul.obj;

namespace nilnul.matrix.str.be_
{
	public class Started<T> : BeI<T>
	{
		

		public bool be(IEnumerable<T[,]> obj)
		{
			if (obj.Any())
			{
				return true;
			}


			return false;

		}


		static public readonly Started<T> Singleton = SingletonByDefault<Started<T>>.Instance;

		public class En : nilnul.be.Asserted_assertDefaultDiscarded<IEnumerable<T[,]>, Started<T>>
		{
			public En(IEnumerable<T[,]> val) : base(val)
			{
			}
		}

	}
}

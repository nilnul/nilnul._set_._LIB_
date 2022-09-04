using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.matrix.str.be_
{
	public class StartedProductable<T>
		: nilnul.be_.FroAnd_defaultable<
			IEnumerable<T[,]>, Started<T>, Productable<T>
			>
	{

		public class En : nilnul.be_.FroAnd_defaultable<
				IEnumerable<T[,]>, Started<T>, Productable<T>

			>.En

		{
			public En(IEnumerable<T[,]> val) : base(val)
			{
			}
		}


		static public readonly StartedProductable<T> Singleton = SingletonByDefault<StartedProductable<T>>.Instance;

	}
}

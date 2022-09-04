using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.seq;
using nilnul.slew_;

namespace nilnul.matrix.str.be_
{
	public class Productable<T> : BeI<T>
	{
		public bool _be(T[,] matrix,IEnumerable<T[,]> str )
		{
			if (str.None())
			{
				return true;
			}

			return be(str) && 
				nilnul.matrix.duo.be_.Associable.Eval(
				
					matrix, str.First()
				);


		}

		public bool be(IEnumerable<T[,]> obj)
		{
			if (obj.None())
			{
				return true;
			}


			return _be(obj.First(), obj.Skip(1));

		}


		static public readonly Productable<T> Singleton = SingletonByDefault<Productable<T>>.Instance;

		public class En : nilnul.be.Asserted_assertDefaultDiscarded<IEnumerable<T[,]>, Productable<T>>
		{
			public En(IEnumerable<T[,]> val) : base(val)
			{
			}
		}

	}
}

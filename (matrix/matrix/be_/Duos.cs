using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.matrix.be_
{
	/// <summary>
	/// a two-demensional array, and the first dimension length is two.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Duos<T> : BeI<T>
	{
		public bool be(T[,] m)
		{
			return m.GetLongLength(1) == 2;
		}
		public class En :
			be.En<T, Duos<T>>

		{
			public En(T[,] val) : base(val)
			{
			}

			public En():this( new T[0,2])
			{

			}

			static public En Create(params T[] elements) {
				if (elements.Length%2==1)
				{
					throw new ArgumentException("not pairwise");

				}

				var r = new T[ elements.Length / 2,2];
				for (int k=0,  i = 0,j=1; j < elements.Length; k++,i+=2,j+=2)
				{
					r[k, 0] = elements[i];
					r[k, 1] = elements[j];
				}
				return new be_.Duos<T>.En( r);
			}
			static public En Create_XsYs(params T[] elements) {
				if (elements.Length%2==1)
				{
					throw new ArgumentException("not pairwise");

				}

				var half = elements.Length/2;

				var r = new T[ half,2];

				for (int i = 0,j=half; j < elements.Length; i++,j++)
				{
					r[i, 0] = elements[i];
					r[i, 1] = elements[j];
				}
				return new be_.Duos<T>.En( r);
			}


		}
	}
}

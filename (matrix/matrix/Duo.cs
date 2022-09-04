using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.matrix
{
	public class Duo<T>
		: nilnul.Duo<T[,]>
	{
		public Duo(T[,] a, T[,] b) : base(a, b)
		{
		}
	}
}

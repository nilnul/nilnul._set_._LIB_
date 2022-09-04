using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	public class Duo<T>
		: nilnul.Duo<IEnumerable<T>>
	{
		public Duo(IEnumerable<T> a, IEnumerable<T> b) : base(a, b)
		{
		}
	}
}

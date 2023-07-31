using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.ofSeq_.binary_
{
	public class Except<T>
		:
		set.op_.OfSeq<T>,
		BinaryI<T>
	{
		public Except(IEqualityComparer<T> val) : base(val)
		{
		}

		public IEnumerable<T> op(IEnumerable<T> par, IEnumerable<T> par1)
		{
			return par.Except(par1);
			//throw new NotImplementedException();
		}


	}
}

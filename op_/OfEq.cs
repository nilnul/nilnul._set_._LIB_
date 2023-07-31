using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_
{
	public class OfSeq<T>
		:
		nilnul._set_.ElEqA_ovEl<T>
	{
		public OfSeq(IEqualityComparer<T> val) : base(val)
		{
		}
	}
}

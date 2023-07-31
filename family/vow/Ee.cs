using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.vow
{
	public class Ee<TEl>
		:
		nilnul.obj.vow.Ee1<nilnul.set.Family<TEl>>
	{
		public Ee(Family<TEl> val, VowI2<Family<TEl>> vow) : base(val, vow)
		{
		}
	}
}

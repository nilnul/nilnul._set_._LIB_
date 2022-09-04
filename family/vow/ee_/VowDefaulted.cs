using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.vow.ee_
{
	public class VowDefaulted<TEl, TVow>
		: Ee<TEl>
		where TVow : VowI2<Family<TEl>>,new()
	{
		public VowDefaulted(Family<TEl> val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}

using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be.vow_
{
	public class BeDefaulted<TEl, TBe>
		:
		family.be.Vow<TEl>
		where TBe : nilnul.obj.BeI1<Family<TEl>>, new()
	{
		public BeDefaulted() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		static public BeDefaulted<TEl, TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaulted<TEl, TBe>>.Instance;
			}
		}

	}
}

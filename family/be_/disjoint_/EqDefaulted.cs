using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_.disjoint_
{
	public class EqDefaulted<TEl, TElEq>
		: Disjoint<TEl>
		where TElEq : IEqualityComparer<TEl>, new()
	{
		public EqDefaulted() : base(nilnul.obj_.Singleton<TElEq>.Instance)
		{
		}
	}
}

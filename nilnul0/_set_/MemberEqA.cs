using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set_
{
	public class MemberEqA_ovEl<TEl> :
		nilnul.obj.Box1<IEqualityComparer<TEl>>
		,
		nilnul.obj._set_.MemberEqI<TEl>
	{

		public IEqualityComparer<TEl> elEq
		{
			get { return boxed; }
		}

		public IEqualityComparer<TEl> memberEq => boxed;

		public MemberEqA_ovEl(IEqualityComparer<TEl> val) : base(val)
		{

		}
	}
}

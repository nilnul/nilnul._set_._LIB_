using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set_
{
	public interface MemberEqI<TEq>
	{
		TEq memberEq { get; }
		
	}

	public interface MemberEqI_ovMember<T>:MemberEqI<IEqualityComparer<T>> {
	}
}

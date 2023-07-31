using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.set.re_
{
	public  class _DisjointX
	{
		static public bool Re<T, TEq>(
			nilnul.obj.Set<T,TEq> set
			,
			nilnul.obj.Set<T,TEq> set1
			
		)
			where TEq:IEqualityComparer<T>,new()
		{
			return !_JointX.Re(set,set1);
		}
	}
}

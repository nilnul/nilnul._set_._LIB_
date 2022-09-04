using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_.disjoint_
{
	static public class _ByRecurX
	{
		static public bool Be<T, TEq>(
			IEnumerable<nilnul.obj.Set<T, TEq>> sets
		)
			where TEq : IEqualityComparer<T>, new()
		{
			if (nilnul.obj.seq.be_._NoneX.None(sets))
			{
				return true;
			}
			return Be(
				sets.First()
				, sets.Skip(1)
			);
		}

		static public bool Be<T, TEq>(
			nilnul.obj.Set<T, TEq> head
			,
			IEnumerable<nilnul.obj.Set<T, TEq>> tail
		)
			where TEq : IEqualityComparer<T>, new()
		{
			return nilnul.obj.str.be_._NoneX.None(
				tail, x => nilnul.set.re_._JointX.Re(x, head)
			)
			&&
			Be(tail);
		}
	}
}
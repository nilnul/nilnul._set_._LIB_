using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_
{

	public class Disjoint<T>
		: nilnul.set._family_.elEq.MemberEq<T>
		,
		family.BeI<T>
	{
		public Disjoint(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool be(Family<T> obj)
		{
			return _DisjointX.Be(obj, this.elEq);
		}
	}
}
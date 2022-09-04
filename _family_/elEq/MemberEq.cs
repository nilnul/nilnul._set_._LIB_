using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set._family_.elEq
{
	public class MemberEq<T> :

		ElEqA<T>
		
	{
		private nilnul.obj.set.Eq<T> _memberEq;

		public nilnul.obj.set.Eq<T> memberEq
		{
			get { return _memberEq; }
		}

		public MemberEq(IEqualityComparer<T> val) : base(val)
		{
			_memberEq = new obj.set.Eq<T>(val);
		}
	}
}

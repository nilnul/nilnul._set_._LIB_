using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set_
{
	[Obsolete("el means the non-dividable. If used in family, it means the eq of element of the set, which is a member of the family")]
	public class ElEqA_ovEl<TEl> :
		nilnul.obj.Box1<IEqualityComparer<TEl>>
		
	{

		public IEqualityComparer<TEl> elEq
		{
			get { return boxed; }
		}

		public ElEqA_ovEl(IEqualityComparer<TEl> val) : base(val)
		{

		}
	}
}

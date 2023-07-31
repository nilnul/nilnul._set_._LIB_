using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.cord
{
	public class Eq<TEl> :
		nilnul.obj.str_.seq.Eq<IEnumerable<TEl>>

		//nilnul._set_.ElEqA_ovEl<TEl>
		,

		IEqualityComparer<
			IEnumerable<IEnumerable<TEl>
		>
	>
	{

		//nilnul.obj.str_.seq.Eq<TEl> memberEq;
		public Eq(IEqualityComparer<TEl> val) : base(
			new obj.str_.seq.Eq<TEl>(val)
		)
		{



		}

		public Eq() : this(EqualityComparer<TEl>.Default)
		{

		}



	}
}

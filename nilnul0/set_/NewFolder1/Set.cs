using nilnul.collection.set;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
	[Obsolete()]
	public partial class Set:HashSet<object>
		,
		SetI
	{

		public Set()
		{

		}

		public Set(IEnumerable elements):base(elements as IEnumerable<object>)
		{
		}
					

		public override string ToString()
		{
			return ToStrX2.ToStr(this);
		}


					

	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.set
{
	public partial class EmptyX
	{
		static public nilnul.bit.Predicate<IEnumerable<object>> PredicateOfIEnumerable=new nilnul.bit.Predicate<IEnumerable<object>>(IsEmpty);

		static public bool IsEmpty(IEnumerable<object> x) {
			nilnul.obj.Null.AssertNotNull(x);
			return x.Count() ==0;
		}

		
	}
}

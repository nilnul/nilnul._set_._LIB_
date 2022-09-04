using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.rel
{
	public partial class Empty<T>:nilnul.bit.Predicate<IEnumerable<T>>
	{

		public Empty()
			:base(EmptyX.Is)
		{

		}
					
	}

	
}

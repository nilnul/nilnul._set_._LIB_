using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.sequence
{
	public partial class Empty<TElement>
		:nilnul.bit.AdjectiveI3<IEnumerable<TElement>>
	{
		public bool be(NotNull2<IEnumerable<TElement>> val)
		{
			return ! val.val.Any();
			throw new NotImplementedException();
		}

		public partial class AdjToNoun 
			:nilnul.bit.AdjectiveTowardNoun2<IEnumerable<TElement>,Empty<TElement>>
		{ 
		
		}
	}

}

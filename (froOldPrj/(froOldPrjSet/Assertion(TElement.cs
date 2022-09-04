using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	public partial class Assertion<TElement>
		
	{
		private SetI<TElement> _set;

		public SetI<TElement> set
		{
			get { return _set; }
			set { _set = value; }
		}
		

		public Assertion(SetI<TElement> set)
		{
			this.set = set;
		}

		public void assertContains(TElement element) {
			nilnul.bit.AssertionNullaryFunc.True(set.contains(element));
		}

		public void assertNotContains(TElement element)
		{
			nilnul.bit.AssertionNullaryFunc.False(set.contains(element));
		}
					

	}
}

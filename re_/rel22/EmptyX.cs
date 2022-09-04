using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.collection.set.rel
{
	static public partial class EmptyX
	{
		static public bool Is<T>(IEnumerable<T> sets) {
			return sets.Count() == 0;
		}

		static public bool Not<T>(IEnumerable<T> set) {

			return !Is(set);
		
		}

		static public void Assert<T>(IEnumerable<T> set) {
			AssertX.True(set.Count() == 0);

		
		}

		static public void Deny<T>(IEnumerable<T> set)
		{
			AssertX.True(set.Count() == 0);


		}

	}
}

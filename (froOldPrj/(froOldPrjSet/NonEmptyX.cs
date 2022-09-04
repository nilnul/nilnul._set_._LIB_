using nilnul.collection.set;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	static public partial class NonEmptyX
	{
		static public bool NonEmpty(NotNull2<IEnumerable<object>> set) {
			return set.val.Any();
		}

		static public bool NonEmpty(IEnumerable<object> set)
		{
			return NonEmpty(new NotNull2<IEnumerable<object>>(set));
		}


		static public NonEmptyEnumerable<T> ToNonEmpty<T>(this IEnumerable<T> sequence ) {
			return new NonEmptyEnumerable<T>(sequence);
		}

		static public nilnul.bit.Predicate<IEnumerable<object>> PredicateOfIEnumerable = new nilnul.bit.Predicate<IEnumerable<object>>(NonEmpty); 
		
		static public nilnul.bit.Predicate<NotNull2<IEnumerable<object>>> PredicateOfNotNullIEnumerable = new nilnul.bit.Predicate<NotNull2<IEnumerable<object>>>(NonEmpty);
	}
}

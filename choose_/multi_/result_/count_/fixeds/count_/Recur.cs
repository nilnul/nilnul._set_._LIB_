using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.choose_.multi_.result_.count_.fixeds.count_
{
	/*
	 The above recurrence may be interpreted as follows. Let [n] :=  {1,2,..., n} be the source set. There is always exactly one (empty) multiset of size 0, and if n = 0 there are no larger multisets, which gives the initial conditions.

Now, consider the case in which n,k > 0. A multiset of cardinality k with elements from [n] might or might not contain any instance of the final element n. If it does appear, then by removing n once, one is left with a multiset of cardinality k − 1 of elements from [n], and every such multiset can arise, which gives a total of

n choose k-1 possibilities.

		If n does not appear, then our original multiset is equal to a multiset of cardinality k with elements from [n − 1], of which there are
		n-1 choose k

Thus,

n choose k= n choose k-1  +  n-1 choose k
		 */
	class Recur
	{
	}
}

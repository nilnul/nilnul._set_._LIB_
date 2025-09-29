using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	[Obsolete()]

	public class Permutate
	{
		[Obsolete(nameof(_PermutateX.Permutate))]
		static public IEnumerable<nilnul.obj.str.be_.Distinct.OfEnumerable<T>.En> Eval<T>(
			HashSet<T> set
		)
		{
			if (set.Any())
			{
				foreach (var item in set)
				{
					var deheadedSet = new HashSet<T>(set, set.Comparer);
					deheadedSet.Remove(item);

					foreach (var permutated in Eval<T>(deheadedSet))
					{
						yield return new obj.str.be_.Distinct.OfEnumerable<T>.En(set.Comparer, new[] { item }.Concat(permutated.avowed));

					}
				}

			}
			else
			{
						yield return new obj.str.be_.Distinct.OfEnumerable<T>.En(
							set.Comparer,  new T[0] );
				
			}
		}




	}
}

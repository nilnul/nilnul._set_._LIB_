using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set.op.expr;
using nilnul.set.rel;

namespace nilnul.set
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// partial partition is a family of disjoint sets.
	/// partition is a partial partition whose sets are:a) the subset of the universe; b) the union is the universe.
	/// </remarks>
	public partial class Partition
	{



		static public bool IsPartial<TElement>(HashSet<TElement> universe, HashSet<HashSet<TElement>> partition)
		{

			var x=JointX.Singleton<TElement>.enumerableDeny.is_(partition);

			var y = true;
			foreach (var item in partition)
			{

				y &= universe.IsSupersetOf(item);
				
			}
			return x & y;

		}

		static public bool Is<TElement>(HashSet<TElement> universe, HashSet<HashSet<TElement>> partition) {

			return IsPartial(universe, partition) && universe.SetEquals(
				new Union2<TElement>(partition).toLiteral()	
			);


		
		}

		static public HashSet<T> _Class<T>(HashSet<HashSet<T>> partition, T element)
		{

			foreach (var set in partition)
			{
				if (set.Contains(element))
				{
					return set;

				}


			}
			return null;

		}

	}
}

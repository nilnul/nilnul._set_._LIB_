using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set.op.expr;
using nilnul.set.rel;



namespace nilnul.collection.set
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// partial partition is a family of disjoint sets.
	/// partition is a partial partition whose sets are:a) the subset of the universe; b) the union is the universe.
	/// </remarks>
	public partial class Partition<T>
		: HashSet<HashSet<T>>
	{


		static public HashSet<T> _Class(HashSet<HashSet<T>> partition, T element)
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


namespace nilnul.set
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// partial partition is a family of disjoint sets.
	/// partition is a partial partition whose sets are:a) the subset of the universe; b) the union is the universe.
	/// </remarks>
	public partial class Partition<T>
		:HashSet<HashSet<T>>
	{


		static public HashSet<T> _Class(HashSet<HashSet<T>> partition, T element) {

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

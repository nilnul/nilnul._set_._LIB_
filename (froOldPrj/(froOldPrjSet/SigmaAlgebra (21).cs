using nilnul.set;
using nilnul_obj.collection.set.finite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.finite
{
	/// <summary>
	///Is a set of sets related to set X. And the set satisfy the following conditions:
	///
	/// X is element of the set.
	/// 
	/// if A is element of the set, so is the compliment of A.
	/// 
	/// if Ai is elements of the set, so is the union of Ai, given Ai is a sequence of subsets of 
	/// 
	/// </summary>
	/// <remarks>
	/// sigmaAlgebra is an extension of algebra in that it not only includes union,intersection and complementation of finite terms, but also coutable infinite terms.
	/// </remarks>
	static public partial class SigmaAlgebraX
	{
		static void Main(string[] args)
		{
			var sets = new FiniteSet<FiniteSet<int>>();


			var universe = new FiniteSet<int>();

			universe.AddRange(3);
			universe.AddRange(2);
			universe.AddRange(7);



			var some = new FiniteSet<int>();
			some.AddRange(2);



			var someOther = new FiniteSet<int>();
			someOther.AddRange(7);

			var s7 = new FiniteSet<int>();
			s7.AddRange(7);
			s7.AddRange(2);
			s7.AddRange(3);

			var s8 = new FiniteSet<int>();
			s8.AddRange(7, 2);

			var s9 = new FiniteSet<int>();
			s9.AddRange(7, 3);

			var s19 = new FiniteSet<int>();
			s19.AddRange(2, 3);


			sets.AddRange(universe);
			sets.AddRange(new FiniteSet<int>());
			sets.AddRange(some);

			//sets.AddRange(universe.ExceptToNew(some));
			//sets.AddRange(someOther);
			sets.AddRange(s9);


			System.Diagnostics.Debug.WriteLine(Check(sets, universe));






		}


		static public bool Check<T>(FiniteSet<FiniteSet<T>> sets, FiniteSet<T> universe)
		{

			//System.Diagnostics.Debug.Write(
			//    sets.SetEquals(
			//        new FiniteSet<FiniteSet<T>>(
			//            (a, b) => a.SetEquals(b)
			//        )
			//    )

			//    );


			//	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value);

			//where TSource=FinisteSet<int>




			return

				///the given set is in the sets.
				sets.Contains(universe)

				&&


				/// all are the subset of given set.
				sets.All(
					x => x.IsSubsetOf(universe)
				)

				&&



				///the compliment set of each element is in the sets.
				sets.All(
					x => sets.Contains(new FiniteSet<T>(universe.Except(x)))


				)

	&&
				///the union of each subsets of sets is in the given set.
				///

				PowerSetX.ToHashSets(sets).All(
					x => sets.Contains(x.Aggregate(new FiniteSet<T>(), (a, c) => new FiniteSet<T>(a.Union(c))))
				);





		}



		/// <summary>
		/// sets must has no duplicate elements.
		/// </summary>
		/// <param name="sets"></param>
		/// <returns></returns>
		//static public bool Check<T>(HashSet<HashSet<T>> sets,HashSet<T> universe) {

		//    var ttt=sets == new HashSet<HashSet<T>>();

		//    return

		//        ///the given set is in the sets.
		//        sets.Contains(universe)

		//        &&


		//        /// all are the subset of given set.
		//        sets.All(
		//            x => x.IsSubsetOf(universe)
		//        )

		//        &&

		//        ///the union of each subsets of sets is in the given set.
		//        ///

		//        PowerSetX.ToHashSets(sets).All(
		//            x=>sets.Contains(x.Aggregate(new HashSet<T>(),(a,c)=>new HashSet<T>( a.Union(c))))
		//        )

		//        &&


		//        ///the compliment set of each element is in the sets.
		//        sets.All(
		//            x => sets.Contains(universe.Except(x))
		//        )
		//        ;




		//}











	}//class


}

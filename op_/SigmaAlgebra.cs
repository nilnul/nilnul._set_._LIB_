using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element.collection.set;
using nilnul.collection.set;

namespace nilnul.element.realNumber.set
{
	/// <summary>
	///Is a collection of sets related to X, which is a set. And the element of the collection satisfy the following conditions:
	///
	/// X is element of the set.
	/// 
	/// if A is element of the set, so is the compliment of A.
	/// 
	/// if Ai is elements of the set, so is the union of Ai, given Ai is a sequence of subsets of X
	/// 
	/// </summary>
	public class SigmaAlgebra
	{

		public SetI universal;
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="set"></param>
		/// <param name="subsets">a set of sets</param>
		public SigmaAlgebra(SetI universal)
		{
			
			this.universal=universal;
			

		}
        /// <summary>
        /// determine whether a set is an algebra of another set that's finite.
        /// </summary>
        /// <param name="universal"></param>
        /// <param name="set"></param>
        /// <returns></returns>

       static public void AssertSigmaAlgebra<T>(HashSet<T> universal,HashSet<HashSet<T>> algebra) {

           ///every set in algebra must be a subset of universal
		   ///

		   foreach (var item in algebra)
		   {
			   if (!item.IsSubsetOf(universal))
			   {
				   throw new Exception(string.Format("{0} is not subset of {1}",item,algebra));
				   
			   }
			   
		   }
       

           //every set must be closed under complement operation

           HashSet<T> newUniv=new HashSet<T>(universal);

		   foreach (var item in algebra)
		   {
			   if (!item.Complement(universal).IsSubsetOf(universal))
			   {
				   throw new Exception(string.Format("{0}'s complement is not a subset of {1}",item,universal));
				   
			   }
		   }
           //the union of the sets must be there.
		   foreach (var item in combinatorics.Combinate.Eval(algebra)) {
			   if (!UnionFiniteX.Union(item).IsSubsetOf(universal))
			   {
				   throw new Exception(string.Format("{0}'s union is not a subset of {1}",item.ToStr(),universal));
				   
			   }
		   }
        }

       

	




		/// <summary>
		/// sets must has no duplicate elements.
		/// </summary>
		/// <param name="sets"></param>
		/// <returns></returns>
		//static public bool IsSigmaAlgebraOf(Set[] sets) {

		//    return


		//        /// all are the subset of given set.
		//        sets.All(
		//            x => x.subSetOf(set)
		//        )

		//        &&

		//        ///the given set is in the sets.
		//        sets.Contains(x)

		//        &&




		//        ///the compliment set of each element is in the sets.
		//        sets.All(
		//            x => x.compliment.subSetOf(set)
		//        )

		//        &&

		//        ///the union of each subsets of sets is in the given set.
		//        sets.Subsets().All(
		//            x => x.Aggregate(
		//                    (w, c) => w + c
		//                ).elementOf(sets)

		//        )



		//    ;

			

 
		//}

		

		

		//static public bool IsSigmaAlgebra(Set<Set> sigmaAlgebra,Set universal) {
		//    return
		//        sigmaAlgebra.All(
		//            x => x.IsSubsetOf(universal)
		//        )

		//        &&

		//        sigmaAlgebra.Contains(univeral)
		//        &&

		//        sigmaAlgebra.All(
		//            x => (sigmaAlgebra.Contains(x.complimentIn(univeral)))
		//        )

		//        &&

		//        sigmaAlgebra.SubsetsUnions().All(
		//            x => x.elementOf(sigmaAlgebra)
		//        )
		//    ;
				




		//}

		//public IEnumerable<List<Set>> Subsets()
		//{
			

		//    List<Set> c;

		//    for (int i = 0; i < 2 ^ this.Length;i++ )
		//    {
		//        for (int j = 0; j < this.Length;i++ )
		//        {
		//            if(i&j==1){
		//                c.Add(this[j]);
		//            }

		//        }



		//        yield return c;
				
				

		//    }
			



		}
	}//class

	static public class SigmaAlgebra_Extension {

		//static public IEnumerable<Set> SubsetsUnions(this Set<Set> sigmaAlgebra) {
		//    return SubsetsUnions<object>(sigmaAlgebra);
		//}


		//static public IEnumerable<Set<T>> SubsetsUnions<T>(this Set<Set<T>> sigmaAlgebra)
		//{


		//    Set<T> c=new Set<T>();

		//    foreach(bool[] combi in Combination.Combinations(sigmaAlgebra.Count)){

		//        for(int i=0;i<combi.Length;i++){
		//            if(combi[i]){
		//                c.UnionWith(sigmaAlgebra.ElementAt(i));
		//            }
		//        }
		//        yield return c;

		//    }
		//}

	//}
}

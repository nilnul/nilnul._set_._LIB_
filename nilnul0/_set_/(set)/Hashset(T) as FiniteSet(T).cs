using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.collection.set.finite
{
	/// <summary>
	/// a collection of elements, which are differnt eachother.
	/// 
	/// A set is a finite or infinite collection of objects in which order has no significance, and multiplicity is generally also ignored (unlike a list or multiset). Members of a set are often referred to as elements and the notation  is used to denote that  is an element of a set . The study of sets and their properties is the object of set theory. 


	/// </summary>
	

		

	/// <summary>
	/// order and multiplicity is ignored, unlike list or sequence, or multiset.
	/// </summary>
    public partial class HashsetAsFiniteSet<T>
		: HashSet<T>,FiniteSetI<T>
		//where T:IEquatable<T>  ?required for being required by ISet<T>?
	{

		public HashsetAsFiniteSet(params T[] array):base(array) { 
		}

		public HashsetAsFiniteSet(IEnumerable<T> list) : base(list) { }

		

		

		public  HashsetAsFiniteSet<T> Add(IEnumerable<T> array) { 
			foreach(T element in array){
				this.Add(element);
				
			}
			return this;
		}



       
    }//class
	
	
}//namespace

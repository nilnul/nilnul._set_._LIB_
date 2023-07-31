using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.collection.set
{

	/// <summary>
	/// extends some methods related to Vector. For one-dimensional array can be regarded as vector, we extend some vector methods to one-dimensional arrays.
	/// Of course we can box one-dimensional array as vector then compute and then unbox.
	/// </summary>
	static public partial class TostrX {

		/// <summary>
		/// s
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="vector"></param>
		/// <returns></returns>
		/// 
///		[Obsolete("see collection.Collection")]
		static public string Tostr<T>(this IEnumerable<T> vector,string seperator)
		{

			
			return string.Format("{{{0}}}",nilnul.collection.TostrX.Tostr<T>(vector));

		}


		static public string Tostr(this IEnumerable vector, string seperator)
		{

			return Tostr<object>(vector as IEnumerable<object>, seperator);
			

		}


		static public string Tostr(this IEnumerable enumerable)
		{
			return enumerable.Tostr(",");
		}

		static public string Tostr<T>(this IEnumerable<T> vector)
		{
			return vector.Tostr(",");
		}



		
		

	}


	
}

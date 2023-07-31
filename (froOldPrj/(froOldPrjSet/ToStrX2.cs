using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.set
{

	/// <summary>
	/// extends some methods related to Vector. For one-dimensional array can be regarded as vector, we extend some vector methods to one-dimensional arrays.
	/// Of course we can box one-dimensional array as vector then compute and then unbox.
	/// </summary>
	static public partial class ToStrX2
	{

		public const char SEPERATOR = ',';

		static public string Seperator
		{
			get
			{
				return SEPERATOR.ToString();
			}
		}

		/// <summary>
		/// s
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="vector"></param>
		/// <returns></returns>
		/// 
				[Obsolete("see collection.Collection")]
		static public string Tostr<T>(this IEnumerable<T> vector, string seperator)
		{

			bool isEmpty = true;
			return vector.Aggregate(
				"",
				(w, c) =>
				{
					if (isEmpty) { isEmpty = false; return w + c; }
					else
					{
						return w + seperator + c;
					}
				}

			);

		}

		static public string ToStr_flat<T>(this IEnumerable<T> vector, string seperator)
		{

			if (vector == null)
			{
				return null;

			}
			if (vector.Any())
			{
				var str = vector.First().ToString();

				foreach (var item in vector.Skip(1))
				{
					str += seperator + (item).ToString();

				}
				return str;

			}
			return "";




		}

		static public string ToStr_flat<T>(this IEnumerable<T> vector, char seperator)
		{

			return ToStr_flat<T>(vector, seperator.ToString());




		}

		static public string ToStr_flat<T>(this IEnumerable<T> vector)
		{

			return ToStr_flat<T>(vector, Seperator);




		}

		static public string ToStr<T>(this IEnumerable<T> vector, string seperator)
		{

			if (vector == null)
			{
				return null;

			}
			if (vector.Any())
			{
				var str = ToStr(vector.First(), seperator);

				foreach (var item in vector.Skip(1))
				{
					str += seperator + ToStr(item);

				}
				return str;

			}
			return "";




		}
		static public string ToStr_byAggregate<T>(this IEnumerable<T> vector, string seperator)
		{

			bool isEmpty = true;

			return vector.Aggregate(
				"",
				(w, c) =>
				{
					if (isEmpty) { isEmpty = false; return w + c; }
					else
					{
						return w + seperator + c;
					}
				}

			);
		}

		

		static public string ToStr(this IEnumerable vector, string seperator)
		{

			return ToStr(X.ToTyped(vector), seperator);


		}


		static public string ToStr(this IEnumerable vector)
		{

			return ToStr(vector, ",");


		}

		static public string ToStr(this object o)
		{
			return ToStr(o, Seperator);

		}

		static public string ToStr(this object o, string separator)
		{
			if (o is IEnumerable)
			{
				//return nilnul.element.collection.CollectionTostrX.Tostr((IEnumerable)o);
				return ToStrX2.ToStr(o as IEnumerable, separator);
			}
			else
			{
				return o.ToString();
			}

		}


		[Obsolete()]

		static public string Tostr(this IEnumerable enumerable)
		{
			return Tostr(",");
		}

		[Obsolete()]
		static public string Tostr<T>(this IEnumerable<T> vector)
		{
			return ToStr<T>(vector, ",");
		}






	}



}

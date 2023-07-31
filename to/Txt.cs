using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.collection.to
{

	/// <summary>
	/// extends some methods related to Vector. For one-dimensional array can be regarded as vector, we extend some vector methods to one-dimensional arrays.
	/// Of course we can box one-dimensional array as vector then compute and then unbox.
	/// </summary>
	static public partial class Txt
	{

		public const char SEPERATOR = ',';

		static public string Seperator
		{
			get
			{
				return SEPERATOR.ToString();
			}
		}


		static public string Eval_byJoin<T>(this IEnumerable<T> vector, string seperator)
		{

			return string.Join(seperator, vector);

		}
		static public string Eval_byJoin<T>(this IEnumerable<T> vector, char seperator)
		{
			return Eval_byJoin(vector, seperator.ToString());
		}
		static public string Eval_byJoin<T>(this IEnumerable<T> vector)
		{
			return Eval_byJoin(vector, SEPERATOR);

		}

		static public string Eval_flat<T>(this IEnumerable<T> vector, string seperator)
		{


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

		static public string Eval_flat<T>(this IEnumerable<T> vector, char seperator)
		{

			return Eval_flat<T>(vector, seperator.ToString());


		}

		static public string Eval_flat<T>(this IEnumerable<T> vector)
		{

			return Eval_flat<T>(vector, Seperator);



		}

		static public string Eval<T>(this IEnumerable<T> vector, string seperator)
		{
			return Eval_byJoin(vector, seperator);

		}

		static public string Eval_parenthesisRound<T>(IEnumerable<T> x)
		{
			return string.Format("({0})", collection.to.Txt.Eval(x));
		}
		static public string Eval_bracketSquare<T>(IEnumerable<T> x)
		{
			return string.Format("[{0}]", collection.to.Txt.Eval(x));
		}
		static public string Eval_braceCurly<T>(IEnumerable<T> x)
		{
			return string.Format("{{{0}}})", collection.to.Txt.Eval(x));
		}

		static public string Eval_byAggregate<T>(this IEnumerable<T> vector, string seperator)
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



		static public string Eval(this IEnumerable vector, string seperator)
		{

			return Eval(nilnul.set.X.ToTyped(vector), seperator);


		}


		static public string Eval(this IEnumerable vector)
		{

			return Eval(vector, ",");


		}














	}



}

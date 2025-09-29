using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace nilnul.collection
{
	static public class EqualX
	{
		static public bool Eval<T>(T[,] a,T[,] b,Func<T,T,bool> comparer) {
			if (a==null || a.Length==0)
			
			{
				if (b == null || b.Length==0)

				{
					return true;
				
				}
				return false;
				
			}

			if (a.GetLength(0)!=b.GetLength(1) || a.GetLength(1) != b.GetLength(1))
			{
				return false;
			}

			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (!comparer(a[i,j],b[i,j]))
					{
						return false;
						
					}
					
				}
				
			}
			return true;
		
		}

		static public bool Equal<T>(IEnumerable<T> a, IEnumerable<T> b, Func<T, T, bool> comparer)
		{
			if (a.Count()!=b.Count())
			{
				return false;
			}

			for (int i = 0; i < a.Count(); i++)
			{
				if (!comparer(a.ElementAt(i),b.ElementAt(i)))
				{
					return false;

					
				}
				
			}
			return true;

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public bool Eq(this object a, object b)
		{
			if (a is IEnumerable)
			{
				if (b is IEnumerable)
				{
					return Eq((IEnumerable)a, (IEnumerable)b);
				}
				else
				{
					return false;
				}

			}
			else
			{
				///for reference type, conpare the refence, for value type compare the value.
				return a.Equals(b);
			}

		}

		/// <summary>
		/// compare the list. 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		static public bool Eq(IEnumerable a,IEnumerable b) {
			if (a.Count()!=b.Count())
			{
				return false;
				
			}

			var aNumerator=a.GetEnumerator();
			var bNumerator=b.GetEnumerator();

			while (aNumerator.MoveNext())
			{
				if (!Eq( aNumerator.Current,bNumerator.Current))
				{
					return false;

					
				}
				
			}
			return true;




			


		
		}






		static public bool Equal<T>(IEnumerable<T> a, IEnumerable<T> b)

		{
			return Equal(a, b, (x,y)=>x.Equals(y));

		}

	
	}
}

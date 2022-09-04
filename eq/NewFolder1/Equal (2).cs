using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{
	public class Equal
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

		static public bool Eval<T>(IEnumerable<T> a, IEnumerable<T> b, Func<T, T, bool> comparer)
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

	
	}
}

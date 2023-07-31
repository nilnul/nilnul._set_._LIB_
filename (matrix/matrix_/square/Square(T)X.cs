using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{
	static public partial class SquareX<T>
		
		
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		/// <exception cref=""> null reference</exception>
		static public bool Is(T[,] a) {
			if (a==null)
			{
				return true;
				
			}
			if (a.GetLength(0)==a.GetLength(1))
			{
				return true;
				
			}
			return false;
		}

	

		


		


		static public bool Not(T[,] a)
		{
			return !Is(a);
		}
		static public void Assert(T[,] a) {

			if (Not(a))
			{
				throw new ArgumentException();
				
			}
		
		}

		
	}
}

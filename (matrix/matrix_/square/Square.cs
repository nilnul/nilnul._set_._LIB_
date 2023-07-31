using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix.square
{
	public partial class Square<T>:Matrix<T>
	{

		public Square(T[,] m)
		{
			Assert(m);

			components = m;
		
		}

		public Square(Matrix<T> a)
		{
			this.components=a.components.Clone() as T[,];

		}
					
					
		
		static public bool Is(T[,] m) {
			if (m==null)
			{

				//return true;

				throw new ArgumentNullException();
				
			}
			return m.GetLongLength(0) == m.GetLongLength(1);
		
		}

		static public bool Not(T[,] m) {
			return !Is(m);
		}

		static public void Assert(T[,] m) {
			if (Not(m))
			{
				throw new Exception("matrix is not square.");
				
			}
		
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix
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
			
			return Is(m.ToNotNull());
		
		}


		static public bool Is(NotNull2<T[,]> m)
		{
			
			return _Is(m);

		}

		static public bool _Is(T[,] m_notNull)
		{
			
			return m_notNull.GetLongLength(0) == m_notNull.GetLongLength(1);

		}

		static public bool _Is_notNull(T[,] _notNull)
		{

			return _notNull.GetLongLength(0) == _notNull.GetLongLength(1);

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

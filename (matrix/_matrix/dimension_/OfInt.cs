using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._matrix.dimension_
{
	[Obsolete("nilnul.num::nilnul.obj.matrix.Dim")]

	public struct OfInt:IEquatable<OfInt>
	{
		int _rows;
		int _cols;
		public int rows {
			get {
				return _rows;
			}
		}
		public int cols {
			get {
				return _cols;
			}
		}

		public OfInt(uint rows, uint cols)
		{
			checked
			{
				if (rows==0 || cols==0)
				{
					_rows = 0;_cols = 0;
					return;

				}
			this._cols = ( (int)cols);
			this._rows = ((int) rows );

			}
		}

		public OfInt(int rows,int cols)
			:this(
				 checked((uint)rows)
				 ,
				 checked((uint)cols )
				 )
		{
			 
			
		}


		static public OfInt CreateFro(int length, int rows) {
			int remainder;
			var divRem = Math.DivRem(length, rows, out remainder);
			if (remainder!=0)
			{
				throw new ArgumentException("cannot divide with 0 remainder");

			}
			return new _matrix.dimension_.OfInt(rows, divRem);
		}			



		static public OfInt _CreateFro_discardRemainder(int length, int rows) {
			 
			
			return new _matrix.dimension_.OfInt(rows, length/rows);
		}	
	

		public  bool Equals(OfInt obj)
		{
			return obj.cols == this.cols && obj.rows == this.rows;
		}

		static public readonly OfInt Zero = new OfInt();

		static public bool operator ==(OfInt x, OfInt y)
		{

			return x.Equals(y);

		}
		static public bool operator !=(OfInt x, OfInt y)
		{

			return !(x==y);

		}

		public bool beSquare {
			get {
				return _cols == _rows;
			}
		}

		


	}
}

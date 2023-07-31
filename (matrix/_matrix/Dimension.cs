using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._matrix
{
	public  struct Dimension:IEquatable<Dimension>
	{
		ulong _rows;
		ulong _cols;
		public ulong rows {
			get {
				return _rows;
			}
		}
		public ulong cols {
			get {
				return _cols;
			}
		}

		public Dimension(ulong rows, ulong cols)
		{
			this._cols = cols;
			this._rows = rows;
		}

		public Dimension(long rows,long cols)
		{
			
				this._cols = (ulong)cols;
				this._rows = (ulong)rows;
			
		}


		static public Dimension CreateFro(int length, int rows) {
			int remainder;
			var divRem = Math.DivRem(length, rows, out remainder);
			if (remainder!=0)
			{
				throw new ArgumentException("cannot divide with 0 remainder");

			}
			return new _matrix.Dimension(rows, divRem);
		}			



		static public Dimension _CreateFro_discardRemainder(int length, int rows) {
			 
			
			return new _matrix.Dimension(rows, length/rows);
		}	
	

		public  bool Equals(Dimension obj)
		{
			return obj.cols == this.cols && obj.rows == this.rows;
		}

		static public readonly Dimension Zero = new Dimension();

		static public bool operator ==(Dimension x, Dimension y)
		{

			return x.Equals(y);

		}
		static public bool operator !=(Dimension x, Dimension y)
		{

			return !(x==y);

		}

		


	}
}

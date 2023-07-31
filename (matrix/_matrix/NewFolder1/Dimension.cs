using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.matrix
{
	/// <summary>
	/// the order or dimension of matrix.
	/// </summary>
	/// 
	[Obsolete()]
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

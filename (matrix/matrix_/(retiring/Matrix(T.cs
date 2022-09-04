using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix
{
	public partial class Matrix<T>
		:IEquatable<Matrix<T>>
	{
		T[,] _components;

		public T[,] components
		{
			get { return _components; }
			set {

				_components = value ?? new T[0, 0]; 
			}
		}

		public Matrix()
		{
			this.components = new T[0, 0];
		}
					


		public Matrix(T[,] a)
		{
			this.components = a;
		}









	

		public bool Equals(Matrix<T> other)
		{
			return MatrixX.Eq(this, other);
		}

		public override string ToString()
		{
			string seperator = ",";
			string r = "";
			r += "{";
			for (uint i = 0; i < this.components.GetLength(0); i++)
			{
				r += "{";

				for (uint j = 0; j < this.components.GetLength(1); j++)
				{
					r += this.components[i, j];
					r += ",";
				}
				r = r.Remove(r.Length - seperator.Length);
				r += "}";
				r += ",";
			}
			r = r.Remove(r.Length - seperator.Length);
			r += "}";
			return r;
		}
	}
}

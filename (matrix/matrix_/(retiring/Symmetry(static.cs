using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.matrix
{
	static public partial class Symmetry
	{
		static public bool Eval<T>(Square<T> s) {
			return Matrix.Transpose(s).Equals(s);
		
		}
	}
}

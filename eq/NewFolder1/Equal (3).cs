using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.finite
{
	public partial class Equal<T>: EqualityComparer<T>
		
	{

		private Func<T,T,bool> _comparer;
		public Equal(Func<T,T,bool>comparer)
		{
			this._comparer = comparer;

		}










		public override bool Equals(T x, T y)
		{
			return _comparer(x,y);
		}

		public override int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace set.collection.nilnul_obsolete
{
	[Obsolete(nameof(nilnul.set.EqI<T>))]

	public partial class FuncComparer<T> : System.Collections.Generic.EqualityComparer<T>
	{

		private Func<T, T, bool> _comparer;
		public FuncComparer(Func<T, T, bool> comparer)
		{
			this._comparer = comparer;

		}




		public override  bool Equals(T x, T y)
		{
			return _comparer(x, y);
		}

		public override int GetHashCode(T obj)
		{
			return 0;
		}
	}
}

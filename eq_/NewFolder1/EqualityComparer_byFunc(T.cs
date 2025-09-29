using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.set
{
	[Obsolete(nameof(nilnul.set.EqI<T>))]
	public partial class EqComparer_byFunc<T> : System.Collections.Generic.EqualityComparer<T>
	{

		private Func<T, T, bool> _comparer;
		public EqComparer_byFunc(Func<T, T, bool> comparer)
		{
			this._comparer = comparer;

		}



		public override bool Equals(T x, T y)
		{
			return _comparer(x, y);
		}

		public override int GetHashCode(T obj)
		{
			return 0;
		}


	}
}



namespace nilnul.collection.set
{
	public partial class Equal<T>: IEqualityComparer<T>
		
	{

		private Func<T,T,bool> _comparer;

		public Equal(Func<T,T,bool>comparer)
		{
			this._comparer = comparer;

		}

		static public bool Equals(HashSet<T> a,HashSet<T> b) {

			return a.SetEquals(b);
		
		}

		static public bool Equals(IEnumerable<T> a, IEnumerable<T> b,Func<T,T,bool> equator)
		{

			return new HashSet<T>(a).SetEquals(new HashSet<T>(b));

		}
		





		public  bool Equals(T x, T y)
		{
			return _comparer(x,y);
		}

		public  int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}
	}
}


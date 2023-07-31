using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set._eq_
{
	public interface OnSeqI<T>
		:
		IEqualityComparer<IEnumerable<T>>
	{
	}
	public class OnSeq<T>
		:
		nilnul.obj.Box_ofIn<IEqualityComparer<T>>
		,
		IEqualityComparer<IEnumerable<T>>
	{
		public OnSeq(in IEqualityComparer<T> val) : base(val)
		{
		}

		public OnSeq(IEqualityComparer<T> x) : base(x)
		{
		}

		public OnSeq():this(EqualityComparer<T>.Default)
		{
				
		}

		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{
			return _OnSeqX.Eq(x, y, this.boxed);

		}

		public int GetHashCode(IEnumerable<T> obj)
		{

			return 0;
		}


		static public OnSeq<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<OnSeq<T>>.Unison;
			}
		}

	}


}

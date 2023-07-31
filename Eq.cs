using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using nilnul.collection.set;
using nilnul.collection.set.finite;
using nilnul.set;

namespace nilnul.set
{

	/// <summary>
	///  setEquals
	/// </summary>
	public interface IEq { }

	public interface IEq<TEl>:IEq { }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		eq, which is occupied in _nilnul_
	public interface EqI1<T>
		:IEqualityComparer<HashSet<T>>,IEq
	{
	}

	public class Eq<T>
		: EqI1<T>
		,
		_eq_.OnSeqI<T>
	{
		public bool Equals(HashSet<T> x, HashSet<T> y)
		{
			co_.elEqSame_.xpn_.ElEqNotSameException.Vow(x, y);
			return x.SetEquals(y);
		}

		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{
			return _eq_._OnSeqX.Eq(x,y);
		}

		public int GetHashCode(HashSet<T> obj)
		{
			return obj.GetHashCode();
			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

		static public Eq<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq<T>>.Unison;
			}
		}


	}




	[Obsolete(nameof(_eq_._OnSeqX))]
	static public class EqualsX
	{
	




		static public bool Equals<T>(IEnumerable<T> a, IEnumerable<T> b, Func<T, T, bool> equator)
		{

			return new FiniteSet<T>(a, equator).SetEquals(new FiniteSet<T>(b, equator));

		}








	}
}

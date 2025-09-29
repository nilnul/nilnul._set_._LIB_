using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using nilnul.collection.set;
using nilnul.collection.set.finite;
using nilnul.set;

namespace nilnul.set
{

	public class Eq1<T>
		:
		nilnul.obj.Genre<T>
		,

		EqI1<T>
		,
		_eq_.OnSeqI<T>
	{
		//private IEqualityComparer<T> _elEq;

		public Eq1(in IEqualityComparer<T> eq) : base(eq)
		{
		}

		public Eq1():this( EqualityComparer<T>.Default)
		{
				
		}

		[Obsolete("use base.eq instead")]
		public IEqualityComparer<T> elEq
		{
			get { return base.eq; }
			set { base.eq =  value; }
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{
			return _eq_._OnSeqX.Eq(x,y,this.eq);
		}

		/// <summary>
		/// note the elEq of each arg is disregarded. Rather the eleq in this instance is used instead.
		/// To use the elEq in the arg, to create such instance with that elEq as parameter;
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(HashSet<T> x, HashSet<T> y)
		{
			return Equals((IEnumerable<T>)x,y);

		}


		public int GetHashCode(HashSet<T> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

		static public Eq1<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq1<T>>.Unison;
			}
		}


	}
}

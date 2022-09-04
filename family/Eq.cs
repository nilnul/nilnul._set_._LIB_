using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family
{
	public class Eq<TEl> :
		nilnul.obj.set.Eq<HashSet<TEl>>

		//nilnul._set_.ElEqA_ovEl<TEl>
		,

		IEqualityComparer<
			IEnumerable<IEnumerable<TEl>		>
		>
		,
		nilnul.set._family_.ElEqI<TEl>

	{
		 IEqualityComparer<TEl> _elEq ;

		public IEqualityComparer<TEl> elEq => _elEq;

		//nilnul.obj.str_.seq.Eq<TEl> memberEq;
		public Eq(IEqualityComparer<TEl> val) : base(
			new obj.set.Eq<TEl>(val)
		)
		{
			this._elEq = val;


		}

		public Eq() : this(EqualityComparer<TEl>.Default)
		{

		}

		/// <summary>
		/// assume distinct; if it's not distinct, repeated elements will be removed.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public bool Equals(IEnumerable<IEnumerable<TEl>> x, IEnumerable<IEnumerable<TEl>> y)
		{
			return base.Equals(
				new nilnul.set.Family<TEl>(this._elEq,x)
				,
					new nilnul.set.Family<TEl>(this._elEq,y)
		);
		}

		public int GetHashCode(IEnumerable<IEnumerable<TEl>> obj)
		{
			return base.GetHashCode(
new nilnul.set.Family<TEl>(this._elEq,obj)
			);
		}
	}
}

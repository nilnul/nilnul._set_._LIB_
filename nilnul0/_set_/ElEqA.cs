using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set_
{
	[Obsolete("el means the non-dividable. If used in family, it means the eq of element of the set, which is a member of the family")]

	///
	public class ElEqA_ovEl<TEl> :
		nilnul.obj.Box1<IEqualityComparer<TEl>>
		,
		elEq_.OvMemberI<TEl>
		
	{

		public IEqualityComparer<TEl> elEq
		{
			get { return boxed; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="val"></param>
		public ElEqA_ovEl(IEqualityComparer<TEl> val) : base(val)
		{

		}

		public ElEqA_ovEl():this( EqualityComparer<TEl>.Default )
		{
				
		}


		static public ElEqA_ovEl<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ElEqA_ovEl<TEl>>.Unison;
			}
		}

	}
}

using nilnul.obj.set_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.delta_
{
	

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TEl"> as this is of the obj, not the type of the set, hence this type is defined in namespace "nilnul.obj.set.op_.binary_.Delta"</typeparam>
	public class ElEqDefault<TEl,TElEq>
		:nilnul.obj.op_.BinaryI<
			nilnul.obj.set_.EqDefaulted<
				TEl,TElEq
			>
		>
		where TElEq:IEqualityComparer<TEl>,new()
	{
		/// <summary>
		/// with reference to circled plus, which denotes logical Xor
		/// </summary>
		/// <remarks>
		/// sometimes,
		///		∆ is used.
		/// </remarks>
		public const char Symbol = '⊖'; // (U+2296);

		public EqDefaulted<TEl, TElEq> op(EqDefaulted<TEl, TElEq> par, EqDefaulted<TEl, TElEq> par1)
		{
			return new EqDefaulted<TEl, TElEq>( op_.binary_.Delta<TEl>.Singleton.op(par,par1)
			);
			//throw new NotImplementedException();
		}


		static public ElEqDefault<TEl, TElEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ElEqDefault<TEl, TElEq>>.Instance;
			}
		}

	}
}

using nilnul.set_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.eq8default_
{

	/// <summary>
	/// alias:delta difference
	///		symmetric difference
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// also known as the disjunctive union
	public class Delta<TEl,TEq>
		:
		nilnul.set.op_.binary_.Eq8defaultI<TEl,TEq>
		,
		nilnul.obj.op_.binary_.ICommutable

		where TEq:IEqualityComparer<TEl>,new()
	{
		/// <summary>
		/// with reference to circled plus, which denotes logical Xor
		/// </summary>
		/// <remarks>
		/// sometimes,
		///		∆ is used.
		///		△
		///		<see cref="nilnul.bit.op_.binary_.Ne.TXT"/>
		/// </remarks>
		public const char Symbol = '^'; // (U+2296);
	
		public Eq8static<TEl, TEq> op(Eq8static<TEl, TEq> par, Eq8static<TEl, TEq> par1)
		{
			var r = new Eq8static<TEl, TEq>(par);
			 r.SymmetricExceptWith(par1);
			return r;

		}




		static public Delta<TEl, TEq> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Delta<TEl, TEq>>.Unison;
			}
		}



	}
}

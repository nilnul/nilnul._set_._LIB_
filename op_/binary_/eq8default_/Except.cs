using nilnul.set_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.eq8default_
{

	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// alias:
	///		not imply
	///		nonimply
	///		but
	///		bar
	///		except
	///		subtract
	///		
	public class Except<TEl,TEq>
		:
		nilnul.set.op_.binary_.Eq8defaultI<TEl,TEq>
		,
		nilnul.obj.op_.binary_.ICommutable

		where TEq:IEqualityComparer<TEl>,new()
	{
		public const char Symbol = '-'; 
	
		public Eq8static<TEl, TEq> op(Eq8static<TEl, TEq> par, Eq8static<TEl, TEq> par1)
		{
			var r = new Eq8static<TEl, TEq>(par);
			 r.ExceptWith(par1);
			return r;

		}



		static public Except<TEl,TEq> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Except<TEl,TEq>>.Unison;
			}
		}



	}
}

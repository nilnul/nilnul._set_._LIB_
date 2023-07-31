using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.unary_.complement_.eq8default_
{

	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Omega8default<TEl, TEq, TOmega>
		:
		Eq8default<TEl, TEq>
		where TEq : IEqualityComparer<TEl>, new()
		where TOmega : nilnul.set_.Eq8static<TEl, TEq>, new()
	{

		public Omega8default() : base(
			 nilnul._obj.typ_._UnisonX<TOmega>.Unison
		)
		{
		}


		static public Omega8default<TEl, TEq, TOmega> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Omega8default<TEl, TEq, TOmega>>.Unison;
			}
		}

	}
}

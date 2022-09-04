using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_.disjoint
{
	public class _VowX
	{
		static public void Vow<T, TEq>(nilnul.set.Family<T, TEq> family)
			where TEq:IEqualityComparer<T>,new()
		{
			nilnul.obj.vow_.True.Singleton.vow( nilnul.set.family.be_._DisjointX.Be(family));
		}
	}

	public class Vow<TEl>
		:
		nilnul.set.family.be.Vow<TEl>
	{
		public Vow(Disjoint<TEl> be) : base(be)
		{
		}
		public Vow(IEqualityComparer<TEl> val):base(new Disjoint<TEl>(val) )
		{

		}
	}

	public class Vow_eqDefaulted<TEl, TEq>
		: Vow<TEl>
		where TEq : IEqualityComparer<TEl>, new()
	{
		public Vow_eqDefaulted() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}
	}
}
